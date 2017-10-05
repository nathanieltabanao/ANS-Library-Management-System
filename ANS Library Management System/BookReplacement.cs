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
    public partial class BookReplacement : Form
    {
        public BookReplacement()
        {
            InitializeComponent();
        }

        //some variables
        public string username { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }

        string title, transID;

        //instances needed
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void BookReplacement_Load(object sender, EventArgs e)
        {
            View();
            btnConfirm.Enabled = false;
            txtCurrentAttendant.Text = "Current Attendant :" + username;
        }

        private void View()
        {
            dgvBooks.DataSource = db.sp_ViewLostBooksTable("");
        }

        private void Clear()
        {
            txtBookId.Text = null;
            txtISBN.Text = null;
            txtName.Text = null;
            txtTitle.Text = null;
            txtUsername.Text = null;
            btnConfirm.Enabled = false;
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.sp_ViewLostBooks(txtSearch.Text);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpRepDetails_Enter(object sender, EventArgs e)
        {

        }

        private void dgvBooks_DoubleClick(object sender, EventArgs e)
        {
            transID = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            txtUsername.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgvBooks.CurrentRow.Cells[4].Value.ToString() + ", " + dgvBooks.CurrentRow.Cells[2].Value.ToString() + " " + dgvBooks.CurrentRow.Cells[3].Value.ToString();
            txtBookId.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
            txtISBN.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
            txtTitle.Text = dgvBooks.CurrentRow.Cells[7].Value.ToString();
            title = txtTitle.Text;
            btnConfirm.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.sp_BookReplace(int.Parse(transID), "y");
            int quantity = db.sp_BookQuantity(title, 0);
            quantity++;
            db.sp_BookQuantityUpdate(title, quantity);
            db.sp_ReplaceBook(txtUsername.Text, txtTitle.Text, username, dtpReplaced.Value);
            View();
            btnConfirm.Enabled = false;
            Clear();
        }
    }
}
