namespace ANS_Library_Management_System
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.stripAdmin = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBorrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookPenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topBorrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripAdmin
            // 
            this.stripAdmin.AutoSize = false;
            this.stripAdmin.BackColor = System.Drawing.Color.IndianRed;
            this.stripAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.libraryFunctionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.stripAdmin.Location = new System.Drawing.Point(0, 0);
            this.stripAdmin.Name = "stripAdmin";
            this.stripAdmin.Size = new System.Drawing.Size(1000, 37);
            this.stripAdmin.TabIndex = 0;
            this.stripAdmin.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Enabled = false;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 33);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Visible = false;
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem});
            this.managementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(112, 33);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.accountsToolStripMenuItem.Text = "Accounts";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // libraryFunctionsToolStripMenuItem
            // 
            this.libraryFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookInventoryToolStripMenuItem,
            this.bookBorrowingToolStripMenuItem,
            this.bookPenaltyToolStripMenuItem,
            this.bookReplacementToolStripMenuItem,
            this.bookReturningToolStripMenuItem});
            this.libraryFunctionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.libraryFunctionsToolStripMenuItem.Name = "libraryFunctionsToolStripMenuItem";
            this.libraryFunctionsToolStripMenuItem.Size = new System.Drawing.Size(140, 33);
            this.libraryFunctionsToolStripMenuItem.Text = "Library Functions";
            // 
            // bookInventoryToolStripMenuItem
            // 
            this.bookInventoryToolStripMenuItem.Name = "bookInventoryToolStripMenuItem";
            this.bookInventoryToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.bookInventoryToolStripMenuItem.Text = "Book Inventory";
            this.bookInventoryToolStripMenuItem.Click += new System.EventHandler(this.bookInventoryToolStripMenuItem_Click);
            // 
            // bookBorrowingToolStripMenuItem
            // 
            this.bookBorrowingToolStripMenuItem.Name = "bookBorrowingToolStripMenuItem";
            this.bookBorrowingToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.bookBorrowingToolStripMenuItem.Text = "Book Borrowing";
            this.bookBorrowingToolStripMenuItem.Click += new System.EventHandler(this.bookBorrowingToolStripMenuItem_Click);
            // 
            // bookPenaltyToolStripMenuItem
            // 
            this.bookPenaltyToolStripMenuItem.Name = "bookPenaltyToolStripMenuItem";
            this.bookPenaltyToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.bookPenaltyToolStripMenuItem.Text = "Book Penalty";
            this.bookPenaltyToolStripMenuItem.Click += new System.EventHandler(this.bookPenaltyToolStripMenuItem_Click);
            // 
            // bookReplacementToolStripMenuItem
            // 
            this.bookReplacementToolStripMenuItem.Name = "bookReplacementToolStripMenuItem";
            this.bookReplacementToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.bookReplacementToolStripMenuItem.Text = "Book Replacement";
            this.bookReplacementToolStripMenuItem.Click += new System.EventHandler(this.bookReplacementToolStripMenuItem_Click);
            // 
            // bookReturningToolStripMenuItem
            // 
            this.bookReturningToolStripMenuItem.Name = "bookReturningToolStripMenuItem";
            this.bookReturningToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.bookReturningToolStripMenuItem.Text = "Book Returning";
            this.bookReturningToolStripMenuItem.Click += new System.EventHandler(this.bookReturningToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topBorrowerToolStripMenuItem,
            this.topBorrowedBooksToolStripMenuItem,
            this.penaltyReportToolStripMenuItem,
            this.replacementReportToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(73, 33);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // topBorrowerToolStripMenuItem
            // 
            this.topBorrowerToolStripMenuItem.Name = "topBorrowerToolStripMenuItem";
            this.topBorrowerToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.topBorrowerToolStripMenuItem.Text = "Top Borrower ";
            this.topBorrowerToolStripMenuItem.Click += new System.EventHandler(this.topBorrowerToolStripMenuItem_Click_1);
            // 
            // topBorrowedBooksToolStripMenuItem
            // 
            this.topBorrowedBooksToolStripMenuItem.Name = "topBorrowedBooksToolStripMenuItem";
            this.topBorrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.topBorrowedBooksToolStripMenuItem.Text = "Top Borrowed Books";
            this.topBorrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.topBorrowedBooksToolStripMenuItem_Click_1);
            // 
            // penaltyReportToolStripMenuItem
            // 
            this.penaltyReportToolStripMenuItem.Name = "penaltyReportToolStripMenuItem";
            this.penaltyReportToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.penaltyReportToolStripMenuItem.Text = "Penalty Report";
            this.penaltyReportToolStripMenuItem.Click += new System.EventHandler(this.penaltyReportToolStripMenuItem_Click_1);
            // 
            // replacementReportToolStripMenuItem
            // 
            this.replacementReportToolStripMenuItem.Name = "replacementReportToolStripMenuItem";
            this.replacementReportToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.replacementReportToolStripMenuItem.Text = "Replacement Report";
            this.replacementReportToolStripMenuItem.Click += new System.EventHandler(this.replacementReportToolStripMenuItem_Click_1);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(85, 33);
            this.logOutToolStripMenuItem.Text = "Log - Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ANS_Library_Management_System.Properties.Resources.bg_login3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 545);
            this.Controls.Add(this.stripAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.stripAdmin;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Administrator\'s Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.stripAdmin.ResumeLayout(false);
            this.stripAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip stripAdmin;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookBorrowingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookPenaltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReplacementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topBorrowedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturningToolStripMenuItem;
    }
}