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
    public partial class BookBorrow : Form
    {
        public BookBorrow()
        {
            InitializeComponent();
        }

        public string username { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }

        private void BookBorrow_Load(object sender, EventArgs e)
        {

        }
    }
}
