namespace JacobHarrisPizzaPhase1
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCustomerData = new System.Windows.Forms.GroupBox();
            this.txtCustPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustAddress1 = new System.Windows.Forms.Label();
            this.lblCustAddress2 = new System.Windows.Forms.Label();
            this.lblCustCity = new System.Windows.Forms.Label();
            this.lblCustState = new System.Windows.Forms.Label();
            this.lblCustZipCode = new System.Windows.Forms.Label();
            this.txtCustAddress1 = new System.Windows.Forms.TextBox();
            this.txtCustAddress2 = new System.Windows.Forms.TextBox();
            this.txtCustCity = new System.Windows.Forms.TextBox();
            this.cboCustCity = new System.Windows.Forms.ComboBox();
            this.txtCustZipCode = new System.Windows.Forms.MaskedTextBox();
            this.grpCustomerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerData
            // 
            this.grpCustomerData.Controls.Add(this.txtCustZipCode);
            this.grpCustomerData.Controls.Add(this.cboCustCity);
            this.grpCustomerData.Controls.Add(this.txtCustCity);
            this.grpCustomerData.Controls.Add(this.txtCustAddress2);
            this.grpCustomerData.Controls.Add(this.txtCustAddress1);
            this.grpCustomerData.Controls.Add(this.lblCustZipCode);
            this.grpCustomerData.Controls.Add(this.lblCustState);
            this.grpCustomerData.Controls.Add(this.lblCustCity);
            this.grpCustomerData.Controls.Add(this.lblCustAddress2);
            this.grpCustomerData.Controls.Add(this.lblCustAddress1);
            this.grpCustomerData.Controls.Add(this.lblCustName);
            this.grpCustomerData.Controls.Add(this.txtCustName);
            this.grpCustomerData.Controls.Add(this.lblCustPhone);
            this.grpCustomerData.Controls.Add(this.txtCustPhone);
            this.grpCustomerData.Location = new System.Drawing.Point(44, 27);
            this.grpCustomerData.Name = "grpCustomerData";
            this.grpCustomerData.Size = new System.Drawing.Size(299, 282);
            this.grpCustomerData.TabIndex = 0;
            this.grpCustomerData.TabStop = false;
            this.grpCustomerData.Text = "Customer Information";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(110, 58);
            this.txtCustPhone.Mask = "(999) 000-0000";
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(82, 20);
            this.txtCustPhone.TabIndex = 0;
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(12, 61);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(78, 13);
            this.lblCustPhone.TabIndex = 1;
            this.lblCustPhone.Text = "Phone Number";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(110, 21);
            this.txtCustName.MaxLength = 25;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(162, 20);
            this.txtCustName.TabIndex = 2;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(12, 24);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(35, 13);
            this.lblCustName.TabIndex = 3;
            this.lblCustName.Text = "Name";
            // 
            // lblCustAddress1
            // 
            this.lblCustAddress1.AutoSize = true;
            this.lblCustAddress1.Location = new System.Drawing.Point(12, 98);
            this.lblCustAddress1.Name = "lblCustAddress1";
            this.lblCustAddress1.Size = new System.Drawing.Size(77, 13);
            this.lblCustAddress1.TabIndex = 4;
            this.lblCustAddress1.Text = "Address Line 1";
            // 
            // lblCustAddress2
            // 
            this.lblCustAddress2.AutoSize = true;
            this.lblCustAddress2.Location = new System.Drawing.Point(12, 135);
            this.lblCustAddress2.Name = "lblCustAddress2";
            this.lblCustAddress2.Size = new System.Drawing.Size(77, 13);
            this.lblCustAddress2.TabIndex = 5;
            this.lblCustAddress2.Text = "Address Line 2";
            // 
            // lblCustCity
            // 
            this.lblCustCity.AutoSize = true;
            this.lblCustCity.Location = new System.Drawing.Point(12, 172);
            this.lblCustCity.Name = "lblCustCity";
            this.lblCustCity.Size = new System.Drawing.Size(24, 13);
            this.lblCustCity.TabIndex = 6;
            this.lblCustCity.Text = "City";
            // 
            // lblCustState
            // 
            this.lblCustState.AutoSize = true;
            this.lblCustState.Location = new System.Drawing.Point(12, 209);
            this.lblCustState.Name = "lblCustState";
            this.lblCustState.Size = new System.Drawing.Size(32, 13);
            this.lblCustState.TabIndex = 7;
            this.lblCustState.Text = "State";
            // 
            // lblCustZipCode
            // 
            this.lblCustZipCode.AutoSize = true;
            this.lblCustZipCode.Location = new System.Drawing.Point(12, 245);
            this.lblCustZipCode.Name = "lblCustZipCode";
            this.lblCustZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblCustZipCode.TabIndex = 8;
            this.lblCustZipCode.Text = "Zip Code";
            // 
            // txtCustAddress1
            // 
            this.txtCustAddress1.Location = new System.Drawing.Point(110, 95);
            this.txtCustAddress1.MaxLength = 25;
            this.txtCustAddress1.Name = "txtCustAddress1";
            this.txtCustAddress1.Size = new System.Drawing.Size(177, 20);
            this.txtCustAddress1.TabIndex = 9;
            // 
            // txtCustAddress2
            // 
            this.txtCustAddress2.Location = new System.Drawing.Point(110, 132);
            this.txtCustAddress2.MaxLength = 25;
            this.txtCustAddress2.Name = "txtCustAddress2";
            this.txtCustAddress2.Size = new System.Drawing.Size(177, 20);
            this.txtCustAddress2.TabIndex = 10;
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(110, 169);
            this.txtCustCity.MaxLength = 25;
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(177, 20);
            this.txtCustCity.TabIndex = 11;
            // 
            // cboCustCity
            // 
            this.cboCustCity.FormattingEnabled = true;
            this.cboCustCity.Location = new System.Drawing.Point(110, 206);
            this.cboCustCity.Name = "cboCustCity";
            this.cboCustCity.Size = new System.Drawing.Size(46, 21);
            this.cboCustCity.TabIndex = 12;
            // 
            // txtCustZipCode
            // 
            this.txtCustZipCode.Location = new System.Drawing.Point(110, 242);
            this.txtCustZipCode.Mask = "00000-9999";
            this.txtCustZipCode.Name = "txtCustZipCode";
            this.txtCustZipCode.Size = new System.Drawing.Size(65, 20);
            this.txtCustZipCode.TabIndex = 13;
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 591);
            this.Controls.Add(this.grpCustomerData);
            this.Name = "frmPizzaOrder";
            this.Text = "Tropical Pizza Order Manager";
            this.grpCustomerData.ResumeLayout(false);
            this.grpCustomerData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerData;
        private System.Windows.Forms.MaskedTextBox txtCustPhone;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Label lblCustAddress1;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustCity;
        private System.Windows.Forms.Label lblCustAddress2;
        private System.Windows.Forms.Label lblCustZipCode;
        private System.Windows.Forms.Label lblCustState;
        private System.Windows.Forms.TextBox txtCustAddress2;
        private System.Windows.Forms.TextBox txtCustAddress1;
        private System.Windows.Forms.ComboBox cboCustCity;
        private System.Windows.Forms.TextBox txtCustCity;
        private System.Windows.Forms.MaskedTextBox txtCustZipCode;
    }
}

