namespace ANS_Library_Management_System
{
    partial class RegistrationForm
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
            this.txtfirstname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtlastname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmiddlename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbSecQuestion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.question1 = new DevComponents.Editors.ComboItem();
            this.question2 = new DevComponents.Editors.ComboItem();
            this.question3 = new DevComponents.Editors.ComboItem();
            this.question4 = new DevComponents.Editors.ComboItem();
            this.question5 = new DevComponents.Editors.ComboItem();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtAnswer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.dtpBirthdate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnRegister = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoPersonnel = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoTeacher = new System.Windows.Forms.RadioButton();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.txtContact = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.txtAge = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.cmbGradeLevel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.cmbSection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBirthdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtfirstname
            // 
            // 
            // 
            // 
            this.txtfirstname.Border.Class = "";
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtfirstname.Location = new System.Drawing.Point(161, 173);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(234, 23);
            this.txtfirstname.TabIndex = 3;
            this.txtfirstname.WatermarkText = "First name...";
            // 
            // txtlastname
            // 
            // 
            // 
            // 
            this.txtlastname.Border.Class = "";
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtlastname.Location = new System.Drawing.Point(161, 135);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(234, 23);
            this.txtlastname.TabIndex = 2;
            this.txtlastname.WatermarkText = "Last name...";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(47, 135);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(77, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Last Name:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(47, 173);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(77, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "First Name:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(47, 91);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(77, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "ID:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(47, 210);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(91, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Middle Name:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "";
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.Location = new System.Drawing.Point(161, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 23);
            this.txtID.TabIndex = 1;
            this.txtID.WatermarkText = "User ID...";
            // 
            // txtmiddlename
            // 
            // 
            // 
            // 
            this.txtmiddlename.Border.Class = "TextBoxBorder";
            this.txtmiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtmiddlename.Location = new System.Drawing.Point(161, 210);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(234, 23);
            this.txtmiddlename.TabIndex = 4;
            this.txtmiddlename.WatermarkText = "Middle name...";
            // 
            // cmbSecQuestion
            // 
            this.cmbSecQuestion.DisplayMember = "Text";
            this.cmbSecQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSecQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecQuestion.FormattingEnabled = true;
            this.cmbSecQuestion.ItemHeight = 20;
            this.cmbSecQuestion.Items.AddRange(new object[] {
            this.question1,
            this.question2,
            this.question3,
            this.question4,
            this.question5});
            this.cmbSecQuestion.Location = new System.Drawing.Point(287, 416);
            this.cmbSecQuestion.Name = "cmbSecQuestion";
            this.cmbSecQuestion.Size = new System.Drawing.Size(348, 26);
            this.cmbSecQuestion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSecQuestion.TabIndex = 14;
            // 
            // question1
            // 
            this.question1.Text = "Question One";
            // 
            // question2
            // 
            this.question2.Text = "Question 2";
            // 
            // question3
            // 
            this.question3.Text = "Question 3";
            // 
            // question4
            // 
            this.question4.Text = "Question 4";
            // 
            // question5
            // 
            this.question5.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center;
            this.question5.Text = "Question 5";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(287, 392);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(108, 23);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Security Question";
            // 
            // txtAnswer
            // 
            // 
            // 
            // 
            this.txtAnswer.Border.Class = "TextBoxBorder";
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnswer.Location = new System.Drawing.Point(287, 480);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(348, 26);
            this.txtAnswer.TabIndex = 15;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(287, 453);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(108, 23);
            this.labelX6.TabIndex = 14;
            this.labelX6.Text = "Answer";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.Location = new System.Drawing.Point(47, 480);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 23);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.WatermarkText = "Password";
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.Location = new System.Drawing.Point(47, 416);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 23);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.WatermarkText = "Username";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(47, 451);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(77, 23);
            this.labelX7.TabIndex = 18;
            this.labelX7.Text = "Password";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(47, 392);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(77, 23);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "Username";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(47, 248);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(77, 23);
            this.labelX10.TabIndex = 21;
            this.labelX10.Text = "Address:";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.Location = new System.Drawing.Point(161, 249);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 54);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.WatermarkText = "Address...";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(423, 173);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(108, 23);
            this.labelX11.TabIndex = 23;
            this.labelX11.Text = "Gender:";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rdoMale.Location = new System.Drawing.Point(8, 12);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(56, 20);
            this.rdoMale.TabIndex = 24;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rdoFemale.Location = new System.Drawing.Point(78, 12);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(72, 20);
            this.rdoFemale.TabIndex = 25;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(423, 210);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(108, 23);
            this.labelX12.TabIndex = 26;
            this.labelX12.Text = "Birthdate:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.AllowEmptyState = false;
            // 
            // 
            // 
            this.dtpBirthdate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpBirthdate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpBirthdate.ButtonDropDown.Visible = true;
            this.dtpBirthdate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.dtpBirthdate.IsInputReadOnly = true;
            this.dtpBirthdate.Location = new System.Drawing.Point(537, 212);
            // 
            // 
            // 
            this.dtpBirthdate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpBirthdate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpBirthdate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpBirthdate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpBirthdate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpBirthdate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dtpBirthdate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpBirthdate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpBirthdate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpBirthdate.MonthCalendar.TodayButtonVisible = true;
            this.dtpBirthdate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpBirthdate.TabIndex = 9;
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dtpBirthdate_ValueChanged);
            this.dtpBirthdate.Click += new System.EventHandler(this.dtpBirthdate_Click);
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(423, 89);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(108, 23);
            this.labelX13.TabIndex = 29;
            this.labelX13.Text = "E-mail Address:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(537, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 23);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.WatermarkText = "j.doe@...";
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.Location = new System.Drawing.Point(689, 515);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(105, 41);
            this.btnRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegister.TabIndex = 30;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ANS_Library_Management_System.Properties.Resources.add_contact;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Checked = true;
            this.rdoAdmin.Location = new System.Drawing.Point(6, 38);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdoAdmin.TabIndex = 32;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Admin";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            this.rdoAdmin.CheckedChanged += new System.EventHandler(this.rdoAdmin_CheckedChanged);
            // 
            // rdoPersonnel
            // 
            this.rdoPersonnel.AutoSize = true;
            this.rdoPersonnel.Location = new System.Drawing.Point(85, 38);
            this.rdoPersonnel.Name = "rdoPersonnel";
            this.rdoPersonnel.Size = new System.Drawing.Size(72, 17);
            this.rdoPersonnel.TabIndex = 33;
            this.rdoPersonnel.Text = "Personnel";
            this.rdoPersonnel.UseVisualStyleBackColor = true;
            this.rdoPersonnel.CheckedChanged += new System.EventHandler(this.rdoPersonnel_CheckedChanged);
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(170, 38);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(62, 17);
            this.rdoStudent.TabIndex = 34;
            this.rdoStudent.Text = "Student";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoStudent_CheckedChanged);
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Location = new System.Drawing.Point(246, 38);
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Size = new System.Drawing.Size(65, 17);
            this.rdoTeacher.TabIndex = 35;
            this.rdoTeacher.Text = "Teacher";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            this.rdoTeacher.CheckedChanged += new System.EventHandler(this.rdoTeacher_CheckedChanged);
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(6, 9);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(76, 23);
            this.labelX14.TabIndex = 36;
            this.labelX14.Text = "User Type";
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.Border.Class = "TextBoxBorder";
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtContact.Location = new System.Drawing.Point(537, 136);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(234, 23);
            this.txtContact.TabIndex = 7;
            this.txtContact.WatermarkText = "09...";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(423, 136);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(108, 23);
            this.labelX9.TabIndex = 22;
            this.labelX9.Text = "Contact number:";
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(423, 248);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(84, 23);
            this.labelX15.TabIndex = 38;
            this.labelX15.Text = "Age:";
            // 
            // txtAge
            // 
            // 
            // 
            // 
            this.txtAge.Border.Class = "TextBoxBorder";
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAge.Location = new System.Drawing.Point(537, 248);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(234, 23);
            this.txtAge.TabIndex = 9;
            this.txtAge.WatermarkText = "100 years";
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.Location = new System.Drawing.Point(423, 285);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(84, 23);
            this.labelX16.TabIndex = 40;
            this.labelX16.Text = "Grade Level";
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX17.Location = new System.Drawing.Point(423, 323);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(84, 23);
            this.labelX17.TabIndex = 42;
            this.labelX17.Text = "Grade Section";
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.DisplayMember = "Text";
            this.cmbGradeLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.ItemHeight = 14;
            this.cmbGradeLevel.Items.AddRange(new object[] {
            this.comboItem1});
            this.cmbGradeLevel.Location = new System.Drawing.Point(538, 288);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(243, 20);
            this.cmbGradeLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbGradeLevel.TabIndex = 10;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "test";
            // 
            // cmbSection
            // 
            this.cmbSection.DisplayMember = "Text";
            this.cmbSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.ItemHeight = 14;
            this.cmbSection.Items.AddRange(new object[] {
            this.comboItem2});
            this.cmbSection.Location = new System.Drawing.Point(537, 323);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(243, 20);
            this.cmbSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSection.TabIndex = 11;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX14);
            this.groupBox1.Controls.Add(this.rdoAdmin);
            this.groupBox1.Controls.Add(this.rdoPersonnel);
            this.groupBox1.Controls.Add(this.rdoStudent);
            this.groupBox1.Controls.Add(this.rdoTeacher);
            this.groupBox1.Location = new System.Drawing.Point(459, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 64);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoMale);
            this.groupBox2.Controls.Add(this.rdoFemale);
            this.groupBox2.Location = new System.Drawing.Point(537, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 41);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.cmbGradeLevel);
            this.Controls.Add(this.labelX17);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.cmbSecQuestion);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpBirthdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtfirstname;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlastname;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmiddlename;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSecQuestion;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAnswer;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.LabelX labelX11;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpBirthdate;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.ButtonX btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAge;
        private DevComponents.Editors.ComboItem question1;
        private DevComponents.Editors.ComboItem question2;
        private DevComponents.Editors.ComboItem question3;
        private DevComponents.Editors.ComboItem question4;
        private DevComponents.Editors.ComboItem question5;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.RadioButton rdoPersonnel;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoTeacher;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContact;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbGradeLevel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSection;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}