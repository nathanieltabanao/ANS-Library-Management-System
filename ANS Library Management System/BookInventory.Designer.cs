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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Add Book";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(14, 14);
            this.bunifuThinButton1.Margin = new System.Windows.Forms.Padding(1);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(118, 40);
            this.bunifuThinButton1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(613, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.text = "Search for book";
            // 
            // BookInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 402);
            this.Controls.Add(this.bunifuThinButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInventory";
            this.Text = "BookInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
    }
}