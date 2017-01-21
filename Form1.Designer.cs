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
            this.picTropicalLogo = new System.Windows.Forms.PictureBox();
            this.lblParlorName = new System.Windows.Forms.Label();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkToppingCheese = new System.Windows.Forms.CheckBox();
            this.chkToppingPepperoni = new System.Windows.Forms.CheckBox();
            this.chkToppingHam = new System.Windows.Forms.CheckBox();
            this.chkToppingSausage = new System.Windows.Forms.CheckBox();
            this.chkToppingAnchovy = new System.Windows.Forms.CheckBox();
            this.chkToppingPepper = new System.Windows.Forms.CheckBox();
            this.chkToppingChicken = new System.Windows.Forms.CheckBox();
            this.chkToppingMushroom = new System.Windows.Forms.CheckBox();
            this.chkToppingOlive = new System.Windows.Forms.CheckBox();
            this.chkToppingPineapple = new System.Windows.Forms.CheckBox();
            this.grpCustomerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTropicalLogo)).BeginInit();
            this.grpToppings.SuspendLayout();
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
            this.grpCustomerData.Location = new System.Drawing.Point(12, 79);
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
            // picTropicalLogo
            // 
            this.picTropicalLogo.Location = new System.Drawing.Point(892, 79);
            this.picTropicalLogo.Name = "picTropicalLogo";
            this.picTropicalLogo.Size = new System.Drawing.Size(268, 282);
            this.picTropicalLogo.TabIndex = 1;
            this.picTropicalLogo.TabStop = false;
            // 
            // lblParlorName
            // 
            this.lblParlorName.AutoSize = true;
            this.lblParlorName.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParlorName.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblParlorName.Location = new System.Drawing.Point(32, 16);
            this.lblParlorName.Name = "lblParlorName";
            this.lblParlorName.Size = new System.Drawing.Size(406, 60);
            this.lblParlorName.TabIndex = 2;
            this.lblParlorName.Text = "Tropical Pizza";
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Location = new System.Drawing.Point(885, 20);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(89, 13);
            this.lblCurrentDateTime.TabIndex = 3;
            this.lblCurrentDateTime.Text = "Placeholder Date";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkToppingPineapple);
            this.grpToppings.Controls.Add(this.chkToppingOlive);
            this.grpToppings.Controls.Add(this.chkToppingMushroom);
            this.grpToppings.Controls.Add(this.chkToppingChicken);
            this.grpToppings.Controls.Add(this.chkToppingPepper);
            this.grpToppings.Controls.Add(this.chkToppingAnchovy);
            this.grpToppings.Controls.Add(this.chkToppingSausage);
            this.grpToppings.Controls.Add(this.chkToppingHam);
            this.grpToppings.Controls.Add(this.chkToppingPepperoni);
            this.grpToppings.Controls.Add(this.chkToppingCheese);
            this.grpToppings.Location = new System.Drawing.Point(460, 106);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(129, 255);
            this.grpToppings.TabIndex = 4;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkToppingCheese
            // 
            this.chkToppingCheese.AutoSize = true;
            this.chkToppingCheese.Location = new System.Drawing.Point(21, 20);
            this.chkToppingCheese.Name = "chkToppingCheese";
            this.chkToppingCheese.Size = new System.Drawing.Size(62, 17);
            this.chkToppingCheese.TabIndex = 0;
            this.chkToppingCheese.Text = "Cheese";
            this.chkToppingCheese.UseVisualStyleBackColor = true;
            // 
            // chkToppingPepperoni
            // 
            this.chkToppingPepperoni.AutoSize = true;
            this.chkToppingPepperoni.Location = new System.Drawing.Point(21, 44);
            this.chkToppingPepperoni.Name = "chkToppingPepperoni";
            this.chkToppingPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkToppingPepperoni.TabIndex = 1;
            this.chkToppingPepperoni.Text = "Pepperoni";
            this.chkToppingPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkToppingHam
            // 
            this.chkToppingHam.AutoSize = true;
            this.chkToppingHam.Location = new System.Drawing.Point(21, 67);
            this.chkToppingHam.Name = "chkToppingHam";
            this.chkToppingHam.Size = new System.Drawing.Size(48, 17);
            this.chkToppingHam.TabIndex = 2;
            this.chkToppingHam.Text = "Ham";
            this.chkToppingHam.UseVisualStyleBackColor = true;
            // 
            // chkToppingSausage
            // 
            this.chkToppingSausage.AutoSize = true;
            this.chkToppingSausage.Location = new System.Drawing.Point(21, 91);
            this.chkToppingSausage.Name = "chkToppingSausage";
            this.chkToppingSausage.Size = new System.Drawing.Size(68, 17);
            this.chkToppingSausage.TabIndex = 3;
            this.chkToppingSausage.Text = "Sausage";
            this.chkToppingSausage.UseVisualStyleBackColor = true;
            // 
            // chkToppingAnchovy
            // 
            this.chkToppingAnchovy.AutoSize = true;
            this.chkToppingAnchovy.Location = new System.Drawing.Point(21, 115);
            this.chkToppingAnchovy.Name = "chkToppingAnchovy";
            this.chkToppingAnchovy.Size = new System.Drawing.Size(76, 17);
            this.chkToppingAnchovy.TabIndex = 4;
            this.chkToppingAnchovy.Text = "Anchovies";
            this.chkToppingAnchovy.UseVisualStyleBackColor = true;
            // 
            // chkToppingPepper
            // 
            this.chkToppingPepper.AutoSize = true;
            this.chkToppingPepper.Location = new System.Drawing.Point(21, 139);
            this.chkToppingPepper.Name = "chkToppingPepper";
            this.chkToppingPepper.Size = new System.Drawing.Size(97, 17);
            this.chkToppingPepper.TabIndex = 5;
            this.chkToppingPepper.Text = "Sliced Peppers";
            this.chkToppingPepper.UseVisualStyleBackColor = true;
            // 
            // chkToppingChicken
            // 
            this.chkToppingChicken.AutoSize = true;
            this.chkToppingChicken.Location = new System.Drawing.Point(21, 163);
            this.chkToppingChicken.Name = "chkToppingChicken";
            this.chkToppingChicken.Size = new System.Drawing.Size(65, 17);
            this.chkToppingChicken.TabIndex = 6;
            this.chkToppingChicken.Text = "Chicken";
            this.chkToppingChicken.UseVisualStyleBackColor = true;
            // 
            // chkToppingMushroom
            // 
            this.chkToppingMushroom.AutoSize = true;
            this.chkToppingMushroom.Location = new System.Drawing.Point(21, 187);
            this.chkToppingMushroom.Name = "chkToppingMushroom";
            this.chkToppingMushroom.Size = new System.Drawing.Size(80, 17);
            this.chkToppingMushroom.TabIndex = 7;
            this.chkToppingMushroom.Text = "Mushrooms";
            this.chkToppingMushroom.UseVisualStyleBackColor = true;
            // 
            // chkToppingOlive
            // 
            this.chkToppingOlive.AutoSize = true;
            this.chkToppingOlive.Location = new System.Drawing.Point(21, 211);
            this.chkToppingOlive.Name = "chkToppingOlive";
            this.chkToppingOlive.Size = new System.Drawing.Size(87, 17);
            this.chkToppingOlive.TabIndex = 8;
            this.chkToppingOlive.Text = "Green Olives";
            this.chkToppingOlive.UseVisualStyleBackColor = true;
            // 
            // chkToppingPineapple
            // 
            this.chkToppingPineapple.AutoSize = true;
            this.chkToppingPineapple.Location = new System.Drawing.Point(21, 235);
            this.chkToppingPineapple.Name = "chkToppingPineapple";
            this.chkToppingPineapple.Size = new System.Drawing.Size(73, 17);
            this.chkToppingPineapple.TabIndex = 9;
            this.chkToppingPineapple.Text = "Pineapple";
            this.chkToppingPineapple.UseVisualStyleBackColor = true;
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1172, 591);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.lblParlorName);
            this.Controls.Add(this.picTropicalLogo);
            this.Controls.Add(this.grpCustomerData);
            this.Name = "frmPizzaOrder";
            this.Text = "Tropical Pizza Order Manager";
            this.grpCustomerData.ResumeLayout(false);
            this.grpCustomerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTropicalLogo)).EndInit();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox picTropicalLogo;
        private System.Windows.Forms.Label lblParlorName;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkToppingPepperoni;
        private System.Windows.Forms.CheckBox chkToppingCheese;
        private System.Windows.Forms.CheckBox chkToppingAnchovy;
        private System.Windows.Forms.CheckBox chkToppingSausage;
        private System.Windows.Forms.CheckBox chkToppingHam;
        private System.Windows.Forms.CheckBox chkToppingOlive;
        private System.Windows.Forms.CheckBox chkToppingMushroom;
        private System.Windows.Forms.CheckBox chkToppingChicken;
        private System.Windows.Forms.CheckBox chkToppingPepper;
        private System.Windows.Forms.CheckBox chkToppingPineapple;
    }
}

