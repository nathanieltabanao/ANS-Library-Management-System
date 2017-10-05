namespace ANS_Library_Management_System
{
    partial class BookReplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookReplacement));
            this.txtCurrentAttendant = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtISBN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBookId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grpRepDetails = new System.Windows.Forms.GroupBox();
            this.dtpReplaced = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpRepDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReplaced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentAttendant
            // 
            // 
            // 
            // 
            this.txtCurrentAttendant.BackgroundStyle.Class = "";
            this.txtCurrentAttendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtCurrentAttendant.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtCurrentAttendant.Location = new System.Drawing.Point(647, 7);
            this.txtCurrentAttendant.Name = "txtCurrentAttendant";
            this.txtCurrentAttendant.Size = new System.Drawing.Size(185, 23);
            this.txtCurrentAttendant.TabIndex = 29;
            this.txtCurrentAttendant.Text = "";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelX9.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX9.Location = new System.Drawing.Point(25, 50);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(166, 23);
            this.labelX9.TabIndex = 28;
            this.labelX9.Text = "Double click on record to add";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(532, 48);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 25);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.WatermarkText = "Search by title, code, publisher";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.Border.Class = "TextBoxBorder";
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(82, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(190, 20);
            this.txtTitle.TabIndex = 51;
            // 
            // txtISBN
            // 
            // 
            // 
            // 
            this.txtISBN.Border.Class = "TextBoxBorder";
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(82, 71);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 20);
            this.txtISBN.TabIndex = 60;
            // 
            // txtBookId
            // 
            // 
            // 
            // 
            this.txtBookId.Border.Class = "TextBoxBorder";
            this.txtBookId.Enabled = false;
            this.txtBookId.Location = new System.Drawing.Point(82, 45);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(190, 20);
            this.txtBookId.TabIndex = 59;
            // 
            // grpRepDetails
            // 
            this.grpRepDetails.Controls.Add(this.label3);
            this.grpRepDetails.Controls.Add(this.label2);
            this.grpRepDetails.Controls.Add(this.label1);
            this.grpRepDetails.Controls.Add(this.txtUsername);
            this.grpRepDetails.Controls.Add(this.dtpReplaced);
            this.grpRepDetails.Controls.Add(this.txtName);
            this.grpRepDetails.Location = new System.Drawing.Point(369, 301);
            this.grpRepDetails.Name = "grpRepDetails";
            this.grpRepDetails.Size = new System.Drawing.Size(437, 114);
            this.grpRepDetails.TabIndex = 70;
            this.grpRepDetails.TabStop = false;
            this.grpRepDetails.Text = "Replacement Details";
            this.grpRepDetails.Enter += new System.EventHandler(this.grpRepDetails_Enter);
            // 
            // dtpReplaced
            // 
            this.dtpReplaced.AllowEmptyState = false;
            // 
            // 
            // 
            this.dtpReplaced.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpReplaced.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpReplaced.ButtonDropDown.Visible = true;
            this.dtpReplaced.Location = new System.Drawing.Point(145, 71);
            // 
            // 
            // 
            this.dtpReplaced.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpReplaced.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpReplaced.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpReplaced.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpReplaced.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpReplaced.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpReplaced.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpReplaced.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpReplaced.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpReplaced.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpReplaced.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpReplaced.MonthCalendar.DisplayMonth = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dtpReplaced.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpReplaced.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpReplaced.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpReplaced.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpReplaced.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpReplaced.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpReplaced.MonthCalendar.TodayButtonVisible = true;
            this.dtpReplaced.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpReplaced.Name = "dtpReplaced";
            this.dtpReplaced.Size = new System.Drawing.Size(253, 20);
            this.dtpReplaced.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpReplaced.TabIndex = 37;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(145, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 20);
            this.txtName.TabIndex = 35;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.labelX10.Location = new System.Drawing.Point(25, -3);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(197, 47);
            this.labelX10.TabIndex = 71;
            this.labelX10.Text = "Book Replacement";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBooks.Location = new System.Drawing.Point(25, 79);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(808, 208);
            this.dgvBooks.TabIndex = 73;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            this.dgvBooks.DoubleClick += new System.EventHandler(this.dgvBooks_DoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(717, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 32);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(622, 421);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 32);
            this.btnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnConfirm.TabIndex = 74;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(146, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 20);
            this.txtUsername.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Date Returned :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Title :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Book ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "ISBN :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBookId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(45, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 114);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BookReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.grpRepDetails);
            this.Controls.Add(this.txtCurrentAttendant);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookReplacement";
            this.Text = "Book Replacement";
            this.Load += new System.EventHandler(this.BookReplacement_Load);
            this.grpRepDetails.ResumeLayout(false);
            this.grpRepDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReplaced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX txtCurrentAttendant;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX txtISBN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBookId;
        private System.Windows.Forms.GroupBox grpRepDetails;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpReplaced;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.DataGridView dgvBooks;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnConfirm;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}