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
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        public string username;
        public string user;
        public string name;
        public string usertype;


        DataClasses1DataContext db = new DataClasses1DataContext();

        private new void Show()
        {
            dtpSearch.DataSource = db.sp_UserView();
        }

        private void SearchUser_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void dtpSearch_DoubleClick(object sender, EventArgs e)
        {
            user = dtpSearch.CurrentRow.Cells[2].Value.ToString();
            name = dtpSearch.CurrentRow.Cells[6].Value.ToString() + ", " + dtpSearch.CurrentRow.Cells[4].Value.ToString() + " " + dtpSearch.CurrentRow.Cells[5].Value.ToString();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtpSearch.DataSource = db.sp_UserSearch(txtSearch.Text);
        }

        private void SearchUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
