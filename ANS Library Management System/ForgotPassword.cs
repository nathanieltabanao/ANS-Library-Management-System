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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecurityAnswer.Text)||string.IsNullOrWhiteSpace(txtSecurityQuestion.Text)|| string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                int result1, result2;


                result1 = db.sp_AdminChangePassVerify(txtUsername.Text, null, txtSecurityQuestion.Text, txtSecurityAnswer.Text).Count();
                result2 = db.sp_UserChangePassVerify(txtUsername.Text, null, txtSecurityQuestion.Text, txtSecurityAnswer.Text).Count();


                if (result1==0&&result2==0)
                {
                    MessageBox.Show("Please make sure you have inputed the correct username");
                }
                else
                {
                    ChangePass c = new ChangePass();
                    c.username = txtUsername.Text;
                    this.Hide();
                    c.from = "change";
                    c.Show();
                }
            }

        }
    }
}
