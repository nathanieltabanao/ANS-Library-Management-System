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

        //instances
        DataClasses1DataContext db = new DataClasses1DataContext();

        //public methods

        //viweing method
        public void View()
        {
            dgvBooks.DataSource = db.sp_BookView();
        }

        private void BookBorrow_Load(object sender, EventArgs e)
        {
            View();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.sp_BookSearch(txtSearch.Text);
        }

        private void dgvBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookID.Text = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            txtISBN.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            txtTitle.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            txtAuthor.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
            txtPublishDate.Text = dgvBooks.CurrentRow.Cells[4].Value.ToString();
            txtFoS.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
            txtCategory.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
            txtPublisher.Text= dgvBooks.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
