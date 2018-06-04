using QuanLyNhaSach.DAO;
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
    public partial class FAccount : Form
    {
        public FAccount()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            LoadAccount();
            this.Load += delegate (object sender, EventArgs e)
            {
                for (int i = 0; i < dtgvAccount.RowCount; i++)
                    dtgvAccount.Rows[i].Cells["STT"].Value = i + 1;
            };

            dtgvAccount.Sorted += delegate (object _sender, EventArgs _e)
            {
                for (int i = 0; i < dtgvAccount.RowCount; i++)
                    dtgvAccount.Rows[i].Cells["STT"].Value = i + 1;
            };
        }


        public void LoadAccount()
        {
            dtgvAccount.DataSource = AccountDAO.Instance.GetListAccount();
            for (int i = 0; i < dtgvAccount.RowCount; i++)
                dtgvAccount.Rows[i].Cells["STT"].Value = i + 1;
        }
        private void F_UpdateListAccount(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                FAddAccount f = new FAddAccount();
                f.UpdateListAccount += F_UpdateListAccount;
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvAccount.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn tài khoản để sửa", "Thông báo");
                    return;
                }
                Account acc = AccountDAO.Instance.GetAccountByUserName(dtgvAccount.SelectedRows[0].Cells["userName"].Value.ToString());
                FUpdateAccount f = new FUpdateAccount(acc);
                f.UpdateListAccount += F_UpdateListAccount;
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = dtgvAccount.SelectedCells[0].OwningRow.Cells["userName"].Value.ToString();
                Account acc = AccountDAO.Instance.GetAccountByUserName(userName);
                if (AccountDAO.Instance.RemoveAccountByUserName(userName))
                {
                    MessageBox.Show("Xóa tài khoản thành công !","Thông báo");
                    LoadAccount();
                }
                else
                    MessageBox.Show("Xóa không thành công ","Thông báo");
            }
            catch { MessageBox.Show("Có lỗi khi xóa","Thông báo"); }
        }
    }
}
