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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int LogError;
        encryption_algorithm hash = new encryption_algorithm();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result;
            string salt = txtPassword.Text;
            string hashed = hash.HashPass(txtPassword.Text, salt);
            result = db.sp_UserLogin(txtUsername.Text, hash.HashPass(hashed,salt)).Count();

            if (result == 0)
            {
                MessageBox.Show("Error");
                LogError++;
                if (LogError>=3)
                {
                    lblForget.Text = "Forgot Password?";
                }
            }
            else
            {
                AdminForm admin = new AdminForm();
                admin.Show();
                this.Hide();
            }
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            lblForget.Text = null;
        }

        private void lblForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide;
        }
    }
}
