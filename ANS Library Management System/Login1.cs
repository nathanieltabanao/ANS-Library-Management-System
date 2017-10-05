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

        //Instances that is important for the system
        //Database Connection
        DataClasses1DataContext db = new DataClasses1DataContext();
        //Encryption Instance
        encryption_algorithm hash = new encryption_algorithm();

        //Some Very much needed variables
        //variables for system 
        int LogError, result1, result2;
        //variables for password hashing
        string salt, hashed;
        
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //setting of variables
            salt = txtPassword.Text;
            //passowrd forst hash
            hashed = hash.HashPass(txtPassword.Text, salt);

            //primary login check
            result1 = db.sp_UserLogin(txtUsername.Text, hash.HashPass(hashed, salt)).Count(); //login check for user table
            result2 = db.sp_AdminLogin(txtUsername.Text, hash.HashPass(hashed, salt)).Count(); //login check for admin table

            //failed authentication
            if (result1==0&&result2==0)
            {
                MessageBox.Show("Invalid Username or Password"); //Show message to user failed authentication
                LogError++; // count many incorrect attemps for forget password
                db.sp_LoginReport(txtUsername.Text, null, null, hash.HashPass(hashed, salt), "Login Failed", DateTime.Now, null); //login report if failed or success
                txtPassword.Text = null;

                //if too many incorrect attempts try to show forget passweord
                if (LogError>3) // 3 incorrect attempts and show link for forget password
                {
                    lblForget.Text = "Forget Password?"; //show forget password
                }
            }
            //username match for user table goes here
            else if (result1==1)
            {
                //user table success
                LogError = 0; //clear log attempts
                //identify if the user is teacher or student
                int a = db.UserUsertype(txtUsername.Text,null).Count();
                BorrowerForm b = new BorrowerForm(); //instantiate new borrower form
                if (a==0)
                {
                    // if the user is a teacher details goes here
                    

                    //transferring of raw data
                    b.username = txtUsername.Text;
                    b.password = txtPassword.Text;

                    //Create Log report
                    db.sp_LoginReport(txtUsername.Text, null, txtUsername.Text, hash.HashPass(hashed, salt), "Login Success", DateTime.Now, "Teacher");

                    //transfer to another form
                    this.Hide();
                    b.Show();
                }
                else
                {
                    //if the user is a student, details continue here
                    

                    //transferrring of variables
                    b.username = txtUsername.Text;
                    b.password = txtPassword.Text;

                    //create login report
                    db.sp_LoginReport(txtUsername.Text, null, txtUsername.Text, hash.HashPass(hashed, salt), "Login Success", DateTime.Now, "Student");

                    //transferring to another form
                    this.Hide();
                    b.Show();
                }
            }
            else
            {
                //success for admin table goes here
                LogError = 0; //clearing log attempt error
                int a = db.AdminUsertype(txtUsername.Text, null).Count(); //try to identify if the user is admin or personnel
                if (a==0)
                {
                    //for table for personnel goes here
                    PersonnelForm p = new PersonnelForm();

                    //transferring of raw data
                    p.username = txtUsername.Text;
                    p.password = txtPassword.Text;

                    //create log report
                    db.sp_LoginReport(txtUsername.Text,txtUsername.Text,null, hash.HashPass(hashed, salt), "Login Success", DateTime.Now, "Personnel");

                    //transfer form
                    this.Hide();
                    p.Show();
                }
                else
                {
                    //for admin account goes here
                    AdminForm ad = new AdminForm(); //create instance for admin

                    //transferring of raw data
                    ad.username = txtUsername.Text;
                    ad.password = txtPassword.Text;

                    //create a login report
                    db.sp_LoginReport(txtUsername.Text, txtUsername.Text, null, hash.HashPass(hashed, salt), "Login Success", DateTime.Now, "Admin");

                    //transferring of form
                    this.Hide();
                    ad.Show();
                }
            }
            

        }

        //first load of login form
        private void Login1_Load(object sender, EventArgs e)
        {
            //hide forget text
            lblForget.Text = null;
        }

        //Forget password link clicked
        private void lblForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //transfer to forget passowrd form
            ForgotPassword f = new ForgotPassword();
            this.Hide();
            f.Show();
        }
    }
}
