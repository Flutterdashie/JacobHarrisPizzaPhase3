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
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void tmrDateTimeSource_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btnReset_Click(object sender, EventArgs e)
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
            cboPaymentMethod.ResetText(); //TODO: Fix this
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
    }
}
