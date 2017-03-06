using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobHarrisPizzaPhase1
{
    public partial class frmPizzaOrder : Form
    {
        const decimal SALES_TAX_RATE = 0.07M;
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
            //It feels so clunky to do it this way, I'm gonna revise this as soon as I can.
            //Empty all text boxes first
            txtCustPhone.ResetText();
            txtCustName.ResetText();
            txtCustAddress1.ResetText();
            txtCustAddress2.ResetText();
            txtCustCity.ResetText();
            txtCustZipCode.ResetText();

            //Reset combo/numeric up/dn
            cboCustState.ResetText(); //TODO: Fix this
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

        private bool isValid()
        {
            int numInputsInvalid = 0;




            return (numInputsInvalid == 0);
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

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //TODO: Add a way of accepting the order.
            resetForm();
            
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            decimal currentSubtotal = getPizzaSubtotal();
            decimal currentSalesTax = currentSubtotal * SALES_TAX_RATE;
            decimal currentPrice = currentSubtotal + currentSalesTax;
            lblSubtotalValue.Text = String.Format("{0:C}", currentSubtotal); 
            //Found online, but I understand how it works: {0:C} represents that the number should be treated as a currency value (2 decimal places and add the currency symbol)
            lblTaxValue.Text = String.Format("{0:C}", currentSalesTax);
            lblTotalValue.Text = String.Format("{0:C}", currentPrice);
            
        }
    }
}
