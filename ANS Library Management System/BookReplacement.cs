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

        //instances needed
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void BookReplacement_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.sp_ViewLostBooksTable("");
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.sp_ViewLostBooks(txtSearch.Text);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
