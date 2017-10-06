using System;
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
    public partial class Return_Form : Form
    {
        public Return_Form()
        {
            InitializeComponent();
        }

        public string username { get; set; }
        public string user { get; set; }
        public string usertype { get; set; }

        string title;
        DateTime dateBorrowed, dateDeadline, DateActual;

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string g;
            if (rdoG.Checked)
            {
                g = "y";
            }
            else
            {
                g = "n";
            }
            db.sp_BookReturn(username, user, title, dateBorrowed, dateDeadline, DateActual, g, "n");
            db.sp_BookReturnEntryDelete(user, title);
            //List<String> data = new List<string>();
            if (g=="y")
            {
                int quantity = db.sp_BookQuantity(title,0);
                quantity++;
                db.sp_BookQuantityUpdate(title, quantity);
                View();
                btnAccept.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            {
                db.sp_InsertDamagedBooks(user, title);
                View();
                btnAccept.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void Return_Form_Load(object sender, EventArgs e)
        {
            View();
            btnAccept.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvView.DataSource = db.sp_SearchBorrowedBooks(txtSearch.Text);
        }

        private void dgvView_DoubleClick(object sender, EventArgs e)
        {
            user = dgvView.CurrentRow.Cells[0].Value.ToString();
            title = dgvView.CurrentRow.Cells[1].Value.ToString();
            dateBorrowed = DateTime.Parse(dgvView.CurrentRow.Cells[2].Value.ToString());
            dateDeadline = DateTime.Parse(dgvView.CurrentRow.Cells[3].Value.ToString());
            DateActual = DateTime.Now;
            MessageBox.Show("Loaded!");
            btnAccept.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void Clear()
        {
            user = null;
            title = null;
            btnAccept.Enabled = false;
            btnCancel.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void View()
        {
            dgvView.DataSource = db.sp_ViewBorrowedBooksAdmin("*");
        }

        private void dgvView_Click(object sender, EventArgs e)
        {
            user = dgvView.CurrentRow.Cells[0].Value.ToString();
            title = dgvView.CurrentRow.Cells[1].Value.ToString();
            dateBorrowed = DateTime.Parse(dgvView.CurrentRow.Cells[2].Value.ToString());
            dateDeadline = DateTime.Parse(dgvView.CurrentRow.Cells[3].Value.ToString());
            DateActual = DateTime.Now;
            MessageBox.Show("Loaded!");
            btnAccept.Enabled = true;
            btnCancel.Enabled = true;
        }
    }
}
