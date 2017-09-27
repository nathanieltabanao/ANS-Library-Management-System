using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANS_Library_Management_System
{
    public partial class BorrowerForm : Form
    {
        public BorrowerForm()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        encryption_algorithm hash = new encryption_algorithm();

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
            db.sp_LoginReport(username, null, username, hash.HashPass(hashed, salt), "Logout", DateTime.Now, usertype);
        }

        private void viwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Book_Form s = new Student_Book_Form();
            s.username = username;
            s.usertype = usertype;
            s.MdiParent = this;
            s.Show();
        }

        private void BorrowerForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
