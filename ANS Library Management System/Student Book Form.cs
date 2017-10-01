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
    public partial class Student_Book_Form : Form
    {
        public Student_Book_Form()
        {
            InitializeComponent();
        }

        public string username { get; set; }
        public string usertype { get; set; }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void Student_Book_Form_Load(object sender, EventArgs e)
        {
            dgvView.DataSource = db.sp_ViewBorrowedBooks(username);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
