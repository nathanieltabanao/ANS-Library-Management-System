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
    public partial class Crystal_Report : Form
    {
        public Crystal_Report()
        {
            InitializeComponent();
        }

        private void Crystal_Report_Load(object sender, EventArgs e)
        {
            CrystalReport1 crpt = new CrystalReport1();
            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
