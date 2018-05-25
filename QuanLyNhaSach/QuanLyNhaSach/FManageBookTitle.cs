using QuanLyNhaSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FManageBookTitle : Form
    {
        public FManageBookTitle()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            LoadListBookTitle();
        }
        public void LoadListBookTitle()
        {
            dtgvManageBookTitle.DataSource = BookTitleDAO.Instance.LoadListBookTitle();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBookTitle_Click(object sender, EventArgs e)
        {
            FAddBookTitle f = new FAddBookTitle();
            f.UpdateForm += F_LoadListBookTitleAfterAdd;
            f.ShowDialog();
        }

        private void F_LoadListBookTitleAfterAdd(object sender, EventArgs e)
        {
            LoadListBookTitle();

            for (int i = 0; i < dtgvManageBookTitle.SelectedRows.Count; i++)
            {
                dtgvManageBookTitle.SelectedRows[i].Selected = false;
            }
            dtgvManageBookTitle.Rows[dtgvManageBookTitle.Rows.Count - 1].Selected = true;


        }
    }
}
