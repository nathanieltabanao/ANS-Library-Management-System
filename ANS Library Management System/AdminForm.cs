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
    public partial class AdminForm : Form
    {
        //Admin Form Initialization
        public AdminForm() => InitializeComponent();
        
        //Instantation of Needed Classes
        //Instance for Database
        DataClasses1DataContext db = new DataClasses1DataContext();

        //Instance for Encryption
        encryption_algorithm hash = new encryption_algorithm();
        
        //Variables
        //Necessary variables for system running
        //Username and Password passing between forms
        public string username { get; set; }
        public string password { get; set; }
        //variables that needed for the encryption of password
        string salt, hashed;


        //Method for Admin Form load
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        //Account registration Calling
        private void accountsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.username = username;
            register.MdiParent = this;
            register.Show();
        }

        //Book Inventory
        private void bookInventoryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //create instance
            BookInventory inv = new BookInventory();

            //passing details to forms
            inv.username = username;
            inv.password = password;

            inv.MdiParent = this;

            //showing instance
            inv.Show();
        }

        private void bookBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookBorrow b = new BookBorrow();
            b.MdiParent = this;
            b.Show();
        }

        private void bookReplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReplacement rep = new BookReplacement();
            rep.MdiParent = this;
            rep.Show();
        }

        //Logout Action Button
        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //data passing to varables
            salt = password;
            //hashing password
            hashed = hash.HashPass(password, salt);

            //new instance for login
            Login1 log = new Login1();
            this.Hide();
            log.Show();

            //log details for login details
            db.sp_LoginReport(username, username, null, hash.HashPass(hashed, salt), "Logout", DateTime.Now, "Admin");
        }
    }
}
