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
    public partial class Top_Borrowed_Books_Viewer : Form
    {
        public Top_Borrowed_Books_Viewer()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Top_Borrowed_Books tbb = new Top_Borrowed_Books();
            crystalReportViewer1.ReportSource = tbb;
        }
    }
}
