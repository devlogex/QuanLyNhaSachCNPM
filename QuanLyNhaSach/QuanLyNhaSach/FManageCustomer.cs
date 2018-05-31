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
    public partial class FManageCustomer : Form
    {
        BindingSource customerList = new BindingSource();
        public FManageCustomer()
        {
            InitializeComponent();
            LoadForm();
        }
        #region Medthod
        public void LoadForm()
        {
            dtgvManageCustomer.DataSource = customerList;
            LoadListCustomer();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageCustomer.Rows.Count; i++)
                {
                    dtgvManageCustomer.Rows[i].Cells["STT"].Value = i + 1;
                }
            };
        }
        public void LoadListCustomer()
        {
            customerList.DataSource = CustomerDAO.Instance.GetListCustomer();
            for (int i = 0; i < dtgvManageCustomer.Rows.Count; i++)
            {
                dtgvManageCustomer.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        public bool RemoveCustomerByCustomerID(int id)
        {
            return CustomerDAO.Instance.RemoveCustomerByCustomerID(id);
        }
        #endregion
        #region Event
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FAddCustomer f = new FAddCustomer();
            f.UpdateForm += F_LoadAfterAdd;
            f.ShowDialog();
        }

        private void F_LoadAfterAdd(object sender, EventArgs e)
        {
            LoadListCustomer();
            for (int i = 0; i < dtgvManageCustomer.SelectedRows.Count; i++)
            {
                dtgvManageCustomer.SelectedRows[i].Selected = false;
            }
            dtgvManageCustomer.Rows[dtgvManageCustomer.Rows.Count - 1].Selected = true;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dtgvManageCustomer.SelectedCells.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sách để sửa");
                return;
            }

            Customer customer = CustomerDAO.Instance.GetCustomerByCustomerID((int)dtgvManageCustomer.SelectedRows[0].Cells["id"].Value);
            FUpdateCustomer f = new FUpdateCustomer(customer);
            f.UpdateForm += F_LoadAfterUpdate;
            f.ShowDialog();
        }

        private void F_LoadAfterUpdate(object sender, EventArgs e)
        {
            LoadListCustomer();

            for (int i = 0; i < dtgvManageCustomer.SelectedRows.Count; i++)
            {
                dtgvManageCustomer.SelectedRows[i].Selected = false;
            }

            Customer customer = (sender as FUpdateCustomer).Customer;
            int index = 0;
            while (Int32.Parse(dtgvManageCustomer.Rows[index].Cells["ID"].Value.ToString()) != customer.ID)
            {
                index++;
            }
            dtgvManageCustomer.Rows[index].Selected = true;
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dtgvManageCustomer.SelectedRows[0].Cells["id"].Value.ToString());
            try
            {
                RemoveCustomerByCustomerID(id);
                MessageBox.Show("Xóa khách hàng thành công !");
                LoadListCustomer();
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
        private void btnHistoryBill_Click(object sender, EventArgs e)
        {
            if (dtgvManageCustomer.SelectedRows.Count == 0)
                return;
            Customer customer = CustomerDAO.Instance.GetCustomerByCustomerID(Int32.Parse(dtgvManageCustomer.SelectedRows[0].Cells["id"].Value.ToString()));
            FListBill f = new FListBill(customer);
            f.ShowDialog();
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FSearchCustomer f = new FSearchCustomer();
            f.ShowDialog();
            this.LoadForm();
        }
    }
}
