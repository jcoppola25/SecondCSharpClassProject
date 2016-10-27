namespace Coppola_2
{
    partial class tciOrderForm
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
            this.tciPictureBox = new System.Windows.Forms.PictureBox();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.summerRadioButton = new System.Windows.Forms.RadioButton();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.studentIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.begginingExcelCheckBox = new System.Windows.Forms.CheckBox();
            this.beginingPowerPointCheckBox = new System.Windows.Forms.CheckBox();
            this.beginingWordCheckBox = new System.Windows.Forms.CheckBox();
            this.advancedExcelCheckBox = new System.Windows.Forms.CheckBox();
            this.advancedPowerPointCheckBox = new System.Windows.Forms.CheckBox();
            this.advancedWordCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.creditCardTypeBox = new System.Windows.Forms.ComboBox();
            this.creditCardTypeLabel = new System.Windows.Forms.Label();
            this.creditCardNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.creditCardNumberLabel = new System.Windows.Forms.Label();
            this.experationDateLabel = new System.Windows.Forms.Label();
            this.creditCardExpirationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.totalNumberOfCoursesLabel = new System.Windows.Forms.Label();
            this.totalNumberOutputLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.studentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.orderInfromationGroupBox = new System.Windows.Forms.GroupBox();
            this.begginingWordPriceLabel = new System.Windows.Forms.Label();
            this.priceLabelOne = new System.Windows.Forms.Label();
            this.begginingExcelPriceLabel = new System.Windows.Forms.Label();
            this.begginingPowerPointPriceLabel = new System.Windows.Forms.Label();
            this.priceLabelTwo = new System.Windows.Forms.Label();
            this.advancedPowerPointPriceLabel = new System.Windows.Forms.Label();
            this.advancedExcelPriceLabel = new System.Windows.Forms.Label();
            this.advancedWordPriceLabel = new System.Windows.Forms.Label();
            this.creditCardGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tciPictureBox)).BeginInit();
            this.studentInformationGroupBox.SuspendLayout();
            this.orderInfromationGroupBox.SuspendLayout();
            this.creditCardGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tciPictureBox
            // 
            this.tciPictureBox.Image = global::Coppola_2.Properties.Resources.download;
            this.tciPictureBox.Location = new System.Drawing.Point(0, 2);
            this.tciPictureBox.Name = "tciPictureBox";
            this.tciPictureBox.Size = new System.Drawing.Size(145, 78);
            this.tciPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tciPictureBox.TabIndex = 0;
            this.tciPictureBox.TabStop = false;
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.AutoSize = true;
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Location = new System.Drawing.Point(6, 20);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(41, 17);
            this.fallRadioButton.TabIndex = 0;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            // 
            // summerRadioButton
            // 
            this.summerRadioButton.AutoSize = true;
            this.summerRadioButton.Location = new System.Drawing.Point(6, 43);
            this.summerRadioButton.Name = "summerRadioButton";
            this.summerRadioButton.Size = new System.Drawing.Size(63, 17);
            this.summerRadioButton.TabIndex = 1;
            this.summerRadioButton.Text = "Summer";
            this.summerRadioButton.UseVisualStyleBackColor = true;
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoSize = true;
            this.springRadioButton.Location = new System.Drawing.Point(6, 66);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(55, 17);
            this.springRadioButton.TabIndex = 2;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.yearComboBox.Location = new System.Drawing.Point(149, 19);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(86, 41);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(271, 15);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(136, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(271, 41);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(22, 18);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIdLabel.TabIndex = 0;
            this.studentIdLabel.Text = "Student ID";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(23, 44);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(233, 18);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(207, 44);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // studentIdMaskedTextBox
            // 
            this.studentIdMaskedTextBox.Location = new System.Drawing.Point(86, 15);
            this.studentIdMaskedTextBox.Mask = "000-00-0000";
            this.studentIdMaskedTextBox.Name = "studentIdMaskedTextBox";
            this.studentIdMaskedTextBox.Size = new System.Drawing.Size(70, 20);
            this.studentIdMaskedTextBox.TabIndex = 1;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(114, 22);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            // 
            // begginingExcelCheckBox
            // 
            this.begginingExcelCheckBox.AutoSize = true;
            this.begginingExcelCheckBox.Location = new System.Drawing.Point(10, 108);
            this.begginingExcelCheckBox.Name = "begginingExcelCheckBox";
            this.begginingExcelCheckBox.Size = new System.Drawing.Size(102, 17);
            this.begginingExcelCheckBox.TabIndex = 6;
            this.begginingExcelCheckBox.Text = "Beggining Excel";
            this.begginingExcelCheckBox.UseVisualStyleBackColor = true;
            this.begginingExcelCheckBox.CheckedChanged += new System.EventHandler(this.begginingExcelCheckBox_CheckedChanged);
            // 
            // beginingPowerPointCheckBox
            // 
            this.beginingPowerPointCheckBox.AutoSize = true;
            this.beginingPowerPointCheckBox.Location = new System.Drawing.Point(10, 154);
            this.beginingPowerPointCheckBox.Name = "beginingPowerPointCheckBox";
            this.beginingPowerPointCheckBox.Size = new System.Drawing.Size(136, 17);
            this.beginingPowerPointCheckBox.TabIndex = 10;
            this.beginingPowerPointCheckBox.Text = "Beggining Power Point ";
            this.beginingPowerPointCheckBox.UseVisualStyleBackColor = true;
            this.beginingPowerPointCheckBox.CheckedChanged += new System.EventHandler(this.begginingExcelCheckBox_CheckedChanged);
            // 
            // beginingWordCheckBox
            // 
            this.beginingWordCheckBox.AutoSize = true;
            this.beginingWordCheckBox.Location = new System.Drawing.Point(10, 131);
            this.beginingWordCheckBox.Name = "beginingWordCheckBox";
            this.beginingWordCheckBox.Size = new System.Drawing.Size(96, 17);
            this.beginingWordCheckBox.TabIndex = 8;
            this.beginingWordCheckBox.Text = "Begining Word";
            this.beginingWordCheckBox.UseVisualStyleBackColor = true;
            this.beginingWordCheckBox.CheckedChanged += new System.EventHandler(this.begginingExcelCheckBox_CheckedChanged);
            // 
            // advancedExcelCheckBox
            // 
            this.advancedExcelCheckBox.AutoSize = true;
            this.advancedExcelCheckBox.Location = new System.Drawing.Point(244, 130);
            this.advancedExcelCheckBox.Name = "advancedExcelCheckBox";
            this.advancedExcelCheckBox.Size = new System.Drawing.Size(104, 17);
            this.advancedExcelCheckBox.TabIndex = 15;
            this.advancedExcelCheckBox.Text = "Advanced Excel";
            this.advancedExcelCheckBox.UseVisualStyleBackColor = true;
            this.advancedExcelCheckBox.CheckedChanged += new System.EventHandler(this.begginingExcelCheckBox_CheckedChanged);
            // 
            // advancedPowerPointCheckBox
            // 
            this.advancedPowerPointCheckBox.AutoSize = true;
            this.advancedPowerPointCheckBox.Location = new System.Drawing.Point(244, 108);
            this.advancedPowerPointCheckBox.Name = "advancedPowerPointCheckBox";
            this.advancedPowerPointCheckBox.Size = new System.Drawing.Size(135, 17);
            this.advancedPowerPointCheckBox.TabIndex = 13;
            this.advancedPowerPointCheckBox.Text = "Advanced Power Point";
            this.advancedPowerPointCheckBox.UseVisualStyleBackColor = true;
            this.advancedPowerPointCheckBox.CheckedChanged += new System.EventHandler(this.begginingExcelCheckBox_CheckedChanged);
            // 
            // advancedWordCheckBox
            // 
            this.advancedWordCheckBox.AutoSize = true;
            this.advancedWordCheckBox.Location = new System.Drawing.Point(244, 154);
            this.advancedWordCheckBox.Name = "advancedWordCheckBox";
            this.advancedWordCheckBox.Size = new System.Drawing.Size(104, 17);
            this.advancedWordCheckBox.TabIndex = 17;
            this.advancedWordCheckBox.Text = "Advanced Word";
            this.advancedWordCheckBox.UseVisualStyleBackColor = true;
            this.advancedWordCheckBox.CheckedChanged += new System.EventHandler(this.begginingExcelCheckBox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(244, 371);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(327, 371);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(410, 371);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // creditCardTypeBox
            // 
            this.creditCardTypeBox.FormattingEnabled = true;
            this.creditCardTypeBox.Items.AddRange(new object[] {
            "MasterCard",
            "Visa"});
            this.creditCardTypeBox.Location = new System.Drawing.Point(133, 53);
            this.creditCardTypeBox.Name = "creditCardTypeBox";
            this.creditCardTypeBox.Size = new System.Drawing.Size(121, 21);
            this.creditCardTypeBox.TabIndex = 1;
            // 
            // creditCardTypeLabel
            // 
            this.creditCardTypeLabel.AutoSize = true;
            this.creditCardTypeLabel.Location = new System.Drawing.Point(14, 56);
            this.creditCardTypeLabel.Name = "creditCardTypeLabel";
            this.creditCardTypeLabel.Size = new System.Drawing.Size(98, 13);
            this.creditCardTypeLabel.TabIndex = 0;
            this.creditCardTypeLabel.Text = "Type of Credit Card";
            // 
            // creditCardNumberTextBox
            // 
            this.creditCardNumberTextBox.Location = new System.Drawing.Point(133, 80);
            this.creditCardNumberTextBox.Name = "creditCardNumberTextBox";
            this.creditCardNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.creditCardNumberTextBox.TabIndex = 3;
            // 
            // creditCardNumberLabel
            // 
            this.creditCardNumberLabel.AutoSize = true;
            this.creditCardNumberLabel.Location = new System.Drawing.Point(14, 83);
            this.creditCardNumberLabel.Name = "creditCardNumberLabel";
            this.creditCardNumberLabel.Size = new System.Drawing.Size(99, 13);
            this.creditCardNumberLabel.TabIndex = 2;
            this.creditCardNumberLabel.Text = "Credit Card Number";
            // 
            // experationDateLabel
            // 
            this.experationDateLabel.AutoSize = true;
            this.experationDateLabel.Location = new System.Drawing.Point(30, 109);
            this.experationDateLabel.Name = "experationDateLabel";
            this.experationDateLabel.Size = new System.Drawing.Size(83, 13);
            this.experationDateLabel.TabIndex = 4;
            this.experationDateLabel.Text = "Experation Date";
            // 
            // creditCardExpirationMaskedTextBox
            // 
            this.creditCardExpirationMaskedTextBox.Location = new System.Drawing.Point(133, 106);
            this.creditCardExpirationMaskedTextBox.Mask = "00/00/0000";
            this.creditCardExpirationMaskedTextBox.Name = "creditCardExpirationMaskedTextBox";
            this.creditCardExpirationMaskedTextBox.Size = new System.Drawing.Size(69, 20);
            this.creditCardExpirationMaskedTextBox.TabIndex = 5;
            this.creditCardExpirationMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // totalNumberOfCoursesLabel
            // 
            this.totalNumberOfCoursesLabel.AutoSize = true;
            this.totalNumberOfCoursesLabel.Location = new System.Drawing.Point(19, 198);
            this.totalNumberOfCoursesLabel.Name = "totalNumberOfCoursesLabel";
            this.totalNumberOfCoursesLabel.Size = new System.Drawing.Size(124, 13);
            this.totalNumberOfCoursesLabel.TabIndex = 19;
            this.totalNumberOfCoursesLabel.Text = "Total Number of Courses";
            // 
            // totalNumberOutputLabel
            // 
            this.totalNumberOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalNumberOutputLabel.Location = new System.Drawing.Point(144, 197);
            this.totalNumberOutputLabel.Name = "totalNumberOutputLabel";
            this.totalNumberOutputLabel.Size = new System.Drawing.Size(63, 19);
            this.totalNumberOutputLabel.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Cost of Courses";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(357, 197);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(53, 18);
            this.totalCostOutputLabel.TabIndex = 22;
            // 
            // studentInformationGroupBox
            // 
            this.studentInformationGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.studentIdMaskedTextBox);
            this.studentInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.emailLabel);
            this.studentInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.studentIdLabel);
            this.studentInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.emailTextBox);
            this.studentInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInformationGroupBox.Location = new System.Drawing.Point(299, 12);
            this.studentInformationGroupBox.Name = "studentInformationGroupBox";
            this.studentInformationGroupBox.Size = new System.Drawing.Size(413, 98);
            this.studentInformationGroupBox.TabIndex = 0;
            this.studentInformationGroupBox.TabStop = false;
            this.studentInformationGroupBox.Text = "Student Information";
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.AutoSize = true;
            this.outOfStateRadioButton.Location = new System.Drawing.Point(236, 75);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(127, 17);
            this.outOfStateRadioButton.TabIndex = 9;
            this.outOfStateRadioButton.TabStop = true;
            this.outOfStateRadioButton.Text = "Out of State Resident";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.AutoSize = true;
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(123, 75);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(107, 17);
            this.inStateRadioButton.TabIndex = 8;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State Resident";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.inStateRadioButton_CheckedChanged);
            // 
            // orderInfromationGroupBox
            // 
            this.orderInfromationGroupBox.Controls.Add(this.begginingWordPriceLabel);
            this.orderInfromationGroupBox.Controls.Add(this.priceLabelOne);
            this.orderInfromationGroupBox.Controls.Add(this.begginingExcelPriceLabel);
            this.orderInfromationGroupBox.Controls.Add(this.begginingPowerPointPriceLabel);
            this.orderInfromationGroupBox.Controls.Add(this.priceLabelTwo);
            this.orderInfromationGroupBox.Controls.Add(this.advancedPowerPointPriceLabel);
            this.orderInfromationGroupBox.Controls.Add(this.advancedExcelPriceLabel);
            this.orderInfromationGroupBox.Controls.Add(this.advancedWordPriceLabel);
            this.orderInfromationGroupBox.Controls.Add(this.totalCostOutputLabel);
            this.orderInfromationGroupBox.Controls.Add(this.label3);
            this.orderInfromationGroupBox.Controls.Add(this.totalNumberOutputLabel);
            this.orderInfromationGroupBox.Controls.Add(this.totalNumberOfCoursesLabel);
            this.orderInfromationGroupBox.Controls.Add(this.advancedWordCheckBox);
            this.orderInfromationGroupBox.Controls.Add(this.advancedPowerPointCheckBox);
            this.orderInfromationGroupBox.Controls.Add(this.advancedExcelCheckBox);
            this.orderInfromationGroupBox.Controls.Add(this.beginingWordCheckBox);
            this.orderInfromationGroupBox.Controls.Add(this.beginingPowerPointCheckBox);
            this.orderInfromationGroupBox.Controls.Add(this.begginingExcelCheckBox);
            this.orderInfromationGroupBox.Controls.Add(this.yearLabel);
            this.orderInfromationGroupBox.Controls.Add(this.yearComboBox);
            this.orderInfromationGroupBox.Controls.Add(this.springRadioButton);
            this.orderInfromationGroupBox.Controls.Add(this.summerRadioButton);
            this.orderInfromationGroupBox.Controls.Add(this.fallRadioButton);
            this.orderInfromationGroupBox.Location = new System.Drawing.Point(0, 116);
            this.orderInfromationGroupBox.Name = "orderInfromationGroupBox";
            this.orderInfromationGroupBox.Size = new System.Drawing.Size(436, 232);
            this.orderInfromationGroupBox.TabIndex = 1;
            this.orderInfromationGroupBox.TabStop = false;
            this.orderInfromationGroupBox.Text = "Order Information";
            // 
            // begginingWordPriceLabel
            // 
            this.begginingWordPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.begginingWordPriceLabel.Location = new System.Drawing.Point(172, 131);
            this.begginingWordPriceLabel.Name = "begginingWordPriceLabel";
            this.begginingWordPriceLabel.Size = new System.Drawing.Size(45, 23);
            this.begginingWordPriceLabel.TabIndex = 9;
            // 
            // priceLabelOne
            // 
            this.priceLabelOne.AutoSize = true;
            this.priceLabelOne.Location = new System.Drawing.Point(169, 89);
            this.priceLabelOne.Name = "priceLabelOne";
            this.priceLabelOne.Size = new System.Drawing.Size(31, 13);
            this.priceLabelOne.TabIndex = 5;
            this.priceLabelOne.Text = "Price";
            // 
            // begginingExcelPriceLabel
            // 
            this.begginingExcelPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.begginingExcelPriceLabel.Location = new System.Drawing.Point(172, 108);
            this.begginingExcelPriceLabel.Name = "begginingExcelPriceLabel";
            this.begginingExcelPriceLabel.Size = new System.Drawing.Size(45, 23);
            this.begginingExcelPriceLabel.TabIndex = 7;
            // 
            // begginingPowerPointPriceLabel
            // 
            this.begginingPowerPointPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.begginingPowerPointPriceLabel.Location = new System.Drawing.Point(172, 154);
            this.begginingPowerPointPriceLabel.Name = "begginingPowerPointPriceLabel";
            this.begginingPowerPointPriceLabel.Size = new System.Drawing.Size(45, 23);
            this.begginingPowerPointPriceLabel.TabIndex = 11;
            // 
            // priceLabelTwo
            // 
            this.priceLabelTwo.AutoSize = true;
            this.priceLabelTwo.Location = new System.Drawing.Point(383, 89);
            this.priceLabelTwo.Name = "priceLabelTwo";
            this.priceLabelTwo.Size = new System.Drawing.Size(31, 13);
            this.priceLabelTwo.TabIndex = 12;
            this.priceLabelTwo.Text = "Price";
            // 
            // advancedPowerPointPriceLabel
            // 
            this.advancedPowerPointPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedPowerPointPriceLabel.Location = new System.Drawing.Point(386, 108);
            this.advancedPowerPointPriceLabel.Name = "advancedPowerPointPriceLabel";
            this.advancedPowerPointPriceLabel.Size = new System.Drawing.Size(44, 23);
            this.advancedPowerPointPriceLabel.TabIndex = 14;
            // 
            // advancedExcelPriceLabel
            // 
            this.advancedExcelPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedExcelPriceLabel.Location = new System.Drawing.Point(386, 131);
            this.advancedExcelPriceLabel.Name = "advancedExcelPriceLabel";
            this.advancedExcelPriceLabel.Size = new System.Drawing.Size(44, 23);
            this.advancedExcelPriceLabel.TabIndex = 16;
            // 
            // advancedWordPriceLabel
            // 
            this.advancedWordPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedWordPriceLabel.Location = new System.Drawing.Point(386, 154);
            this.advancedWordPriceLabel.Name = "advancedWordPriceLabel";
            this.advancedWordPriceLabel.Size = new System.Drawing.Size(44, 23);
            this.advancedWordPriceLabel.TabIndex = 18;
            // 
            // creditCardGroupBox
            // 
            this.creditCardGroupBox.Controls.Add(this.creditCardExpirationMaskedTextBox);
            this.creditCardGroupBox.Controls.Add(this.experationDateLabel);
            this.creditCardGroupBox.Controls.Add(this.creditCardNumberLabel);
            this.creditCardGroupBox.Controls.Add(this.creditCardNumberTextBox);
            this.creditCardGroupBox.Controls.Add(this.creditCardTypeLabel);
            this.creditCardGroupBox.Controls.Add(this.creditCardTypeBox);
            this.creditCardGroupBox.Location = new System.Drawing.Point(448, 116);
            this.creditCardGroupBox.Name = "creditCardGroupBox";
            this.creditCardGroupBox.Size = new System.Drawing.Size(273, 231);
            this.creditCardGroupBox.TabIndex = 2;
            this.creditCardGroupBox.TabStop = false;
            this.creditCardGroupBox.Text = "Credit Card Information";
            // 
            // tciOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 406);
            this.Controls.Add(this.creditCardGroupBox);
            this.Controls.Add(this.orderInfromationGroupBox);
            this.Controls.Add(this.studentInformationGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tciPictureBox);
            this.Name = "tciOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCI Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.tciPictureBox)).EndInit();
            this.studentInformationGroupBox.ResumeLayout(false);
            this.studentInformationGroupBox.PerformLayout();
            this.orderInfromationGroupBox.ResumeLayout(false);
            this.orderInfromationGroupBox.PerformLayout();
            this.creditCardGroupBox.ResumeLayout(false);
            this.creditCardGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.RadioButton summerRadioButton;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.MaskedTextBox studentIdMaskedTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.CheckBox begginingExcelCheckBox;
        private System.Windows.Forms.CheckBox beginingPowerPointCheckBox;
        private System.Windows.Forms.CheckBox beginingWordCheckBox;
        private System.Windows.Forms.CheckBox advancedExcelCheckBox;
        private System.Windows.Forms.CheckBox advancedPowerPointCheckBox;
        private System.Windows.Forms.CheckBox advancedWordCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox creditCardTypeBox;
        private System.Windows.Forms.Label creditCardTypeLabel;
        private System.Windows.Forms.MaskedTextBox creditCardNumberTextBox;
        private System.Windows.Forms.Label creditCardNumberLabel;
        private System.Windows.Forms.Label experationDateLabel;
        private System.Windows.Forms.MaskedTextBox creditCardExpirationMaskedTextBox;
        private System.Windows.Forms.Label totalNumberOfCoursesLabel;
        private System.Windows.Forms.Label totalNumberOutputLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.PictureBox tciPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox studentInformationGroupBox;
        private System.Windows.Forms.GroupBox orderInfromationGroupBox;
        private System.Windows.Forms.Label begginingWordPriceLabel;
        private System.Windows.Forms.Label priceLabelOne;
        private System.Windows.Forms.Label begginingExcelPriceLabel;
        private System.Windows.Forms.Label begginingPowerPointPriceLabel;
        private System.Windows.Forms.Label priceLabelTwo;
        private System.Windows.Forms.Label advancedPowerPointPriceLabel;
        private System.Windows.Forms.Label advancedExcelPriceLabel;
        private System.Windows.Forms.Label advancedWordPriceLabel;
        private System.Windows.Forms.GroupBox creditCardGroupBox;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
    }
}

