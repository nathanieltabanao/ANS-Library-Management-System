namespace ANS_Library_Management_System
{
    partial class BookBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookBorrow));
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBookID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtISBN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAuthor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPublisher = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFoS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCategory = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.lblCurrentAttendant = new DevComponents.DotNetBar.LabelX();
            this.grpBorrowDetails = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpReturn = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpBorrowed = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.linkRepRecords = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.dtpPublish = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.grpBorrowDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPublish)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBooks.Location = new System.Drawing.Point(22, 97);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(808, 208);
            this.dgvBooks.TabIndex = 2;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            this.dgvBooks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentDoubleClick);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(514, 66);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(313, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.WatermarkText = "Search by title, code, publisher";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX1.Location = new System.Drawing.Point(27, 367);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(49, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Book ID";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX2.Location = new System.Drawing.Point(27, 396);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "ISBN";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX3.Location = new System.Drawing.Point(236, 320);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(41, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Title";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX4.Location = new System.Drawing.Point(27, 425);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(64, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Author(s):";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX5.Location = new System.Drawing.Point(27, 454);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(83, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Publish date:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX6.Location = new System.Drawing.Point(27, 512);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(94, 23);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "Field of Study:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX7.Location = new System.Drawing.Point(27, 541);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(83, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "Category:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX8.Location = new System.Drawing.Point(27, 483);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(83, 23);
            this.labelX8.TabIndex = 11;
            this.labelX8.Text = "Publisher:";
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.Border.Class = "TextBoxBorder";
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(283, 323);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(305, 20);
            this.txtTitle.TabIndex = 12;
            // 
            // txtBookID
            // 
            // 
            // 
            // 
            this.txtBookID.Border.Class = "TextBoxBorder";
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(125, 367);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(190, 20);
            this.txtBookID.TabIndex = 13;
            // 
            // txtISBN
            // 
            // 
            // 
            // 
            this.txtISBN.Border.Class = "TextBoxBorder";
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(125, 396);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 20);
            this.txtISBN.TabIndex = 14;
            // 
            // txtAuthor
            // 
            // 
            // 
            // 
            this.txtAuthor.Border.Class = "TextBoxBorder";
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(125, 425);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(190, 20);
            this.txtAuthor.TabIndex = 15;
            // 
            // txtPublisher
            // 
            // 
            // 
            // 
            this.txtPublisher.Border.Class = "TextBoxBorder";
            this.txtPublisher.Enabled = false;
            this.txtPublisher.Location = new System.Drawing.Point(125, 483);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(190, 20);
            this.txtPublisher.TabIndex = 17;
            // 
            // txtFoS
            // 
            // 
            // 
            // 
            this.txtFoS.Border.Class = "TextBoxBorder";
            this.txtFoS.Enabled = false;
            this.txtFoS.Location = new System.Drawing.Point(125, 512);
            this.txtFoS.Name = "txtFoS";
            this.txtFoS.Size = new System.Drawing.Size(192, 20);
            this.txtFoS.TabIndex = 18;
            // 
            // txtCategory
            // 
            // 
            // 
            // 
            this.txtCategory.Border.Class = "TextBoxBorder";
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(125, 544);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(192, 20);
            this.txtCategory.TabIndex = 19;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelX9.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX9.Location = new System.Drawing.Point(22, 68);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(166, 23);
            this.labelX9.TabIndex = 22;
            this.labelX9.Text = "Double click on record to add";
            // 
            // lblCurrentAttendant
            // 
            // 
            // 
            // 
            this.lblCurrentAttendant.BackgroundStyle.Class = "";
            this.lblCurrentAttendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCurrentAttendant.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCurrentAttendant.Location = new System.Drawing.Point(606, 12);
            this.lblCurrentAttendant.Name = "lblCurrentAttendant";
            this.lblCurrentAttendant.Size = new System.Drawing.Size(224, 23);
            this.lblCurrentAttendant.TabIndex = 23;
            // 
            // grpBorrowDetails
            // 
            this.grpBorrowDetails.Controls.Add(this.btnSearch);
            this.grpBorrowDetails.Controls.Add(this.dtpReturn);
            this.grpBorrowDetails.Controls.Add(this.dtpBorrowed);
            this.grpBorrowDetails.Controls.Add(this.labelX14);
            this.grpBorrowDetails.Controls.Add(this.labelX13);
            this.grpBorrowDetails.Controls.Add(this.txtName);
            this.grpBorrowDetails.Controls.Add(this.txtUsername);
            this.grpBorrowDetails.Controls.Add(this.labelX11);
            this.grpBorrowDetails.Controls.Add(this.labelX12);
            this.grpBorrowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBorrowDetails.Location = new System.Drawing.Point(367, 367);
            this.grpBorrowDetails.Name = "grpBorrowDetails";
            this.grpBorrowDetails.Size = new System.Drawing.Size(463, 197);
            this.grpBorrowDetails.TabIndex = 29;
            this.grpBorrowDetails.TabStop = false;
            this.grpBorrowDetails.Text = "Borrow Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(406, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 23);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpReturn
            // 
            this.dtpReturn.AllowEmptyState = false;
            // 
            // 
            // 
            this.dtpReturn.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpReturn.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpReturn.ButtonDropDown.Visible = true;
            this.dtpReturn.Enabled = false;
            this.dtpReturn.Location = new System.Drawing.Point(147, 145);
            // 
            // 
            // 
            this.dtpReturn.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpReturn.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpReturn.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpReturn.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpReturn.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpReturn.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpReturn.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpReturn.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpReturn.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpReturn.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpReturn.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpReturn.MonthCalendar.DisplayMonth = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dtpReturn.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpReturn.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpReturn.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpReturn.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpReturn.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpReturn.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpReturn.MonthCalendar.TodayButtonVisible = true;
            this.dtpReturn.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(253, 20);
            this.dtpReturn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpReturn.TabIndex = 40;
            this.dtpReturn.Value = new System.DateTime(2017, 9, 16, 11, 0, 38, 537);
            // 
            // dtpBorrowed
            // 
            this.dtpBorrowed.AllowEmptyState = false;
            // 
            // 
            // 
            this.dtpBorrowed.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpBorrowed.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpBorrowed.ButtonDropDown.Visible = true;
            this.dtpBorrowed.Enabled = false;
            this.dtpBorrowed.Location = new System.Drawing.Point(147, 107);
            // 
            // 
            // 
            this.dtpBorrowed.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpBorrowed.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpBorrowed.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpBorrowed.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpBorrowed.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpBorrowed.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpBorrowed.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpBorrowed.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpBorrowed.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpBorrowed.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpBorrowed.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpBorrowed.MonthCalendar.DisplayMonth = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dtpBorrowed.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpBorrowed.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpBorrowed.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpBorrowed.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpBorrowed.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpBorrowed.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpBorrowed.MonthCalendar.TodayButtonVisible = true;
            this.dtpBorrowed.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpBorrowed.Name = "dtpBorrowed";
            this.dtpBorrowed.Size = new System.Drawing.Size(253, 20);
            this.dtpBorrowed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpBorrowed.TabIndex = 39;
            this.dtpBorrowed.Value = new System.DateTime(2017, 9, 16, 11, 0, 38, 654);
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX14.Location = new System.Drawing.Point(47, 142);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(83, 23);
            this.labelX14.TabIndex = 38;
            this.labelX14.Text = "Deadline:";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX13.Location = new System.Drawing.Point(47, 107);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(94, 23);
            this.labelX13.TabIndex = 37;
            this.labelX13.Text = "Date Borrowed:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(147, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 20);
            this.txtName.TabIndex = 36;
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(147, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 20);
            this.txtUsername.TabIndex = 35;
            this.txtUsername.Click += new System.EventHandler(this.textBoxX11_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.textBoxX11_TextChanged);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX11.Location = new System.Drawing.Point(47, 69);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(83, 23);
            this.labelX11.TabIndex = 34;
            this.labelX11.Text = "Name:";
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX12.Location = new System.Drawing.Point(47, 40);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(94, 23);
            this.labelX12.TabIndex = 33;
            this.labelX12.Text = "Username:";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.labelX10.Location = new System.Drawing.Point(22, 23);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(159, 47);
            this.labelX10.TabIndex = 72;
            this.labelX10.Text = "Book Borrow";
            // 
            // linkRepRecords
            // 
            this.linkRepRecords.AutoSize = true;
            this.linkRepRecords.Location = new System.Drawing.Point(684, 45);
            this.linkRepRecords.Name = "linkRepRecords";
            this.linkRepRecords.Size = new System.Drawing.Size(143, 13);
            this.linkRepRecords.TabIndex = 73;
            this.linkRepRecords.TabStop = true;
            this.linkRepRecords.Text = "Show Replacement Records";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(125, 609);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 32);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "Cancel";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(27, 609);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 32);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpPublish
            // 
            this.dtpPublish.AllowEmptyState = false;
            // 
            // 
            // 
            this.dtpPublish.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpPublish.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpPublish.ButtonDropDown.Visible = true;
            this.dtpPublish.Enabled = false;
            this.dtpPublish.Location = new System.Drawing.Point(125, 457);
            // 
            // 
            // 
            this.dtpPublish.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpPublish.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpPublish.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpPublish.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpPublish.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpPublish.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpPublish.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpPublish.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpPublish.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpPublish.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpPublish.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpPublish.MonthCalendar.DisplayMonth = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dtpPublish.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpPublish.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpPublish.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpPublish.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpPublish.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpPublish.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpPublish.MonthCalendar.TodayButtonVisible = true;
            this.dtpPublish.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpPublish.Name = "dtpPublish";
            this.dtpPublish.Size = new System.Drawing.Size(192, 20);
            this.dtpPublish.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpPublish.TabIndex = 42;
            this.dtpPublish.Value = new System.DateTime(2017, 9, 16, 11, 0, 38, 654);
            // 
            // BookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 675);
            this.Controls.Add(this.dtpPublish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.linkRepRecords);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.grpBorrowDetails);
            this.Controls.Add(this.lblCurrentAttendant);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtFoS);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookBorrow";
            this.Text = "Book Borrow";
            this.Activated += new System.EventHandler(this.BookBorrow_Activated);
            this.Deactivate += new System.EventHandler(this.BookBorrow_Deactivate);
            this.Load += new System.EventHandler(this.BookBorrow_Load);
            this.Enter += new System.EventHandler(this.BookBorrow_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.grpBorrowDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPublish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBooks;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBookID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtISBN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAuthor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPublisher;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFoS;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCategory;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lblCurrentAttendant;
        private System.Windows.Forms.GroupBox grpBorrowDetails;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpReturn;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpBorrowed;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.LinkLabel linkRepRecords;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.Button btnSearch;
        public DevComponents.DotNetBar.Controls.TextBoxX txtName;
        public DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpPublish;
    }
}