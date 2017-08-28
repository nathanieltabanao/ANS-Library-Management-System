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
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topBorrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripAdmin
            // 
            this.stripAdmin.AutoSize = false;
            this.stripAdmin.BackColor = System.Drawing.Color.CadetBlue;
            this.stripAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.libraryFunctionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
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
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(103, 33);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // libraryFunctionsToolStripMenuItem
            // 
            this.libraryFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookInventoryToolStripMenuItem,
            this.bookBorrowingToolStripMenuItem,
            this.bookPenaltyToolStripMenuItem,
            this.bookReplacementToolStripMenuItem});
            this.libraryFunctionsToolStripMenuItem.Name = "libraryFunctionsToolStripMenuItem";
            this.libraryFunctionsToolStripMenuItem.Size = new System.Drawing.Size(126, 33);
            this.libraryFunctionsToolStripMenuItem.Text = "Library Functions";
            // 
            // bookInventoryToolStripMenuItem
            // 
            this.bookInventoryToolStripMenuItem.Name = "bookInventoryToolStripMenuItem";
            this.bookInventoryToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bookInventoryToolStripMenuItem.Text = "Book Inventory";
            // 
            // bookBorrowingToolStripMenuItem
            // 
            this.bookBorrowingToolStripMenuItem.Name = "bookBorrowingToolStripMenuItem";
            this.bookBorrowingToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bookBorrowingToolStripMenuItem.Text = "Book Borrowing";
            // 
            // bookPenaltyToolStripMenuItem
            // 
            this.bookPenaltyToolStripMenuItem.Name = "bookPenaltyToolStripMenuItem";
            this.bookPenaltyToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bookPenaltyToolStripMenuItem.Text = "Book Penalty";
            // 
            // bookReplacementToolStripMenuItem
            // 
            this.bookReplacementToolStripMenuItem.Name = "bookReplacementToolStripMenuItem";
            this.bookReplacementToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bookReplacementToolStripMenuItem.Text = "Book Replacement";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topBorrowerToolStripMenuItem,
            this.topBorrowedBooksToolStripMenuItem,
            this.penaltyReportToolStripMenuItem,
            this.replacementReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(68, 33);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // topBorrowerToolStripMenuItem
            // 
            this.topBorrowerToolStripMenuItem.Name = "topBorrowerToolStripMenuItem";
            this.topBorrowerToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.topBorrowerToolStripMenuItem.Text = "Top Borrower ";
            // 
            // topBorrowedBooksToolStripMenuItem
            // 
            this.topBorrowedBooksToolStripMenuItem.Name = "topBorrowedBooksToolStripMenuItem";
            this.topBorrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.topBorrowedBooksToolStripMenuItem.Text = "Top Borrowed Books";
            // 
            // penaltyReportToolStripMenuItem
            // 
            this.penaltyReportToolStripMenuItem.Name = "penaltyReportToolStripMenuItem";
            this.penaltyReportToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.penaltyReportToolStripMenuItem.Text = "Penalty Report";
            // 
            // replacementReportToolStripMenuItem
            // 
            this.replacementReportToolStripMenuItem.Name = "replacementReportToolStripMenuItem";
            this.replacementReportToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.replacementReportToolStripMenuItem.Text = "Replacement Report";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(82, 33);
            this.logOutToolStripMenuItem.Text = "Log - Out";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ANS_Library_Management_System.Properties.Resources.lms_test__2_;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.stripAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.stripAdmin;
            this.Name = "AdminForm";
            this.Text = "Administrator\'s Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}