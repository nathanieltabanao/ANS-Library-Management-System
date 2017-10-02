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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        encryption_algorithm hash = new encryption_algorithm();

        public string username { get; set; }
        public string password { get; set; }
        string salt, hashed;
        public string from { get; set; }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtCPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)) || (txtPassword.Text != txtCPassword.Text))
            {
                MessageBox.Show("Please fill all fields or passwords do not match");
            }
            else
            {
                salt = txtPassword.Text;
                hashed = hash.HashPass(txtPassword.Text, salt);
                db.sp_AdminChangePass(username, hash.HashPass(hashed, salt));
                db.sp_UserChangePass(username, hash.HashPass(hashed, salt));
                MessageBox.Show("Password changed succesfuly");
                if (from == "change")
                {
                    Login1 l = new Login1();
                    this.Hide();
                    l.Show();
                }
                else
                {
                    this.Close();
                }

            }
        }

        public void Admin()
        {
            db.sp_AdminActionReport(username, "Password Changed", DateTime.Now);
        }

        public void User()
        {
            db.sp_UserActionReport(username, "Password Changed", DateTime.Now);
        }
    }
}
