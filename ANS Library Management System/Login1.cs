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
        int LogError, result1, result2;
        string salt, hashed, action;
        encryption_algorithm hash = new encryption_algorithm();
        clsMiddleClass m = new clsMiddleClass();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            salt = txtPassword.Text;
            hashed = hash.HashPass(txtPassword.Text, salt);

            result1 = db.sp_UserLogin(txtUsername.Text, hash.HashPass(hashed, salt)).Count();
            result2 = db.sp_AdminLogin(txtUsername.Text, hash.HashPass(hashed, salt)).Count();
            if (result1==0&&result2==0)
            {
                MessageBox.Show("Invalid Username or Password");
                LogError++;
                db.sp_LoginReport(txtUsername.Text, hash.HashPass(hashed, salt), "Login Failed", DateTime.Now, null);
                if (LogError>3)
                {
                    lblForget.Text = "Forget Password";
                }
            }
            else if (result1==1)
            {
                //user
                LogError = 0;
                int a = db.UserUsertype(txtUsername.Text,null).Count();
                if (a==0)
                {
                    //teacher
                    BorrowerForm b = new BorrowerForm();
                    b.username = txtUsername.Text;
                    b.password = txtPassword.Text;
                    db.sp_LoginReport(txtUsername.Text, hash.HashPass(hashed, salt), "Login Success", DateTime.Now, "Teacher");
                    this.Hide();
                    b.Show();
                }
                else
                {
                    //student
                    BorrowerForm b = new BorrowerForm();
                    b.username = txtUsername.Text;
                    b.password = txtPassword.Text;
                    db.sp_LoginReport(txtUsername.Text, hash.HashPass(hashed, salt), "Login Success", DateTime.Now, "Student");
                    this.Hide();
                    b.Show();
                }
            }
            else
            {
                //admin
                LogError = 0;
                int a = db.AdminUsertype(txtUsername.Text, null).Count();
                if (a==0)
                {
                    PersonnelForm p = new PersonnelForm();
                    p.username = txtUsername.Text;
                    p.password = txtPassword.Text;
                    db.sp_LoginReport(txtUsername.Text, hash.HashPass(hashed, salt), "Login Success", DateTime.Now, "Personnel");
                    PersonnelForm personnel = new PersonnelForm();
                    this.Hide();
                    personnel.Show();
                }
                else
                {
                    AdminForm ad = new AdminForm();
                    ad.username = txtUsername.Text;
                    ad.password = txtPassword.Text;
                    db.sp_LoginReport(txtUsername.Text, hash.HashPass(hashed, salt), "Login Success", DateTime.Now, "Admin");
                    AdminForm admin = new AdminForm();
                    this.Hide();
                    admin.Show();
                }
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
