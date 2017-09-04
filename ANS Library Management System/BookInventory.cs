﻿using System;
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
    public partial class BookInventory : Form
    {
        public BookInventory()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        encryption_algorithm hash = new encryption_algorithm();

        public string username { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }

        //view shit
        public void BookView()
        {
            dgvBooks.DataSource = db.sp_BookView();
        }

        public void Clear()
        {
            txtauthor.Text = null;
            txtISBN.Text = null;
            txtpublisher.Text = null;
            txtTitle.Text = null;
            cmbCategory.Text = null;
            cmbFoS.Text = null;

        }

        public int ID()
        {
            return Convert.ToInt32(db.sp_BookID());
        }

        public void BookID()
        {
            txtBookID.Text = ID().ToString();
        }

        private void BookInventory_Load(object sender, EventArgs e)
        {
            BookView();
            BookID();
            lblAttendant.Text = "Current Attendant: " + username;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.sp_BookSearch(txtSearch.Text);
            BookID();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtauthor.Text)|| string.IsNullOrWhiteSpace(txtISBN.Text)|| string.IsNullOrWhiteSpace(txtpublisher.Text)||
                string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                db.sp_BookAdd(txtISBN.Text, txtTitle.Text, txtauthor.Text,  dtpPublishDate.Value, cmbFoS.Text, cmbCategory.Text, txtpublisher.Text);
                BookView();
                Clear();
                BookID();
            }
        }

        private void lblAttendant_Click(object sender, EventArgs e)
        {

        }

        private void dgvBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookID.Text = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            txtISBN.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            txtTitle.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            txtauthor.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
            //dtpPublishDate.Value = DateTime.Parse( dgvBooks.CurrentRow.Cells[4].Value.ToString);
            cmbFoS.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
            cmbCategory.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
            txtpublisher.Text = dgvBooks.CurrentRow.Cells[7].Value.ToString();
            btnAdd.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
