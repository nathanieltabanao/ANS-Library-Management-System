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

        int penalty, id;

        private void BookPenalty_Load(object sender, EventArgs e)
        {
            penalty = 5;
            View();
            Clear();
        }

        private void View()
        {
            dgvView.DataSource = db.sp_ViewTopay();
            dgvAccounting.DataSource = db.sp_ViewAccounting();
        }

        private void Clear()
        {
            penalty = 5;
            id = 0;
            txtChange.Text = null;
            txtName.Text = null;
            txtUsername.Text = null;
            btnConfirm.Enabled = false;
            btnClear.Enabled = false;
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvView_DoubleClick(object sender, EventArgs e)
        {
            txtUsername.Text = dgvView.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgvView.CurrentRow.Cells[4].Value.ToString() + ", " + dgvView.CurrentRow.Cells[2].Value.ToString() + " " + dgvView.CurrentRow.Cells[3].Value.ToString();
            dtpReturn.Value = DateTime.Parse(dgvView.CurrentRow.Cells[7].Value.ToString());
            dtpActual.Value = DateTime.Parse(dgvView.CurrentRow.Cells[8].Value.ToString());

            double days = (dtpActual.Value-dtpReturn.Value).TotalDays;

            id = int.Parse(dgvView.CurrentRow.Cells[0].Value.ToString());



            numDue.Value = decimal.Parse((penalty * days).ToString());
            btnConfirm.Enabled = true;
            btnClear.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvView.DataSource = db.sp_SearchAccountingNotPaid(txtSearch.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnClear.Enabled = false;
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
                db.sp_BookDuePaid(id, "y");
                View();
                btnConfirm.Enabled = false;
            }
        }
    }
}
