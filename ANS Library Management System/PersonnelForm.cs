﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANS_Library_Management_System
{
    public partial class PersonnelForm : Form
    {
        public PersonnelForm() => InitializeComponent();

        encryption_algorithm hash = new encryption_algorithm();
        DataClasses1DataContext db = new DataClasses1DataContext();

        public string username { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }
        string salt, hashed;


        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            salt = password;
            hashed = hash.HashPass(password, salt);
            Login1 log = new Login1();
            this.Hide();
            log.Show();
            db.sp_LoginReport(username, username, null, hash.HashPass(hashed, salt), "Logout", DateTime.Now, "Personnel");
        }

        private void bookReplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReplacement rep = new BookReplacement();
            rep.MdiParent = this;
            rep.username = username;
            rep.Show();
        }

        private void bookBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookBorrow bor = new BookBorrow();
            bor.MdiParent = this;
            bor.username = username;
            bor.Show();
        }

        private void bookInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInventory inv = new BookInventory();
            inv.username = username;
            inv.password = password;
            inv.MdiParent = this;
            inv.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInventory inv = new BookInventory();
            inv.username = username;
            inv.password = password;
            inv.MdiParent = this;
            inv.Show();
        }

        private void bookPenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookPenalty p = new BookPenalty();
            p.MdiParent = this;
            p.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass c = new ChangePass();
            c.username = username;
            c.MdiParent = this;
            c.from = "admin";
            c.Show();
        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Form r = new Return_Form();
            r.MdiParent = this;
            r.username = username;
            r.Show();
        }

        private void topBorrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Top_Borrower_Viewer tbv = new Top_Borrower_Viewer();
            tbv.MdiParent = this;
            tbv.Show();
        }

        private void topBorrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Top_Borrowed_Books_Viewer tbb = new Top_Borrowed_Books_Viewer();
            tbb.MdiParent = this;
            tbb.Show();
        }

        private void penaltyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Penalty_Report_View pr = new Penalty_Report_View();
            pr.MdiParent = this;
            pr.Show();
        }

        private void replacementReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replacement_Report_Viewer rr = new Replacement_Report_Viewer();
            rr.MdiParent = this;
            rr.Show();
        }

        private void PersonnelForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
