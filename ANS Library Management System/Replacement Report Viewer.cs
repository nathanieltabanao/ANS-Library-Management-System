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
    public partial class Replacement_Report_Viewer : Form
    {
        public Replacement_Report_Viewer()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Replacement_Report rr = new Replacement_Report();
            crystalReportViewer1.ReportSource = rr;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            Replacement_Report rr = new Replacement_Report();
            crystalReportViewer2.ReportSource = rr;
        }
    }
}
