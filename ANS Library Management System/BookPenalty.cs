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
    public partial class BookPenalty : Form
    {
        public BookPenalty()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        public string username { get; set; }

        int penalty;

        private void BookPenalty_Load(object sender, EventArgs e)
        {
            penalty = 5;
            View();
        }

        private void View()
        {
            dgvView.DataSource = db.sp_ViewTopay();
            dgvAccounting.DataSource = db.sp_ViewAccounting();
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvView_DoubleClick(object sender, EventArgs e)
        {
            txtUsername.Text = dgvView.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvView.CurrentRow.Cells[3].Value.ToString() + ", " + dgvView.CurrentRow.Cells[1].Value.ToString() + " " + dgvView.CurrentRow.Cells[2].Value.ToString();
            dtpReturn.Value = DateTime.Parse(dgvView.CurrentRow.Cells[6].Value.ToString());
            dtpActual.Value = DateTime.Parse(dgvView.CurrentRow.Cells[7].Value.ToString());

            int days = dtpReturn.Value.Day - dtpActual.Value.Day;

            numDue.Value = decimal.Parse((penalty*days).ToString());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (numCash.Value<numDue.Value)
            {
                MessageBox.Show("Insufficient Cash");
            }
            else
            {
                txtChange.Text = (numCash.Value - numDue.Value).ToString();
                db.sp_BookPayDue(DateTime.Now, username, txtUsername.Text, txtName.Text, numDue.Value, numCash.Value, decimal.Parse(txtChange.Text));
                
            }
        }
    }
}
