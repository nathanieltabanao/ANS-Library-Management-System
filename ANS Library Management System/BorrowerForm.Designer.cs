namespace ANS_Library_Management_System
{
    partial class BorrowerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowerForm));
            this.stripAdmin = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksBorrowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripAdmin
            // 
            this.stripAdmin.AllowItemReorder = true;
            this.stripAdmin.AutoSize = false;
            this.stripAdmin.BackColor = System.Drawing.Color.CadetBlue;
            this.stripAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.booksBorrowedToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.stripAdmin.Location = new System.Drawing.Point(0, 0);
            this.stripAdmin.Name = "stripAdmin";
            this.stripAdmin.Size = new System.Drawing.Size(807, 37);
            this.stripAdmin.TabIndex = 0;
            this.stripAdmin.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(58, 33);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // booksBorrowedToolStripMenuItem
            // 
            this.booksBorrowedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viwToolStripMenuItem});
            this.booksBorrowedToolStripMenuItem.Name = "booksBorrowedToolStripMenuItem";
            this.booksBorrowedToolStripMenuItem.Size = new System.Drawing.Size(121, 33);
            this.booksBorrowedToolStripMenuItem.Text = "Books Borrowed";
            // 
            // viwToolStripMenuItem
            // 
            this.viwToolStripMenuItem.Name = "viwToolStripMenuItem";
            this.viwToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.viwToolStripMenuItem.Text = "View";
            this.viwToolStripMenuItem.Click += new System.EventHandler(this.viwToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(82, 33);
            this.logOutToolStripMenuItem.Text = "Log - Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // BorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ANS_Library_Management_System.Properties.Resources.lms_test__2_;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.stripAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.stripAdmin;
            this.Name = "BorrowerForm";
            this.Text = "Borrower\'s Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BorrowerForm_Load);
            this.stripAdmin.ResumeLayout(false);
            this.stripAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip stripAdmin;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksBorrowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viwToolStripMenuItem;
    }
}