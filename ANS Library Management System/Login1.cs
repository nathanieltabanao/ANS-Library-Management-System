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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result;
            result = db.sp_login(txtUsername.Text, txtPassword.Text).Count();

            if (result == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                PersonnelForm n = new PersonnelForm();
                this.Hide();
                n.Show();
            }
        }
    }
}
