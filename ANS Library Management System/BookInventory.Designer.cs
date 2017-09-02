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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblAttendant = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
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
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.dtpPublishDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cmbFoS = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPublishDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBooks.Location = new System.Drawing.Point(21, 90);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(851, 277);
            this.dgvBooks.TabIndex = 0;
            // 
            // lblAttendant
            // 
            // 
            // 
            // 
            this.lblAttendant.BackgroundStyle.Class = "";
            this.lblAttendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAttendant.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblAttendant.Location = new System.Drawing.Point(685, 11);
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
            this.labelX9.Location = new System.Drawing.Point(21, 51);
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
            this.txtSearch.Location = new System.Drawing.Point(571, 49);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 25);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.WatermarkText = "Search by title, code, publisher";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonX2.Location = new System.Drawing.Point(339, 599);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(85, 42);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX2.TabIndex = 44;
            this.buttonX2.Text = "Cancel";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonX1.Location = new System.Drawing.Point(21, 599);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(85, 42);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX1.TabIndex = 43;
            this.buttonX1.Text = "Add Item";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtpublisher
            // 
            // 
            // 
            // 
            this.txtpublisher.Border.Class = "TextBoxBorder";
            this.txtpublisher.Location = new System.Drawing.Point(156, 543);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(190, 20);
            this.txtpublisher.TabIndex = 40;
            // 
            // txtauthor
            // 
            // 
            // 
            // 
            this.txtauthor.Border.Class = "TextBoxBorder";
            this.txtauthor.Location = new System.Drawing.Point(156, 485);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(190, 20);
            this.txtauthor.TabIndex = 38;
            // 
            // txtISBN
            // 
            // 
            // 
            // 
            this.txtISBN.Border.Class = "TextBoxBorder";
            this.txtISBN.Location = new System.Drawing.Point(156, 456);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 20);
            this.txtISBN.TabIndex = 37;
            // 
            // txtBookID
            // 
            // 
            // 
            // 
            this.txtBookID.Border.Class = "TextBoxBorder";
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(156, 427);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(190, 20);
            this.txtBookID.TabIndex = 36;
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.Border.Class = "TextBoxBorder";
            this.txtTitle.Location = new System.Drawing.Point(328, 383);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(305, 20);
            this.txtTitle.TabIndex = 35;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelX8.Location = new System.Drawing.Point(72, 543);
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
            this.labelX7.Location = new System.Drawing.Point(500, 456);
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
            this.labelX6.Location = new System.Drawing.Point(500, 427);
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
            this.labelX5.Location = new System.Drawing.Point(72, 514);
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
            this.labelX4.Location = new System.Drawing.Point(72, 485);
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
            this.labelX3.Location = new System.Drawing.Point(281, 380);
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
            this.labelX2.Location = new System.Drawing.Point(72, 456);
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
            this.labelX1.Location = new System.Drawing.Point(72, 427);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(49, 23);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "Book ID";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonX3.Location = new System.Drawing.Point(126, 599);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(85, 42);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX3.TabIndex = 45;
            this.buttonX3.Text = "Update Item";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonX4.Location = new System.Drawing.Point(230, 599);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(85, 42);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX4.TabIndex = 46;
            this.buttonX4.Text = "Delete";
            // 
            // dtpPublishDate
            // 
            // 
            // 
            // 
            this.dtpPublishDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpPublishDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpPublishDate.ButtonDropDown.Visible = true;
            this.dtpPublishDate.Location = new System.Drawing.Point(156, 514);
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
            this.dtpPublishDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPublishDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpPublishDate.TabIndex = 47;
            // 
            // cmbFoS
            // 
            this.cmbFoS.DisplayMember = "Text";
            this.cmbFoS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFoS.FormattingEnabled = true;
            this.cmbFoS.ItemHeight = 14;
            this.cmbFoS.Location = new System.Drawing.Point(600, 427);
            this.cmbFoS.Name = "cmbFoS";
            this.cmbFoS.Size = new System.Drawing.Size(222, 20);
            this.cmbFoS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbFoS.TabIndex = 48;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "Text";
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 14;
            this.cmbCategory.Location = new System.Drawing.Point(600, 456);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(222, 20);
            this.cmbCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCategory.TabIndex = 49;
            // 
            // BookInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 665);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbFoS);
            this.Controls.Add(this.dtpPublishDate);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
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
            this.Controls.Add(this.dgvBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInventory";
            this.Text = "BookInventory";
            this.Load += new System.EventHandler(this.BookInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPublishDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private DevComponents.DotNetBar.LabelX lblAttendant;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
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
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpPublishDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbFoS;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCategory;
    }
}