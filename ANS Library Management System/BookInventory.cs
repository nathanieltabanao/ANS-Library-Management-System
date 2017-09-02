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
    public partial class BookInventory : Form
    {
        public BookInventory()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        encryption_algorithm hash = new encryption_algorithm();

        public string username { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }

        //view shit
        public void BookView()
        {
            dgvBooks.DataSource = db.sp_BookView();
        }

        public void Clear()
        {
            txtauthor.Text = null;
            txtISBN.Text = null;
            txtpublisher.Text = null;
            txtTitle.Text = null;
            
        }

        public int ID()
        {
            return Convert.ToInt32(db.sp_BookID());
        }

        public void BookID()
        {
            txtBookID.Text = ID().ToString();
        }

        private void BookInventory_Load(object sender, EventArgs e)
        {
            BookView();
            BookID();
            lblAttendant.Text = "Current Attendant: " + username;
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.sp_BookSearch(txtSearch.Text);
            BookID();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtauthor.Text)|| string.IsNullOrWhiteSpace(txtISBN.Text)|| string.IsNullOrWhiteSpace(txtpublisher.Text)||
                string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                db.sp_BookAdd(txtISBN.Text, txtTitle.Text, txtauthor.Text, null, null, null, dtpPublishDate.Value, cmbFoS.Text, cmbCategory.Text, txtpublisher.Text);
                BookView();
                Clear();
                BookID();
            }
        }

        private void lblAttendant_Click(object sender, EventArgs e)
        {

        }
    }
}
