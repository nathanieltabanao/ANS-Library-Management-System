﻿using System;
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
    public partial class PersonnelForm : Form
    {
        public PersonnelForm() => InitializeComponent();

        encryption_algorithm hash = new encryption_algorithm();
        DataClasses1DataContext db = new DataClasses1DataContext();

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
            db.sp_LoginReport(username, hash.HashPass(hashed, salt), "Logout", DateTime.Now, "Personnel");
        }

        private void PersonnelForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
