﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ANS_Library_Management_System
{
    public partial class btnCancel : Form
    {
        public btnCancel()
        {
            InitializeComponent();
        }

        //database connection
        DataClasses1DataContext db = new DataClasses1DataContext();


        // hashing stirng
        encryption_algorithm hash = new encryption_algorithm();

        // some variables i might need latur
        string gender, stringdate, salt, hashed, Usertype, action;
        DateTime date;

        //very public shit that is important
        public string username { get; set; }

        //methods for form

        //student ID
        public int Student()
        {
            return Convert.ToInt32(db.sp_UserID());
        }

        //teacher id
        public int Teacher()
        {
            return Convert.ToInt32(db.sp_UserID());
        }

        //admin id
        public int Admin()
        {
            return Convert.ToInt32(db.sp_AdminID());
        }

        //personel id
        public int Personel()
        {
            return Convert.ToInt32(db.sp_AdminID());
        }

        //student id
        public void StudentID()
        {
            if (Student() == 1)
            {
                txtID.Text = "ST-" + (Student().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtID.Text = "ST-" + (Student() + 1).ToString().PadLeft(5, '0');
            }
        }

        //teacher id
        public void TeacherID()
        {
            if (Teacher() == 1)
            {
                txtID.Text = "TC-" + (Teacher().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtID.Text = "TC-" + (Teacher() + 1).ToString().PadLeft(5, '0');
            }
        }


        //admin id
        public void AdminID()
        {
            if (Admin() == 1)
            {
                txtID.Text = "AD-" + (Admin().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtID.Text = "AD-" + (Admin() + 1).ToString().PadLeft(5, '0');
            }
        }

        //personnel id
        public void PersonelID()
        {
            if (Personel() == 1)
            {
                txtID.Text = "PL-" + (Personel().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtID.Text = "PL-" + (Personel() + 1).ToString().PadLeft(5, '0');
            }
        }


        //clearing method
        public void Clear()
        {
            txtAddress.Text = null;
            txtAge.Text = null;
            txtAnswer.Text = null;
            txtContact.Text = null;
            txtEmail.Text = null;
            txtfirstname.Text = null;
            txtlastname.Text = null;
            txtmiddlename.Text = null;
            txtPassword.Text = null;
            txtUsername.Text = null;
            cmbGradeLevel.Text = null;
            cmbSecQuestion.Text = null;
            cmbSection.Text = null;
            gender = null;
            stringdate = null;
            salt = null;
            hashed = null;
            dtpBirthdate.Value = DateTime.Now;
            rdoAdmin.Checked = true;
        }

        //Email Validation
        bool IsValidEmail(string strIn)//Do not Delete
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        //form load clearance
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Clear();

            if (rdoAdmin.Checked)
            {
                AdminID();
                cmbGradeLevel.Enabled = false;
                cmbSection.Enabled=false;
            }
            else if (rdoPersonnel.Checked)
            {
                PersonelID();
            }
            else if (rdoStudent.Checked)
            {
                StudentID();
            }
            else if (rdoTeacher.Checked)
            {
                TeacherID();
            }
        }


        private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
        {
            AdminID();

            txtlastname.Enabled = true;
            txtfirstname.Enabled = true;
            txtmiddlename.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtContact.Enabled = true;
            cmbGradeLevel.Enabled = false;
            cmbSection.Enabled = false;
        }

        private void rdoPersonnel_CheckedChanged(object sender, EventArgs e)
        {
            PersonelID();

            txtlastname.Enabled = true;
            txtfirstname.Enabled = true;
            txtmiddlename.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtContact.Enabled = true;
            cmbGradeLevel.Enabled = false;
            cmbSection.Enabled = false;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpBirthdate_Click(object sender, EventArgs e)
        {

        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dtpBirthdate.Value;
            int years = DateTime.Now.Year - dtpBirthdate.Value.Year;
            if (dtpBirthdate.Value.AddYears(years)>DateTime.Now)
            {
                years--;
            }
            txtAge.Text = years.ToString();
        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            StudentID();

            
            txtlastname.Enabled = true;
            txtfirstname.Enabled = true;
            txtmiddlename.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtContact.Enabled = true;
            cmbGradeLevel.Enabled = true;
            cmbSection.Enabled = true;
        }

        private void rdoTeacher_CheckedChanged(object sender, EventArgs e)
        {
            TeacherID();
            
            txtlastname.Enabled = true;
            txtfirstname.Enabled = true;
            txtmiddlename.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtContact.Enabled = true;
            cmbGradeLevel.Enabled = true;
            cmbSection.Enabled = true;
        }

        string IsEmtpy()
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtContact.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtfirstname.Text) || string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtlastname.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                return "n";
            }
            else
            {
                return "y";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //checking for empty textboxes
            if (IsEmtpy()=="n")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                if (int.Parse(txtAge.Text)<=0)
                {
                    MessageBox.Show("Invalid Age");
                }
                else
                {
                    if (IsValidEmail(txtEmail.Text)) //email validation
                    {
                        //username validation and prevent duplication
                        int resultUser = db.sp_UserUsernameCheck(txtUsername.Text).Count();
                        int resultAdmin = db.sp_AdminUsernameCheck(txtUsername.Text).Count();
                        if (resultAdmin == 0 && resultUser == 0)
                        {
                            //basic stuff
                            //lets hash some shat
                            salt = txtPassword.Text;
                            hashed = hash.HashPass(txtPassword.Text, salt);
                            date = DateTime.Parse(dtpBirthdate.Text);
                            stringdate = dtpBirthdate.Text;

                            //Messagebox
                            MessageBox.Show(txtlastname.Text + ", " + txtfirstname.Text + " is now registered!");

                            //selection of gender
                            if (rdoMale.Checked)
                            {
                                gender = "Male";
                            }
                            else
                            {
                                gender = "Female";
                            }

                            //selection of role
                            if (rdoAdmin.Checked)
                            {
                                Usertype = "Admin";
                                action = "Registered an Admin";
                                db.sp_AdminInsert(txtID.Text, txtUsername.Text, hash.HashPass(hashed, salt), txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, txtAddress.Text, txtContact.Text, gender, date, int.Parse(txtAge.Text), txtEmail.Text, cmbSecQuestion.Text, txtAnswer.Text, Usertype);
                                db.sp_AdminTransactionAdd(username,action, txtUsername.Text, DateTime.Now);
                                Clear();
                                AdminID();
                            }
                            else if (rdoPersonnel.Checked)
                            {
                                Usertype = "Personnel";
                                action = "Registered a Personnel";
                                db.sp_AdminInsert(txtID.Text, txtUsername.Text, hash.HashPass(hashed, salt), txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, txtAddress.Text, txtContact.Text, gender, date, int.Parse(txtAge.Text), txtEmail.Text, cmbSecQuestion.Text, txtAnswer.Text, Usertype);
                                db.sp_AdminTransactionAdd(username, action, txtUsername.Text, DateTime.Now);
                                Clear();
                                PersonelID();
                            }
                            else if (rdoStudent.Checked)
                            {
                                Usertype = "Student";
                                action = "Registered a Student";
                                db.sp_UserInsert(txtID.Text, txtUsername.Text, hash.HashPass(hashed, salt), txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, txtAddress.Text, txtContact.Text, gender, date, int.Parse(txtAge.Text), cmbSection.Text, cmbGradeLevel.Text, txtEmail.Text, cmbSecQuestion.Text, txtAnswer.Text, Usertype);
                                db.sp_AdminTransactionAdd(username, action, txtUsername.Text, DateTime.Now);
                                Clear();
                                StudentID();
                            }
                            else if (rdoTeacher.Checked)
                            {
                                Usertype = "Teacher";
                                action = "Registered a Teacher";
                                db.sp_UserInsert(txtID.Text, txtUsername.Text, hash.HashPass(hashed, salt), txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, txtAddress.Text, txtContact.Text, gender, date, int.Parse(txtAge.Text), cmbSection.Text, cmbGradeLevel.Text, txtEmail.Text, cmbSecQuestion.Text, txtAnswer.Text, Usertype);
                                db.sp_AdminTransactionAdd(username, action, txtUsername.Text, DateTime.Now);
                                Clear();
                                TeacherID();
                            }
                        }
                        else
                        {
                            MessageBox.Show("That username has been already been taken please choose another one");
                            txtUsername.Text = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please type a valid email address");
                    }
                }
            }
        }
    }
}
