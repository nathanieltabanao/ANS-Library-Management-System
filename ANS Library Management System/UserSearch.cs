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
    public partial class UserSearch : Form
    {
        public UserSearch()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        public string username;
        public string user;
        public string name;

        public void Show()
        {
            dataGridView1.DataSource = db.sp_UserView();
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sp_UserSearch(txtSearch.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            user = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            name = dataGridView1.CurrentRow.Cells[6].Value.ToString() + ", " + dataGridView1.CurrentRow.Cells[4].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.Close();
        }

        private void UserSearch_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
