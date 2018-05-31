﻿using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
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
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageBookTitle.Rows.Count; i++)
                {
                    dtgvManageBookTitle.Rows[i].Cells["STT"].Value = i + 1;
                }
            };
        }
        public void LoadListBookTitle()
        {
            dtgvManageBookTitle.DataSource = BookTitleDAO.Instance.LoadListBookTitle();
            for (int i = 0; i < dtgvManageBookTitle.Rows.Count; i++)
            {
                dtgvManageBookTitle.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        public bool RemoveBookTitleByBookTitleID(int id)
        {
            return BookTitleDAO.Instance.RemoveBookTitleByBookTitleID(id);
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

        private void btnUpdateBookTitle_Click(object sender, EventArgs e)
        {
            if (dtgvManageBookTitle.SelectedCells.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn đầu sách để sửa");
                return;
            }

            BookTitle bookTitle = BookTitleDAO.Instance.GetBookTitleByBookTitleID(Int32.Parse(dtgvManageBookTitle.SelectedRows[0].Cells["id"].Value.ToString()));
            FUpdateBookTitle f = new FUpdateBookTitle(bookTitle);
            f.UpdateForm += F_LoadListBookTitleAfterUpdate;
            f.ShowDialog();
        }

        private void F_LoadListBookTitleAfterUpdate(object sender, EventArgs e)
        {
            LoadListBookTitle();

            for (int i = 0; i < dtgvManageBookTitle.SelectedRows.Count; i++)
            {
                dtgvManageBookTitle.SelectedRows[i].Selected = false;
            }

            BookTitle bookTitle = (sender as FUpdateBookTitle).BookTitle;
            int index = 0;
            while (Int32.Parse(dtgvManageBookTitle.Rows[index].Cells["id"].Value.ToString()) != bookTitle.ID)
            {
                index++;
            }
            dtgvManageBookTitle.Rows[index].Selected = true;
        }

        private void btnRemoveBookTitle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvManageBookTitle.SelectedCells.Count > 0)
                {
                    int id = Int32.Parse(dtgvManageBookTitle.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                    if (RemoveBookTitleByBookTitleID(id))
                    {
                        MessageBox.Show("Đã xóa thành công !");
                        LoadListBookTitle();
                    }
                    else
                        MessageBox.Show("Xóa không thành công !");

                }
                else
                    MessageBox.Show("Bạn chưa chọn đầu sách ! ");
            }
            catch { MessageBox.Show("Xóa không thành công !"); }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            FSearchBook f = new FSearchBook();
            f.ShowDialog();
            this.LoadForm();
        }
    }
}
