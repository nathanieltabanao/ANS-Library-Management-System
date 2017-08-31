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
        public AdminForm() => InitializeComponent();

        DataClasses1DataContext db = new DataClasses1DataContext();
        encryption_algorithm hash = new encryption_algorithm();
        clsMiddleClass m = new clsMiddleClass();
        public string username { get; set; }
        public string password { get; set; }

        string salt, hashed;
        
        

        private void accountsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.MdiParent = this;
            register.Show();
        }

        private void bookInventoryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BookInventory inv = new BookInventory();
            inv.MdiParent = this;
            inv.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            salt = password;
            hashed = hash.HashPass(password, salt);
            Login1 log = new Login1();
            this.Hide();
            log.Show();
            db.sp_LoginReport(username, hash.HashPass(hashed, salt), "Logout", DateTime.Now, "Admin");
        }
    }
}
