namespace ANS_Library_Management_System
{
    partial class BookInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInventory));
            this.lblAttendant = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.txtpublisher = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtauthor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtISBN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBookID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.dtpPublishDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.numSel = new System.Windows.Forms.NumericUpDown();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cmbFoS = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPublishDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttendant
            // 
            // 
            // 
            // 
            this.lblAttendant.BackgroundStyle.Class = "";
            this.lblAttendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAttendant.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblAttendant.Location = new System.Drawing.Point(643, 12);
            this.lblAttendant.Name = "lblAttendant";
            this.lblAttendant.Size = new System.Drawing.Size(187, 23);
            this.lblAttendant.TabIndex = 26;
            this.lblAttendant.Click += new System.EventHandler(this.lblAttendant_Click);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelX9.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX9.Location = new System.Drawing.Point(22, 79);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(166, 23);
            this.labelX9.TabIndex = 25;
            this.labelX9.Text = "Double click on record to add";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(529, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 23);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.WatermarkText = "Search by title, code, publisher";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(741, 512);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 32);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(421, 512);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 32);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtpublisher
            // 
            // 
            // 
            // 
            this.txtpublisher.Border.Class = "TextBoxBorder";
            this.txtpublisher.Location = new System.Drawing.Point(115, 498);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(248, 20);
            this.txtpublisher.TabIndex = 5;
            // 
            // txtauthor
            // 
            // 
            // 
            // 
            this.txtauthor.Border.Class = "TextBoxBorder";
            this.txtauthor.Location = new System.Drawing.Point(115, 440);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(248, 20);
            this.txtauthor.TabIndex = 3;
            // 
            // txtISBN
            // 
            // 
            // 
            // 
            this.txtISBN.Border.Class = "TextBoxBorder";
            this.txtISBN.Location = new System.Drawing.Point(115, 411);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(248, 20);
            this.txtISBN.TabIndex = 2;
            // 
            // txtBookID
            // 
            // 
            // 
            // 
            this.txtBookID.Border.Class = "TextBoxBorder";
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(115, 382);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(248, 20);
            this.txtBookID.TabIndex = 36;
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.Border.Class = "TextBoxBorder";
            this.txtTitle.Location = new System.Drawing.Point(290, 337);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(305, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX8.Location = new System.Drawing.Point(31, 498);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(83, 23);
            this.labelX8.TabIndex = 34;
            this.labelX8.Text = "Publisher:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX7.Location = new System.Drawing.Point(459, 411);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(83, 23);
            this.labelX7.TabIndex = 33;
            this.labelX7.Text = "Category:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX6.Location = new System.Drawing.Point(459, 382);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(94, 23);
            this.labelX6.TabIndex = 32;
            this.labelX6.Text = "Field of Study:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX5.Location = new System.Drawing.Point(31, 469);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(83, 23);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "Publish date:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX4.Location = new System.Drawing.Point(31, 440);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(64, 23);
            this.labelX4.TabIndex = 30;
            this.labelX4.Text = "Author(s):";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX3.Location = new System.Drawing.Point(243, 334);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(41, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Title";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX2.Location = new System.Drawing.Point(31, 411);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "ISBN";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX1.Location = new System.Drawing.Point(31, 382);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(49, 23);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "Book ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(528, 512);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 32);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(632, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 32);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.AllowEmptyState = false;
            this.dtpPublishDate.AutoSelectDate = true;
            // 
            // 
            // 
            this.dtpPublishDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpPublishDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpPublishDate.ButtonDropDown.Visible = true;
            this.dtpPublishDate.CustomFormat = "yyyy";
            this.dtpPublishDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpPublishDate.Location = new System.Drawing.Point(115, 469);
            // 
            // 
            // 
            this.dtpPublishDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpPublishDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpPublishDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpPublishDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpPublishDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpPublishDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpPublishDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpPublishDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpPublishDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpPublishDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpPublishDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpPublishDate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dtpPublishDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpPublishDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpPublishDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpPublishDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpPublishDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpPublishDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpPublishDate.MonthCalendar.TodayButtonVisible = true;
            this.dtpPublishDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(248, 20);
            this.dtpPublishDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpPublishDate.TabIndex = 4;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBooks.Location = new System.Drawing.Point(22, 108);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(808, 208);
            this.dgvBooks.TabIndex = 50;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            this.dgvBooks.DoubleClick += new System.EventHandler(this.dgvBooks_DoubleClick);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.labelX10.Location = new System.Drawing.Point(22, 27);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(166, 46);
            this.labelX10.TabIndex = 73;
            this.labelX10.Text = "Book Inventory";
            // 
            // numSel
            // 
            this.numSel.Location = new System.Drawing.Point(559, 440);
            this.numSel.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numSel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSel.Name = "numSel";
            this.numSel.Size = new System.Drawing.Size(120, 20);
            this.numSel.TabIndex = 8;
            this.numSel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX11.Location = new System.Drawing.Point(459, 437);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(83, 23);
            this.labelX11.TabIndex = 75;
            this.labelX11.Text = "Quantity";
            // 
            // cmbFoS
            // 
            this.cmbFoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoS.FormattingEnabled = true;
            this.cmbFoS.Items.AddRange(new object[] {
            "Agricultural Sciences",
            "Animal Science",
            "Anthropology ",
            "Applied Economics and Management \t  ",
            "Archaeology",
            "Architecture",
            "Asian Studies ",
            "Astronomy",
            "Atmospheric Science",
            "Biological Engineering ",
            "Biological Sciences \t",
            "Biology and Society \t   ",
            "Chemistry and Chemical Biology",
            "Communication ",
            "Computer Science \t",
            "Design and Environmental Analysis",
            "Development Sociology ",
            "Economics",
            "Electrical and Computer Engineering",
            "Engineering Physics",
            "English",
            "Entomology",
            "Environmental and Sustainability Sciences",
            "Fiction",
            "Fine Arts ",
            "Food Science",
            "Gender & Sexuality Studies ",
            "Global and Public Health Sciences ",
            "Government ",
            "Hotel Administration ",
            "Human Biology, Health and Society ",
            "Human Development \t",
            "Industrial and Labor Relations",
            "Information Science \t",
            "Information Science, Systems, and Technology ",
            "Interdisciplinary Studies \t",
            "International Agriculture and Rural Development ",
            "Italian \t",
            "Landscape Architecture ",
            "Linguistics \t",
            "Materials Science and Engineering",
            "Mathematics \t",
            "Mechanical Engineering \t",
            "Music \t",
            "Near Eastern Studies \t",
            "Nutritional Sciences\t",
            "Operations Research and Engineering ",
            "Performing and Media Arts",
            "Philosophy ",
            "Physics",
            "Plant Science ",
            "Policy Analysis and Management",
            "Psychology ",
            "Religious Studies ",
            "Science and Technology Studies ",
            "Sociology ",
            "Statistical Science",
            "Urban and Regional Studies "});
            this.cmbFoS.Location = new System.Drawing.Point(559, 384);
            this.cmbFoS.Name = "cmbFoS";
            this.cmbFoS.Size = new System.Drawing.Size(271, 21);
            this.cmbFoS.Sorted = true;
            this.cmbFoS.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Action and Adventure",
            "Anthology",
            "Art",
            "Autobiographies",
            "Biographies",
            "Children\'s",
            "Comics",
            "Cookbooks",
            "Diaries",
            "Dictionaries",
            "Drama",
            "Encyclopedias",
            "Fantasy",
            "Guide",
            "Health",
            "History",
            "Horror",
            "Journals",
            "Math",
            "Mystery",
            "Poetry",
            "Prayer books",
            "Religion, Spirituality & New Age",
            "Romance",
            "Satire",
            "Science",
            "Science fiction",
            "Self help",
            "Series",
            "Travel",
            "Trilogy"});
            this.cmbCategory.Location = new System.Drawing.Point(559, 413);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(271, 21);
            this.cmbCategory.Sorted = true;
            this.cmbCategory.TabIndex = 7;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX12.Location = new System.Drawing.Point(459, 466);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(83, 23);
            this.labelX12.TabIndex = 77;
            this.labelX12.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numPrice.Location = new System.Drawing.Point(559, 469);
            this.numPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 9;
            this.numPrice.ThousandsSeparator = true;
            this.numPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "₱";
            // 
            // BookInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbFoS);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.numSel);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.dtpPublishDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtpublisher);
            this.Controls.Add(this.txtauthor);
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
            this.Controls.Add(this.lblAttendant);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookInventory";
            this.Load += new System.EventHandler(this.BookInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpPublishDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.LabelX lblAttendant;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpublisher;
        private DevComponents.DotNetBar.Controls.TextBoxX txtauthor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtISBN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBookID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitle;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpPublishDate;
        private System.Windows.Forms.DataGridView dgvBooks;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.NumericUpDown numSel;
        private DevComponents.DotNetBar.LabelX labelX11;
        private System.Windows.Forms.ComboBox cmbFoS;
        private System.Windows.Forms.ComboBox cmbCategory;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label1;
    }
}