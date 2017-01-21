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
            this.grpPizzaSize = new System.Windows.Forms.GroupBox();
            this.radSizeSmall = new System.Windows.Forms.RadioButton();
            this.radSizeMedium = new System.Windows.Forms.RadioButton();
            this.radSizeLarge = new System.Windows.Forms.RadioButton();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.nudPizzaCount = new System.Windows.Forms.NumericUpDown();
            this.lblPizzaCount = new System.Windows.Forms.Label();
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblMaxPizzas = new System.Windows.Forms.Label();
            this.lblSubtotalText = new System.Windows.Forms.Label();
            this.lblTaxText = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.grpCustomerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTropicalLogo)).BeginInit();
            this.grpToppings.SuspendLayout();
            this.grpPizzaSize.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaCount)).BeginInit();
            this.grpPaymentInfo.SuspendLayout();
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
            this.grpCustomerData.TabIndex = 1;
            this.grpCustomerData.TabStop = false;
            this.grpCustomerData.Text = "Customer Information";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(110, 58);
            this.txtCustPhone.Mask = "(999) 000-0000";
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(82, 20);
            this.txtCustPhone.TabIndex = 3;
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(12, 61);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(78, 13);
            this.lblCustPhone.TabIndex = 2;
            this.lblCustPhone.Text = "Phone Number";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(110, 21);
            this.txtCustName.MaxLength = 25;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(162, 20);
            this.txtCustName.TabIndex = 1;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(12, 24);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(35, 13);
            this.lblCustName.TabIndex = 0;
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
            this.lblCustAddress2.TabIndex = 6;
            this.lblCustAddress2.Text = "Address Line 2";
            // 
            // lblCustCity
            // 
            this.lblCustCity.AutoSize = true;
            this.lblCustCity.Location = new System.Drawing.Point(12, 172);
            this.lblCustCity.Name = "lblCustCity";
            this.lblCustCity.Size = new System.Drawing.Size(24, 13);
            this.lblCustCity.TabIndex = 8;
            this.lblCustCity.Text = "City";
            // 
            // lblCustState
            // 
            this.lblCustState.AutoSize = true;
            this.lblCustState.Location = new System.Drawing.Point(12, 209);
            this.lblCustState.Name = "lblCustState";
            this.lblCustState.Size = new System.Drawing.Size(32, 13);
            this.lblCustState.TabIndex = 10;
            this.lblCustState.Text = "State";
            // 
            // lblCustZipCode
            // 
            this.lblCustZipCode.AutoSize = true;
            this.lblCustZipCode.Location = new System.Drawing.Point(12, 245);
            this.lblCustZipCode.Name = "lblCustZipCode";
            this.lblCustZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblCustZipCode.TabIndex = 12;
            this.lblCustZipCode.Text = "Zip Code";
            // 
            // txtCustAddress1
            // 
            this.txtCustAddress1.Location = new System.Drawing.Point(110, 95);
            this.txtCustAddress1.MaxLength = 25;
            this.txtCustAddress1.Name = "txtCustAddress1";
            this.txtCustAddress1.Size = new System.Drawing.Size(177, 20);
            this.txtCustAddress1.TabIndex = 5;
            // 
            // txtCustAddress2
            // 
            this.txtCustAddress2.Location = new System.Drawing.Point(110, 132);
            this.txtCustAddress2.MaxLength = 25;
            this.txtCustAddress2.Name = "txtCustAddress2";
            this.txtCustAddress2.Size = new System.Drawing.Size(177, 20);
            this.txtCustAddress2.TabIndex = 7;
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(110, 169);
            this.txtCustCity.MaxLength = 25;
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(177, 20);
            this.txtCustCity.TabIndex = 9;
            // 
            // cboCustCity
            // 
            this.cboCustCity.FormattingEnabled = true;
            this.cboCustCity.Location = new System.Drawing.Point(110, 206);
            this.cboCustCity.Name = "cboCustCity";
            this.cboCustCity.Size = new System.Drawing.Size(46, 21);
            this.cboCustCity.TabIndex = 11;
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
            this.lblParlorName.TabIndex = 0;
            this.lblParlorName.Text = "Tropical Pizza";
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Location = new System.Drawing.Point(885, 20);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(89, 13);
            this.lblCurrentDateTime.TabIndex = 4;
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
            this.grpToppings.Location = new System.Drawing.Point(22, 16);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(129, 255);
            this.grpToppings.TabIndex = 0;
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
            // grpPizzaSize
            // 
            this.grpPizzaSize.Controls.Add(this.radSizeLarge);
            this.grpPizzaSize.Controls.Add(this.radSizeMedium);
            this.grpPizzaSize.Controls.Add(this.radSizeSmall);
            this.grpPizzaSize.Location = new System.Drawing.Point(22, 277);
            this.grpPizzaSize.Name = "grpPizzaSize";
            this.grpPizzaSize.Size = new System.Drawing.Size(129, 93);
            this.grpPizzaSize.TabIndex = 1;
            this.grpPizzaSize.TabStop = false;
            this.grpPizzaSize.Text = "Size";
            // 
            // radSizeSmall
            // 
            this.radSizeSmall.AutoSize = true;
            this.radSizeSmall.Location = new System.Drawing.Point(7, 20);
            this.radSizeSmall.Name = "radSizeSmall";
            this.radSizeSmall.Size = new System.Drawing.Size(86, 17);
            this.radSizeSmall.TabIndex = 0;
            this.radSizeSmall.TabStop = true;
            this.radSizeSmall.Text = "Small ($9.00)";
            this.radSizeSmall.UseVisualStyleBackColor = true;
            // 
            // radSizeMedium
            // 
            this.radSizeMedium.AutoSize = true;
            this.radSizeMedium.Location = new System.Drawing.Point(7, 44);
            this.radSizeMedium.Name = "radSizeMedium";
            this.radSizeMedium.Size = new System.Drawing.Size(104, 17);
            this.radSizeMedium.TabIndex = 1;
            this.radSizeMedium.TabStop = true;
            this.radSizeMedium.Text = "Medium ($12.00)";
            this.radSizeMedium.UseVisualStyleBackColor = true;
            // 
            // radSizeLarge
            // 
            this.radSizeLarge.AutoSize = true;
            this.radSizeLarge.Location = new System.Drawing.Point(7, 68);
            this.radSizeLarge.Name = "radSizeLarge";
            this.radSizeLarge.Size = new System.Drawing.Size(94, 17);
            this.radSizeLarge.TabIndex = 2;
            this.radSizeLarge.TabStop = true;
            this.radSizeLarge.Text = "Large ($15.00)";
            this.radSizeLarge.UseVisualStyleBackColor = true;
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.lblMaxPizzas);
            this.grpOrderInfo.Controls.Add(this.lblPizzaCount);
            this.grpOrderInfo.Controls.Add(this.nudPizzaCount);
            this.grpOrderInfo.Controls.Add(this.grpPizzaSize);
            this.grpOrderInfo.Controls.Add(this.grpToppings);
            this.grpOrderInfo.Location = new System.Drawing.Point(317, 79);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(168, 408);
            this.grpOrderInfo.TabIndex = 3;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // nudPizzaCount
            // 
            this.nudPizzaCount.Location = new System.Drawing.Point(71, 376);
            this.nudPizzaCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPizzaCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPizzaCount.Name = "nudPizzaCount";
            this.nudPizzaCount.Size = new System.Drawing.Size(31, 20);
            this.nudPizzaCount.TabIndex = 3;
            this.nudPizzaCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPizzaCount
            // 
            this.lblPizzaCount.AutoSize = true;
            this.lblPizzaCount.Location = new System.Drawing.Point(19, 378);
            this.lblPizzaCount.Name = "lblPizzaCount";
            this.lblPizzaCount.Size = new System.Drawing.Size(46, 13);
            this.lblPizzaCount.TabIndex = 2;
            this.lblPizzaCount.Text = "Quantity";
            // 
            // grpPaymentInfo
            // 
            this.grpPaymentInfo.Controls.Add(this.lblTotalValue);
            this.grpPaymentInfo.Controls.Add(this.lblTaxValue);
            this.grpPaymentInfo.Controls.Add(this.lblSubtotalValue);
            this.grpPaymentInfo.Controls.Add(this.lblTotalText);
            this.grpPaymentInfo.Controls.Add(this.lblTaxText);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentMethod);
            this.grpPaymentInfo.Controls.Add(this.lblSubtotalText);
            this.grpPaymentInfo.Controls.Add(this.cboPaymentMethod);
            this.grpPaymentInfo.Location = new System.Drawing.Point(12, 367);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Size = new System.Drawing.Size(298, 119);
            this.grpPaymentInfo.TabIndex = 2;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Payment and Pricing";
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Visa",
            "Discover",
            "American Express",
            "Other Credit/Debit"});
            this.cboPaymentMethod.Location = new System.Drawing.Point(6, 61);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.cboPaymentMethod.TabIndex = 1;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(12, 33);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblMaxPizzas
            // 
            this.lblMaxPizzas.AutoSize = true;
            this.lblMaxPizzas.Location = new System.Drawing.Point(108, 378);
            this.lblMaxPizzas.Name = "lblMaxPizzas";
            this.lblMaxPizzas.Size = new System.Drawing.Size(48, 13);
            this.lblMaxPizzas.TabIndex = 4;
            this.lblMaxPizzas.Text = "(Max 10)";
            // 
            // lblSubtotalText
            // 
            this.lblSubtotalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSubtotalText.AutoSize = true;
            this.lblSubtotalText.Location = new System.Drawing.Point(143, 16);
            this.lblSubtotalText.Name = "lblSubtotalText";
            this.lblSubtotalText.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotalText.TabIndex = 2;
            this.lblSubtotalText.Text = "Subtotal:";
            // 
            // lblTaxText
            // 
            this.lblTaxText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTaxText.AutoSize = true;
            this.lblTaxText.Location = new System.Drawing.Point(143, 52);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(28, 13);
            this.lblTaxText.TabIndex = 4;
            this.lblTaxText.Text = "Tax:";
            // 
            // lblTotalText
            // 
            this.lblTotalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(143, 88);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(34, 13);
            this.lblTotalText.TabIndex = 6;
            this.lblTotalText.Text = "Total:";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(217, 16);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(34, 13);
            this.lblSubtotalValue.TabIndex = 3;
            this.lblSubtotalValue.Text = "$0.00";
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.AutoSize = true;
            this.lblTaxValue.Location = new System.Drawing.Point(217, 52);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(34, 13);
            this.lblTaxValue.TabIndex = 5;
            this.lblTaxValue.Text = "$0.00";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(217, 88);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(34, 13);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.Text = "$0.00";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1172, 591);
            this.Controls.Add(this.grpPaymentInfo);
            this.Controls.Add(this.grpOrderInfo);
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
            this.grpPizzaSize.ResumeLayout(false);
            this.grpPizzaSize.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaCount)).EndInit();
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpPizzaSize;
        private System.Windows.Forms.RadioButton radSizeLarge;
        private System.Windows.Forms.RadioButton radSizeMedium;
        private System.Windows.Forms.RadioButton radSizeSmall;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.Label lblPizzaCount;
        private System.Windows.Forms.NumericUpDown nudPizzaCount;
        private System.Windows.Forms.GroupBox grpPaymentInfo;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblMaxPizzas;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTaxText;
        private System.Windows.Forms.Label lblSubtotalText;
    }
}

