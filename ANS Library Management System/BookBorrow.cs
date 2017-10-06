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
    public partial class BookBorrow : Form
    {
        public BookBorrow()
        {
            InitializeComponent();
        }

        //some variables
        public string username { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }
        public string user { get; set; }
        public string name { get; set; }
        public int numBooks { get; set; }


        //instances
        DataClasses1DataContext db = new DataClasses1DataContext();
        SearchUser s = new SearchUser();

        //public methods

        //viweing method
        public void View()
        {
                dgvBooks.DataSource = db.sp_BookView();
        }

        public void Clear()
        {
            txtISBN.Text = null;
            txtAuthor.Text = null;
            txtBookID.Text = null;
            txtCategory.Text = null;
            txtFoS.Text = null;
            txtName.Text = null;
            dtpPublish.Value = DateTime.Now;
            txtPublisher.Text = null;
            txtTitle.Text = null;
            txtUsername.Text = null;
            dtpBorrowed.Value = DateTime.Now;
            numBooks = 0;
            dtpReturn.Value = dtpReturn.Value.AddDays(3);
        }

        public string IsEmpty()
        {
            
            if (string.IsNullOrWhiteSpace(txtISBN.Text)|| string.IsNullOrWhiteSpace(txtAuthor.Text)|| string.IsNullOrWhiteSpace(txtBookID.Text)||
                string.IsNullOrWhiteSpace(txtCategory.Text)|| string.IsNullOrWhiteSpace(txtFoS.Text)|| string.IsNullOrWhiteSpace(txtName.Text)||
                string.IsNullOrWhiteSpace(txtPublisher.Text)|| string.IsNullOrWhiteSpace(txtTitle.Text)|| string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                return "n";
            }
            else
            {
                return "y";
            }
        }

        private void BookBorrow_Load(object sender, EventArgs e)
        {
            lblCurrentAttendant.Text = "Current Attendant: " + username;
            View();
            txtName.Text = s.name;
            txtUsername.Text = s.user;
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.sp_BookSearch(txtSearch.Text);
        }

        private void dgvBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookID.Text = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            txtISBN.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            txtTitle.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            txtAuthor.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
            dtpPublish.Value =DateTime.Parse( dgvBooks.CurrentRow.Cells[4].Value.ToString());
            txtFoS.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
            txtCategory.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
            txtPublisher.Text = dgvBooks.CurrentRow.Cells[7].Value.ToString();
            numBooks = int.Parse(dgvBooks.CurrentRow.Cells[8].Value.ToString());
            txtPrice.Text = dgvBooks.CurrentRow.Cells[9].Value.ToString();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookID.Text = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            txtISBN.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            txtTitle.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            txtAuthor.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
            dtpPublish.Value = DateTime.Parse(dgvBooks.CurrentRow.Cells[4].Value.ToString());
            txtFoS.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
            txtCategory.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
            txtPublisher.Text= dgvBooks.CurrentRow.Cells[7].Value.ToString();
            numBooks = int.Parse(dgvBooks.CurrentRow.Cells[8].Value.ToString());
            txtPrice.Text = dgvBooks.CurrentRow.Cells[9].Value.ToString();
        }

        private void textBoxX11_Click(object sender, EventArgs e)
        {
            UserSearch s = new UserSearch();
            s.Show();
        }

        private void textBoxX11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_DoubleClick(object sender, EventArgs e)
        {
            s.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            s.ShowDialog();
            txtName.Text = s.name;
            txtUsername.Text= s.user;
        }

        private void BookBorrow_Activated(object sender, EventArgs e)
        {
            txtName.Text = s.name;
            txtUsername.Text = s.user;
        }

        private void BookBorrow_Enter(object sender, EventArgs e)
        {
            txtName.Text = s.name;
            txtUsername.Text = s.user;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsEmpty()=="n")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {

                int i = db.sp_ViewBorrowedBooks(txtUsername.Text).Count();
                if (i>=5)
                {
                    MessageBox.Show("Limit of books to be borrowed has been reached.");
                }
                else if (numBooks<=1)
                {
                    MessageBox.Show("Book not available");
                }
                else
                {
                    db.sp_BookBorrowing(username, txtUsername.Text, txtName.Text, txtTitle.Text, DateTime.Now, dtpReturn.Value);
                    numBooks--;
                    db.sp_BookEdit(int.Parse(txtBookID.Text), txtISBN.Text, txtTitle.Text, txtAuthor.Text, dtpPublish.Value, txtFoS.Text, txtCategory.Text, txtPublisher.Text, numBooks, decimal.Parse(txtPrice.Text));
                    MessageBox.Show("Book Chekout Success!");
                    db.sp_BookAction(username, user, "Borrowed a Book", txtTitle.Text, DateTime.Now);
                    View();
                    Clear();
                }
                
            }
        }

        private void BookBorrow_Deactivate(object sender, EventArgs e)
        {
            txtName.Text = s.name;
            txtUsername.Text = s.user;
        }
    }
    
}
