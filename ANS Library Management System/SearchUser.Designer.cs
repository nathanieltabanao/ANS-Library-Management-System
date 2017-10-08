namespace ANS_Library_Management_System
{
    partial class SearchUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtpSearch = new System.Windows.Forms.DataGridView();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(406, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(411, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtpSearch
            // 
            this.dtpSearch.AllowUserToAddRows = false;
            this.dtpSearch.AllowUserToDeleteRows = false;
            this.dtpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtpSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtpSearch.Location = new System.Drawing.Point(30, 104);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtpSearch.Size = new System.Drawing.Size(787, 224);
            this.dtpSearch.TabIndex = 2;
            this.dtpSearch.DoubleClick += new System.EventHandler(this.dtpSearch_DoubleClick);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX10.Location = new System.Drawing.Point(33, 61);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(173, 36);
            this.labelX10.TabIndex = 80;
            this.labelX10.Text = "Double click on user to add";
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(829, 365);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchUser_FormClosed);
            this.Load += new System.EventHandler(this.SearchUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dtpSearch;
        private DevComponents.DotNetBar.LabelX labelX10;
    }
}