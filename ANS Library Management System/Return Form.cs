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
    public partial class Return_Form : Form
    {
        public Return_Form()
        {
            InitializeComponent();
        }

        public string username { get; set; }
        public string user { get; set; }
        public string usertype { get; set; }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Return_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
