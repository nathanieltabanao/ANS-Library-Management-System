﻿namespace ANS_Library_Management_System
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
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripAdmin
            // 
            this.stripAdmin.AllowItemReorder = true;
            this.stripAdmin.AutoSize = false;
            this.stripAdmin.BackColor = System.Drawing.Color.IndianRed;
            this.stripAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.booksBorrowedToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.stripAdmin.Location = new System.Drawing.Point(0, 0);
            this.stripAdmin.Name = "stripAdmin";
            this.stripAdmin.Size = new System.Drawing.Size(984, 37);
            this.stripAdmin.TabIndex = 0;
            this.stripAdmin.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 33);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Visible = false;
            // 
            // booksBorrowedToolStripMenuItem
            // 
            this.booksBorrowedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viwToolStripMenuItem});
            this.booksBorrowedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.booksBorrowedToolStripMenuItem.Name = "booksBorrowedToolStripMenuItem";
            this.booksBorrowedToolStripMenuItem.Size = new System.Drawing.Size(133, 33);
            this.booksBorrowedToolStripMenuItem.Text = "Books Borrowed";
            // 
            // viwToolStripMenuItem
            // 
            this.viwToolStripMenuItem.Name = "viwToolStripMenuItem";
            this.viwToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.viwToolStripMenuItem.Text = "View";
            this.viwToolStripMenuItem.Click += new System.EventHandler(this.viwToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(85, 33);
            this.logOutToolStripMenuItem.Text = "Log - Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // BorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ANS_Library_Management_System.Properties.Resources.bg_userform;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.stripAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}