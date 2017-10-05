namespace ANS_Library_Management_System
{
    partial class BookPenalty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookPenalty));
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numDue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numCash = new System.Windows.Forms.NumericUpDown();
            this.txtChange = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvAccounting = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpActual = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.lblCurrentAttendant = new System.Windows.Forms.Label();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.labelX10.Location = new System.Drawing.Point(8, 7);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(87, 38);
            this.labelX10.TabIndex = 73;
            this.labelX10.Text = "Penalty";
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.AllowUserToOrderColumns = true;
            this.dgvView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvView.Location = new System.Drawing.Point(11, 56);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(433, 223);
            this.dgvView.TabIndex = 74;
            this.dgvView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellContentClick);
            this.dgvView.DoubleClick += new System.EventHandler(this.dgvView_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Location = new System.Drawing.Point(179, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(265, 20);
            this.txtSearch.TabIndex = 76;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Location = new System.Drawing.Point(127, 321);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Cash :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Total Due :";
            // 
            // numDue
            // 
            this.numDue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numDue.DecimalPlaces = 2;
            this.numDue.Location = new System.Drawing.Point(497, 295);
            this.numDue.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDue.Name = "numDue";
            this.numDue.Size = new System.Drawing.Size(223, 20);
            this.numDue.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Change :";
            // 
            // numCash
            // 
            this.numCash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numCash.DecimalPlaces = 2;
            this.numCash.Location = new System.Drawing.Point(497, 321);
            this.numCash.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCash.Name = "numCash";
            this.numCash.Size = new System.Drawing.Size(223, 20);
            this.numCash.TabIndex = 84;
            // 
            // txtChange
            // 
            this.txtChange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtChange.Border.Class = "TextBoxBorder";
            this.txtChange.Location = new System.Drawing.Point(497, 378);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(223, 20);
            this.txtChange.TabIndex = 85;
            // 
            // dgvAccounting
            // 
            this.dgvAccounting.AllowUserToAddRows = false;
            this.dgvAccounting.AllowUserToDeleteRows = false;
            this.dgvAccounting.AllowUserToOrderColumns = true;
            this.dgvAccounting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAccounting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAccounting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounting.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccounting.Location = new System.Drawing.Point(455, 56);
            this.dgvAccounting.Name = "dgvAccounting";
            this.dgvAccounting.ReadOnly = true;
            this.dgvAccounting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounting.Size = new System.Drawing.Size(427, 223);
            this.dgvAccounting.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Date Actual Returned :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Return Dateline :";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpReturn.Location = new System.Drawing.Point(127, 347);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(265, 20);
            this.dtpReturn.TabIndex = 89;
            // 
            // dtpActual
            // 
            this.dtpActual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpActual.Location = new System.Drawing.Point(127, 373);
            this.dtpActual.Name = "dtpActual";
            this.dtpActual.Size = new System.Drawing.Size(265, 20);
            this.dtpActual.TabIndex = 90;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirm.Location = new System.Drawing.Point(645, 347);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConfirm.TabIndex = 91;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCurrentAttendant
            // 
            this.lblCurrentAttendant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrentAttendant.AutoSize = true;
            this.lblCurrentAttendant.Location = new System.Drawing.Point(826, 32);
            this.lblCurrentAttendant.Name = "lblCurrentAttendant";
            this.lblCurrentAttendant.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentAttendant.TabIndex = 92;
            this.lblCurrentAttendant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Location = new System.Drawing.Point(127, 295);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 20);
            this.txtUsername.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Username :";
            // 
            // BookPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 420);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCurrentAttendant);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtpActual);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvAccounting);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.numCash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.labelX10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookPenalty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.BookPenalty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCash;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChange;
        private System.Windows.Forms.DataGridView dgvAccounting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpActual;
        private DevComponents.DotNetBar.ButtonX btnConfirm;
        private System.Windows.Forms.Label lblCurrentAttendant;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private System.Windows.Forms.Label label8;
    }
}