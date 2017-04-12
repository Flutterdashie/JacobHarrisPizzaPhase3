using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JacobHarrisPizzaPhase1
{
    public partial class frmPizzaOrder : Form
    {
        SqlConnection sqlConn;
        SqlDataAdapter sqlDA;
        DataTable dtCust;
        SqlCommandBuilder sqlCmdBlr;
        string strDataSrc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Pizza.mdf;";
        string strSQLparms = "Integrated Security=True;Connect Timeout=10";
        const decimal SALES_TAX_RATE = 0.07M;
        int currentOrderNum;
        public frmPizzaOrder()
        {
            InitializeComponent();
        }
        private decimal getPizzaSubtotal()
        {
            decimal subtotal = 0.00M;
            if (radSizeLarge.Checked)
            {
                subtotal = 15.00M;
            }
            else if (radSizeMedium.Checked)
            {
                subtotal = 12.00M;
            }
            else
            {
                subtotal = 9.00M;
            }

            //This is a huge mess right now, but in phase 3 I'm going to switch the checkboxes to a condensed form.

            subtotal += clbToppings.CheckedItems.Count;

            subtotal *= nudPizzaCount.Value;
            return subtotal;
        }
        private void resetForm()
        {
            acceptToolStripMenuItem.Enabled = false;
            btnAccept.Enabled = false;
            lblOrderNumValue.Text = String.Format("{0:0000}", currentOrderNum);
            //It feels so clunky to do it this way, I'm gonna revise this as soon as I can.
            //Empty all text boxes first
            txtCustPhone.ResetText();
            txtCustName.ResetText();
            txtCustAddress1.ResetText();
            txtCustAddress2.ResetText();
            txtCustCity.ResetText();
            txtCustZipCode.ResetText();

            //Reset combo/numeric up/dn
            cboCustState.SelectedIndex = 23;
            cboPaymentMethod.SelectedItem = cboPaymentMethod.Items[0];
            nudPizzaCount.Value = nudPizzaCount.Minimum;

            //Reset Checkboxes
            for (int i = 0; i < clbToppings.Items.Count; i++)
                clbToppings.SetItemCheckState(i, CheckState.Unchecked);

            //Reset Radio buttons (default is small)
            radSizeLarge.Checked = false;
            radSizeMedium.Checked = false;
            radSizeSmall.Checked = true;
        }

        private void CustSearch()
        {
            string strPhone = txtCustPhone.Text;
            string sqlSelect = "SELECT * FROM Customers WHERE CustPhone = '" + strPhone + "';";
            string strConn = strDataSrc + strSQLparms;
            sqlConn = new SqlConnection(strConn);
            sqlConn.Open();  //grab that connection
            sqlDA = new SqlDataAdapter(sqlSelect, sqlConn);
            dtCust = new DataTable();
            sqlDA.Fill(dtCust);
            if (dtCust.Rows.Count > 0)
            {
                txtCustName.Text = dtCust.Rows[0]["CustName"].ToString();
                txtCustAddress1.Text = dtCust.Rows[0]["CustAddress1"].ToString();
                txtCustAddress2.Text = dtCust.Rows[0]["CustAddress2"].ToString();
                txtCustCity.Text = dtCust.Rows[0]["CustCity"].ToString();
                cboCustState.Text = dtCust.Rows[0]["CustState"].ToString();
                txtCustZipCode.Text = dtCust.Rows[0]["CustZip"].ToString();
            }
            else
            {
                MessageBox.Show("Customer not found. Accepting current order will create database entry.", "New Customer", MessageBoxButtons.OK);
                txtCustName.Focus();
            }
            

        }

        private void addCust(Customer newCust)
        {
            try
            {
                DataRow custToAdd;
                custToAdd = dtCust.NewRow();
                custToAdd["CustPhone"] = newCust.Phone;
                custToAdd["CustName"] = newCust.Name;
                custToAdd["CustAddress1"] = newCust.Addr1;
                custToAdd["CustAddress2"] = newCust.Addr2;
                custToAdd["CustCity"] = newCust.City;
                custToAdd["CustState"] = newCust.State;
                custToAdd["CustZip"] = newCust.Zip;
                dtCust.Rows.Add(custToAdd);
                sqlCmdBlr = new SqlCommandBuilder(sqlDA);
                sqlCmdBlr.GetUpdateCommand();
                sqlDA.Update(dtCust);
            }
            catch (SqlException e)
            {
                DialogResult logErrorData = MessageBox.Show("Customer Adding failed. Please contact the developer.\nSave error log?", "Oh no", MessageBoxButtons.YesNo);
                if (logErrorData == DialogResult.Yes)
                {
                    FileStream errLogStream = new FileStream(Application.StartupPath + "\\errlog.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter errLogWriter = new StreamWriter(errLogStream);
                    calcPrice();
                    errLogWriter.WriteLine(e.StackTrace);
                    errLogWriter.Close();
                }
            }
        }

        private void populateStateBox()
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            path += "\\Resources\\StateAbbrev.txt";
            try
            {
                FileStream stateListFile = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader stateReader = new StreamReader(stateListFile);
                while (stateReader.Peek() != -1)
                {
                    cboCustState.Items.Add(stateReader.ReadLine());
                }
                stateReader.Close();
                
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("State List file not found");
            }
            
        }

        private void tryEnableAccept()
        {
            if (!String.IsNullOrEmpty(txtCustCity.Text))
            {
                if (!String.IsNullOrEmpty(txtCustAddress1.Text))
                {
                    if (!String.IsNullOrEmpty(txtCustName.Text))
                    {
                        if (!String.IsNullOrEmpty(txtCustPhone.Text))
                        {
                            if (!String.IsNullOrEmpty(txtCustZipCode.Text))
                            {
                                erpValidationChecker.SetError(btnAccept, string.Empty);
                                btnAccept.Enabled = true;
                                acceptToolStripMenuItem.Enabled = true;
                                return;
                            }
                        }
                    }
                }
            }
            erpValidationChecker.SetError(btnAccept, "All required customer fields must be valid and not empty");
            btnAccept.Enabled = false;
        }

        private void tmrDateTimeSource_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            populateStateBox();
            ValidateChildren();
            currentOrderNum = 0;
            tryEnableAccept();
            resetForm();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            Customer curCust = new Customer(txtCustPhone.Text, txtCustName.Text, txtCustAddress1.Text, txtCustAddress2.Text, txtCustCity.Text, cboCustState.SelectedText, txtCustZipCode.Text);
            FileStream logStream = new FileStream(Application.StartupPath + "\\log.txt", FileMode.Append, FileAccess.Write);
            StreamWriter logWriter = new StreamWriter(logStream);
            calcPrice();
            logWriter.WriteLine(lblOrderNumValue.Text + "," + curCust.Phone + "," + curCust.Name + "," + lblTotalValue.Text);
            logWriter.Close();
            addCust(curCust);
            currentOrderNum++;
            resetForm();
            ValidateChildren();
        }
        private void calcPrice()
        {
            decimal currentSubtotal = getPizzaSubtotal();
            decimal currentSalesTax = currentSubtotal * SALES_TAX_RATE;
            decimal currentPrice = currentSubtotal + currentSalesTax;
            lblSubtotalValue.Text = String.Format("{0:C}", currentSubtotal);
            //Found online, but I understand how it works: {0:C} represents that the number should be treated as a currency value (2 decimal places and add the currency symbol)
            lblTaxValue.Text = String.Format("{0:C}", currentSalesTax);
            lblTotalValue.Text = String.Format("{0:C}", currentPrice);

        }

        private void txtCustName_Validating(object sender, CancelEventArgs e)
        {
            if ((txtCustName.TextLength < 5) || (txtCustName.TextLength > 25))
            {
                
                btnAccept.Enabled = false;
                erpValidationChecker.SetError(txtCustName, "Must be 5 - 25 characters");
            }
            else
            {
                
                tryEnableAccept();
                erpValidationChecker.SetError(txtCustName, string.Empty);
            }
        }
        private void validatePhone()
        {
            if ((txtCustPhone.Text.Length < 10) || (txtCustPhone.Text.Contains(" ")))
            {

                btnAccept.Enabled = false;
                erpValidationChecker.SetError(txtCustPhone, "Must be 10 digits");
            }
            else
            {

                tryEnableAccept();
                erpValidationChecker.SetError(txtCustPhone, string.Empty);
            }
        }

        private void txtCustPhone_Validating(object sender, CancelEventArgs e)
        {
            validatePhone();
        }

        private void txtCustZipCode_Validating(object sender, CancelEventArgs e)
        {
            if ((txtCustZipCode.Text.Length % 4 != 1) || (txtCustZipCode.Text.Contains(" ")))
            {
                
                btnAccept.Enabled = false;
                erpValidationChecker.SetError(txtCustZipCode, "Must be 5 or 9 digits");
            }
            else
            {
                
                tryEnableAccept();
                erpValidationChecker.SetError(txtCustZipCode, string.Empty);
            }
        }

        private void txtCustAddress1_Validating(object sender, CancelEventArgs e)
        {
            if ((txtCustAddress1.TextLength < 5) || (txtCustAddress1.TextLength > 25))
            {
                
                btnAccept.Enabled = false;
                erpValidationChecker.SetError(txtCustAddress1, "Must be 5 - 25 characters");
            }
            else
            {
                
                tryEnableAccept();
                erpValidationChecker.SetError(txtCustAddress1, string.Empty);
            }
        }

        private void txtCustCity_Validating(object sender, CancelEventArgs e)
        {
            if ((txtCustCity.TextLength < 2) || (txtCustCity.TextLength > 25))
            {
                
                btnAccept.Enabled = false;
                erpValidationChecker.SetError(txtCustCity, "Must be 2 - 25 characters");
            }
            else
            {
                
                tryEnableAccept();
                erpValidationChecker.SetError(txtCustCity, string.Empty);
            }
        }

        private bool getClosePrompt()
        {
            DialogResult exitDlgResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            return (exitDlgResult == DialogResult.Yes);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustPhone_TextChanged(object sender, EventArgs e)
        {
            validatePhone();
            if(erpValidationChecker.GetError(txtCustPhone) == String.Empty)
            {
                CustSearch();
            }
        }

        private void frmPizzaOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!getClosePrompt())
            {
                e.Cancel = true;
            }
        }
        private void forceCharOnly(object sender, KeyPressEventArgs e)
        {
            char c;
            c = e.KeyChar;
            if (c >= 65 && c <= 90) ;
            else if (c >= 97 && c <= 122) ;
            else if (c == 8 || c == 32) ;
            else
                e.Handled = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updatePriceTrigger(object sender, EventArgs e)
        {
            calcPrice();
        }

        private void clbToppings_KeyUp(object sender, KeyEventArgs e)
        {
            calcPrice();
        }
    }
}
