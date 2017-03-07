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

namespace JacobHarrisPizzaPhase1
{
    public partial class frmPizzaOrder : Form
    {
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

            if (chkToppingAnchovy.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingCheese.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingChicken.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingHam.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingMushroom.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingOlive.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingPepper.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingPepperoni.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingPineapple.Checked)
            {
                subtotal += 1.00M;
            }
            if (chkToppingSausage.Checked)
            {
                subtotal += 1.00M;
            }
            subtotal *= nudPizzaCount.Value;
            return subtotal;
        }
        private void resetForm()
        {
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
            chkToppingAnchovy.Checked = false;
            chkToppingCheese.Checked = false;
            chkToppingChicken.Checked = false;
            chkToppingHam.Checked = false;
            chkToppingMushroom.Checked = false;
            chkToppingOlive.Checked = false;
            chkToppingPepper.Checked = false;
            chkToppingPepperoni.Checked = false;
            chkToppingPineapple.Checked = false;
            chkToppingSausage.Checked = false;

            //Reset Radio buttons (default is small)
            radSizeLarge.Checked = false;
            radSizeMedium.Checked = false;
            radSizeSmall.Checked = true;
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
        private void btnPrice_Click(object sender, EventArgs e)
        {
            calcPrice();
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

        private void txtCustPhone_Validating(object sender, CancelEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult exitDlgResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (exitDlgResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
