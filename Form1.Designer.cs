﻿namespace JacobHarrisPizzaPhase1
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
            this.components = new System.ComponentModel.Container();
            this.grpCustomerData = new System.Windows.Forms.GroupBox();
            this.txtCustZipCode = new System.Windows.Forms.MaskedTextBox();
            this.cboCustState = new System.Windows.Forms.ComboBox();
            this.txtCustCity = new System.Windows.Forms.TextBox();
            this.txtCustAddress2 = new System.Windows.Forms.TextBox();
            this.txtCustAddress1 = new System.Windows.Forms.TextBox();
            this.lblCustZipCode = new System.Windows.Forms.Label();
            this.lblCustState = new System.Windows.Forms.Label();
            this.lblCustCity = new System.Windows.Forms.Label();
            this.lblCustAddress2 = new System.Windows.Forms.Label();
            this.lblCustAddress1 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.MaskedTextBox();
            this.picTropicalLogo = new System.Windows.Forms.PictureBox();
            this.lblParlorName = new System.Windows.Forms.Label();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.grpPizzaSize = new System.Windows.Forms.GroupBox();
            this.radSizeLarge = new System.Windows.Forms.RadioButton();
            this.radSizeMedium = new System.Windows.Forms.RadioButton();
            this.radSizeSmall = new System.Windows.Forms.RadioButton();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.lblOrderNumValue = new System.Windows.Forms.Label();
            this.lblOrderNumText = new System.Windows.Forms.Label();
            this.lblMaxPizzas = new System.Windows.Forms.Label();
            this.lblPizzaCount = new System.Windows.Forms.Label();
            this.nudPizzaCount = new System.Windows.Forms.NumericUpDown();
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTaxText = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblSubtotalText = new System.Windows.Forms.Label();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.grpFormActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.tmrDateTimeSource = new System.Windows.Forms.Timer(this.components);
            this.erpValidationChecker = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuFormMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCustomerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTropicalLogo)).BeginInit();
            this.grpToppings.SuspendLayout();
            this.grpPizzaSize.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaCount)).BeginInit();
            this.grpPaymentInfo.SuspendLayout();
            this.grpFormActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpValidationChecker)).BeginInit();
            this.menuFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerData
            // 
            this.grpCustomerData.Controls.Add(this.txtCustZipCode);
            this.grpCustomerData.Controls.Add(this.cboCustState);
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
            this.grpCustomerData.Location = new System.Drawing.Point(12, 102);
            this.grpCustomerData.Name = "grpCustomerData";
            this.grpCustomerData.Size = new System.Drawing.Size(299, 282);
            this.grpCustomerData.TabIndex = 1;
            this.grpCustomerData.TabStop = false;
            this.grpCustomerData.Text = "Customer Information";
            // 
            // txtCustZipCode
            // 
            this.txtCustZipCode.BeepOnError = true;
            this.txtCustZipCode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.erpValidationChecker.SetIconPadding(this.txtCustZipCode, 10);
            this.txtCustZipCode.Location = new System.Drawing.Point(110, 242);
            this.txtCustZipCode.Mask = "00000-9999";
            this.txtCustZipCode.Name = "txtCustZipCode";
            this.txtCustZipCode.ResetOnPrompt = false;
            this.txtCustZipCode.ResetOnSpace = false;
            this.txtCustZipCode.Size = new System.Drawing.Size(65, 20);
            this.txtCustZipCode.SkipLiterals = false;
            this.txtCustZipCode.TabIndex = 13;
            this.txtCustZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCustZipCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustZipCode_Validating);
            // 
            // cboCustState
            // 
            this.cboCustState.FormattingEnabled = true;
            this.cboCustState.Location = new System.Drawing.Point(110, 206);
            this.cboCustState.Name = "cboCustState";
            this.cboCustState.Size = new System.Drawing.Size(46, 21);
            this.cboCustState.TabIndex = 11;
            // 
            // txtCustCity
            // 
            this.erpValidationChecker.SetIconPadding(this.txtCustCity, 10);
            this.txtCustCity.Location = new System.Drawing.Point(110, 169);
            this.txtCustCity.MaxLength = 25;
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(154, 20);
            this.txtCustCity.TabIndex = 9;
            this.txtCustCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.forceCharOnly);
            this.txtCustCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustCity_Validating);
            // 
            // txtCustAddress2
            // 
            this.erpValidationChecker.SetIconPadding(this.txtCustAddress2, 10);
            this.txtCustAddress2.Location = new System.Drawing.Point(110, 132);
            this.txtCustAddress2.MaxLength = 25;
            this.txtCustAddress2.Name = "txtCustAddress2";
            this.txtCustAddress2.Size = new System.Drawing.Size(154, 20);
            this.txtCustAddress2.TabIndex = 7;
            // 
            // txtCustAddress1
            // 
            this.erpValidationChecker.SetIconPadding(this.txtCustAddress1, 10);
            this.txtCustAddress1.Location = new System.Drawing.Point(110, 95);
            this.txtCustAddress1.MaxLength = 25;
            this.txtCustAddress1.Name = "txtCustAddress1";
            this.txtCustAddress1.Size = new System.Drawing.Size(154, 20);
            this.txtCustAddress1.TabIndex = 5;
            this.txtCustAddress1.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustAddress1_Validating);
            // 
            // lblCustZipCode
            // 
            this.lblCustZipCode.AutoSize = true;
            this.lblCustZipCode.Location = new System.Drawing.Point(12, 245);
            this.lblCustZipCode.Name = "lblCustZipCode";
            this.lblCustZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblCustZipCode.TabIndex = 12;
            this.lblCustZipCode.Text = "&Zip Code";
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
            // lblCustCity
            // 
            this.lblCustCity.AutoSize = true;
            this.lblCustCity.Location = new System.Drawing.Point(12, 172);
            this.lblCustCity.Name = "lblCustCity";
            this.lblCustCity.Size = new System.Drawing.Size(24, 13);
            this.lblCustCity.TabIndex = 8;
            this.lblCustCity.Text = "City";
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
            // lblCustAddress1
            // 
            this.lblCustAddress1.AutoSize = true;
            this.lblCustAddress1.Location = new System.Drawing.Point(12, 98);
            this.lblCustAddress1.Name = "lblCustAddress1";
            this.lblCustAddress1.Size = new System.Drawing.Size(77, 13);
            this.lblCustAddress1.TabIndex = 4;
            this.lblCustAddress1.Text = "Address Line 1";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(12, 24);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(35, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "&Name";
            // 
            // txtCustName
            // 
            this.erpValidationChecker.SetIconPadding(this.txtCustName, 10);
            this.txtCustName.Location = new System.Drawing.Point(110, 21);
            this.txtCustName.MaxLength = 25;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(154, 20);
            this.txtCustName.TabIndex = 1;
            this.txtCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.forceCharOnly);
            this.txtCustName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustName_Validating);
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
            // txtCustPhone
            // 
            this.txtCustPhone.BeepOnError = true;
            this.txtCustPhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.erpValidationChecker.SetIconPadding(this.txtCustPhone, 10);
            this.txtCustPhone.Location = new System.Drawing.Point(110, 58);
            this.txtCustPhone.Mask = "(000) 000-0000";
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.ResetOnPrompt = false;
            this.txtCustPhone.ResetOnSpace = false;
            this.txtCustPhone.Size = new System.Drawing.Size(82, 20);
            this.txtCustPhone.SkipLiterals = false;
            this.txtCustPhone.TabIndex = 3;
            this.txtCustPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCustPhone.TextChanged += new System.EventHandler(this.txtCustPhone_TextChanged);
            this.txtCustPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustPhone_Validating);
            // 
            // picTropicalLogo
            // 
            this.picTropicalLogo.Image = global::JacobHarrisPizzaPhase1.Properties.Resources.PalmTree;
            this.picTropicalLogo.Location = new System.Drawing.Point(631, 39);
            this.picTropicalLogo.Name = "picTropicalLogo";
            this.picTropicalLogo.Size = new System.Drawing.Size(268, 520);
            this.picTropicalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTropicalLogo.TabIndex = 1;
            this.picTropicalLogo.TabStop = false;
            // 
            // lblParlorName
            // 
            this.lblParlorName.AutoSize = true;
            this.lblParlorName.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParlorName.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblParlorName.Location = new System.Drawing.Point(32, 39);
            this.lblParlorName.Name = "lblParlorName";
            this.lblParlorName.Size = new System.Drawing.Size(406, 60);
            this.lblParlorName.TabIndex = 0;
            this.lblParlorName.Text = "Tropical Pizza";
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Location = new System.Drawing.Point(436, 61);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(115, 13);
            this.lblCurrentDateTime.TabIndex = 5;
            this.lblCurrentDateTime.Text = "Loading Date & Time...";
            this.lblCurrentDateTime.UseMnemonic = false;
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.clbToppings);
            this.grpToppings.Location = new System.Drawing.Point(20, 68);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(129, 255);
            this.grpToppings.TabIndex = 2;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "&Toppings";
            // 
            // clbToppings
            // 
            this.clbToppings.CheckOnClick = true;
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Items.AddRange(new object[] {
            "Cheese",
            "Pepperoni",
            "Ham",
            "Sausage",
            "Anchovies",
            "Sliced Peppers",
            "Chicken",
            "Mushrooms",
            "Green Olives",
            "Pineapple"});
            this.clbToppings.Location = new System.Drawing.Point(14, 19);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(97, 229);
            this.clbToppings.TabIndex = 10;
            this.clbToppings.Click += new System.EventHandler(this.updatePriceTrigger);
            this.clbToppings.SelectedIndexChanged += new System.EventHandler(this.updatePriceTrigger);
            this.clbToppings.KeyUp += new System.Windows.Forms.KeyEventHandler(this.clbToppings_KeyUp);
            // 
            // grpPizzaSize
            // 
            this.grpPizzaSize.Controls.Add(this.radSizeLarge);
            this.grpPizzaSize.Controls.Add(this.radSizeMedium);
            this.grpPizzaSize.Controls.Add(this.radSizeSmall);
            this.grpPizzaSize.Location = new System.Drawing.Point(20, 329);
            this.grpPizzaSize.Name = "grpPizzaSize";
            this.grpPizzaSize.Size = new System.Drawing.Size(129, 93);
            this.grpPizzaSize.TabIndex = 3;
            this.grpPizzaSize.TabStop = false;
            this.grpPizzaSize.Text = "Size";
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
            this.radSizeLarge.CheckedChanged += new System.EventHandler(this.updatePriceTrigger);
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
            this.radSizeMedium.CheckedChanged += new System.EventHandler(this.updatePriceTrigger);
            // 
            // radSizeSmall
            // 
            this.radSizeSmall.AutoSize = true;
            this.radSizeSmall.Checked = true;
            this.radSizeSmall.Location = new System.Drawing.Point(7, 20);
            this.radSizeSmall.Name = "radSizeSmall";
            this.radSizeSmall.Size = new System.Drawing.Size(86, 17);
            this.radSizeSmall.TabIndex = 0;
            this.radSizeSmall.TabStop = true;
            this.radSizeSmall.Text = "Small ($9.00)";
            this.radSizeSmall.UseVisualStyleBackColor = true;
            this.radSizeSmall.CheckedChanged += new System.EventHandler(this.updatePriceTrigger);
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.lblOrderNumValue);
            this.grpOrderInfo.Controls.Add(this.lblOrderNumText);
            this.grpOrderInfo.Controls.Add(this.lblMaxPizzas);
            this.grpOrderInfo.Controls.Add(this.lblPizzaCount);
            this.grpOrderInfo.Controls.Add(this.nudPizzaCount);
            this.grpOrderInfo.Controls.Add(this.grpPizzaSize);
            this.grpOrderInfo.Controls.Add(this.grpToppings);
            this.grpOrderInfo.Location = new System.Drawing.Point(317, 102);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(168, 457);
            this.grpOrderInfo.TabIndex = 3;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // lblOrderNumValue
            // 
            this.lblOrderNumValue.AutoSize = true;
            this.lblOrderNumValue.Location = new System.Drawing.Point(103, 34);
            this.lblOrderNumValue.Name = "lblOrderNumValue";
            this.lblOrderNumValue.Size = new System.Drawing.Size(31, 13);
            this.lblOrderNumValue.TabIndex = 1;
            this.lblOrderNumValue.Text = "0000";
            // 
            // lblOrderNumText
            // 
            this.lblOrderNumText.AutoSize = true;
            this.lblOrderNumText.Location = new System.Drawing.Point(6, 34);
            this.lblOrderNumText.Name = "lblOrderNumText";
            this.lblOrderNumText.Size = new System.Drawing.Size(76, 13);
            this.lblOrderNumText.TabIndex = 0;
            this.lblOrderNumText.Text = "Order Number:";
            // 
            // lblMaxPizzas
            // 
            this.lblMaxPizzas.AutoSize = true;
            this.lblMaxPizzas.Location = new System.Drawing.Point(106, 430);
            this.lblMaxPizzas.Name = "lblMaxPizzas";
            this.lblMaxPizzas.Size = new System.Drawing.Size(48, 13);
            this.lblMaxPizzas.TabIndex = 6;
            this.lblMaxPizzas.Text = "(Max 10)";
            // 
            // lblPizzaCount
            // 
            this.lblPizzaCount.AutoSize = true;
            this.lblPizzaCount.Location = new System.Drawing.Point(17, 430);
            this.lblPizzaCount.Name = "lblPizzaCount";
            this.lblPizzaCount.Size = new System.Drawing.Size(46, 13);
            this.lblPizzaCount.TabIndex = 4;
            this.lblPizzaCount.Text = "&Quantity";
            // 
            // nudPizzaCount
            // 
            this.nudPizzaCount.Location = new System.Drawing.Point(69, 428);
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
            this.nudPizzaCount.TabIndex = 5;
            this.nudPizzaCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPizzaCount.ValueChanged += new System.EventHandler(this.updatePriceTrigger);
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
            this.grpPaymentInfo.Location = new System.Drawing.Point(12, 390);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Size = new System.Drawing.Size(299, 169);
            this.grpPaymentInfo.TabIndex = 2;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Payment and Pricing";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(217, 113);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(34, 13);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.Text = "$0.00";
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTaxValue.AutoSize = true;
            this.lblTaxValue.Location = new System.Drawing.Point(217, 77);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(34, 13);
            this.lblTaxValue.TabIndex = 5;
            this.lblTaxValue.Text = "$0.00";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(217, 41);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(34, 13);
            this.lblSubtotalValue.TabIndex = 3;
            this.lblSubtotalValue.Text = "$0.00";
            // 
            // lblTotalText
            // 
            this.lblTotalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(143, 113);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(34, 13);
            this.lblTotalText.TabIndex = 6;
            this.lblTotalText.Text = "Total:";
            // 
            // lblTaxText
            // 
            this.lblTaxText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTaxText.AutoSize = true;
            this.lblTaxText.Location = new System.Drawing.Point(143, 77);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(28, 13);
            this.lblTaxText.TabIndex = 4;
            this.lblTaxText.Text = "Tax:";
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
            // lblSubtotalText
            // 
            this.lblSubtotalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSubtotalText.AutoSize = true;
            this.lblSubtotalText.Location = new System.Drawing.Point(143, 41);
            this.lblSubtotalText.Name = "lblSubtotalText";
            this.lblSubtotalText.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotalText.TabIndex = 2;
            this.lblSubtotalText.Text = "Subtotal:";
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
            // grpFormActions
            // 
            this.grpFormActions.Controls.Add(this.btnClose);
            this.grpFormActions.Controls.Add(this.btnAccept);
            this.grpFormActions.Controls.Add(this.btnReset);
            this.grpFormActions.Controls.Add(this.btnPrice);
            this.grpFormActions.Location = new System.Drawing.Point(503, 102);
            this.grpFormActions.Name = "grpFormActions";
            this.grpFormActions.Size = new System.Drawing.Size(122, 457);
            this.grpFormActions.TabIndex = 4;
            this.grpFormActions.TabStop = false;
            this.grpFormActions.Text = "Actions";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(11, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 71);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(11, 260);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(96, 71);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 142);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 71);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(11, 24);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(96, 71);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "&Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.updatePriceTrigger);
            // 
            // tmrDateTimeSource
            // 
            this.tmrDateTimeSource.Enabled = true;
            this.tmrDateTimeSource.Interval = 1000;
            this.tmrDateTimeSource.Tick += new System.EventHandler(this.tmrDateTimeSource_Tick);
            // 
            // erpValidationChecker
            // 
            this.erpValidationChecker.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpValidationChecker.ContainerControl = this;
            // 
            // menuFormMenu
            // 
            this.menuFormMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuFormMenu.Location = new System.Drawing.Point(0, 0);
            this.menuFormMenu.Name = "menuFormMenu";
            this.menuFormMenu.Size = new System.Drawing.Size(907, 24);
            this.menuFormMenu.TabIndex = 0;
            this.menuFormMenu.Text = "menuFormMenu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.acceptToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.priceToolStripMenuItem.Text = "Price";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.updatePriceTrigger);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // acceptToolStripMenuItem
            // 
            this.acceptToolStripMenuItem.Name = "acceptToolStripMenuItem";
            this.acceptToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.acceptToolStripMenuItem.Text = "Accept";
            this.acceptToolStripMenuItem.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitToolStripMenuItem.Text = "Close";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(907, 579);
            this.Controls.Add(this.menuFormMenu);
            this.Controls.Add(this.grpFormActions);
            this.Controls.Add(this.grpPaymentInfo);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.lblParlorName);
            this.Controls.Add(this.picTropicalLogo);
            this.Controls.Add(this.grpCustomerData);
            this.MainMenuStrip = this.menuFormMenu;
            this.Name = "frmPizzaOrder";
            this.Text = "Tropical Pizza Order Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPizzaOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.grpCustomerData.ResumeLayout(false);
            this.grpCustomerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTropicalLogo)).EndInit();
            this.grpToppings.ResumeLayout(false);
            this.grpPizzaSize.ResumeLayout(false);
            this.grpPizzaSize.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaCount)).EndInit();
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
            this.grpFormActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpValidationChecker)).EndInit();
            this.menuFormMenu.ResumeLayout(false);
            this.menuFormMenu.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboCustState;
        private System.Windows.Forms.TextBox txtCustCity;
        private System.Windows.Forms.MaskedTextBox txtCustZipCode;
        private System.Windows.Forms.PictureBox picTropicalLogo;
        private System.Windows.Forms.Label lblParlorName;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.GroupBox grpToppings;
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
        private System.Windows.Forms.GroupBox grpFormActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label lblOrderNumValue;
        private System.Windows.Forms.Label lblOrderNumText;
        private System.Windows.Forms.Timer tmrDateTimeSource;
        private System.Windows.Forms.ErrorProvider erpValidationChecker;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.MenuStrip menuFormMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceptToolStripMenuItem;
    }
}

