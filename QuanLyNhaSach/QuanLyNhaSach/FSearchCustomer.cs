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
    public partial class FSearchCustomer : Form
    {
        BindingSource customerList = new BindingSource();
        public FSearchCustomer()
        {
            InitializeComponent();
            LoadForm();
        }
        #region Medthod
        public void LoadForm()
        {
            dtgvManageCustomer.DataSource = customerList;
            LoadListCustomer();
            LoadListCustomerIntoCombobox();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageCustomer.Rows.Count; i++)
                {
                    dtgvManageCustomer.Rows[i].Cells["STT"].Value = i + 1;
                }
            };

            cbIDCustomer.Enabled = false;
            txbNameCustomer.Enabled = false;
            txbPhoneNumber.Enabled = false;
            txbEmail.Enabled = false;
            nmOweFrom.Enabled = false;
            nmOweTo.Enabled = false;
        }
        public void LoadListCustomer()
        {
            customerList.DataSource = CustomerDAO.Instance.GetListCustomer();
            LoadSTT();
        }
        public void LoadListCustomerIntoCombobox()
        {
            cbIDCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
            cbIDCustomer.DisplayMember = "id";
        }
        public void LoadSTT()
        {
            for (int i = 0; i < dtgvManageCustomer.Rows.Count; i++)
            {
                dtgvManageCustomer.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        public void Search()
        {
            customerList.DataSource = CustomerDAO.Instance.GetListCustomer();
            if(ckbIDCustomer.Checked==true)
            {
                for(int i=0;i<dtgvManageCustomer.RowCount;i++)
                {
                    if(Int32.Parse(dtgvManageCustomer.Rows[i].Cells["id"].Value.ToString())!=(cbIDCustomer.SelectedItem as Customer).ID)
                    {
                        dtgvManageCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if(ckbEmail.Checked==true)
            {
                for(int i=0;i<dtgvManageCustomer.RowCount;i++)
                {
                    if (dtgvManageCustomer.Rows[i].Cells["email"].Value.ToString() != (cbIDCustomer.SelectedItem as Customer).Email)
                    {
                        dtgvManageCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbNameCustomer.Checked==true)
            {
                List<Customer> list = CustomerDAO.Instance.SearchCustomerByName(txbNameCustomer.Text);
                for (int i = 0; i < dtgvManageCustomer.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvManageCustomer.Rows[i].Cells["name"].Value.ToString() == list[j].Name)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvManageCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbPhoneNumber.Checked == true)
            {
                for (int i = 0; i < dtgvManageCustomer.RowCount; i++)
                {
                    if (dtgvManageCustomer.Rows[i].Cells["phoneNumber"].Value.ToString() != txbPhoneNumber.Text)
                    {
                        dtgvManageCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbMoneyOwe.Checked == true)
            {
                for (int i = 0; i < dtgvManageCustomer.RowCount; i++)
                {
                    if ((float)Double.Parse(dtgvManageCustomer.Rows[i].Cells["owe"].Value.ToString()) < (int)nmOweFrom.Value ||
                        (float)Double.Parse(dtgvManageCustomer.Rows[i].Cells["owe"].Value.ToString()) > (int)nmOweTo.Value)
                    {
                        dtgvManageCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            LoadSTT();
        }
        #endregion

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
            Search();
        }

        private void btnHistoryBill_Click(object sender, EventArgs e)
        {
            if (dtgvManageCustomer.SelectedRows.Count == 0)
                return;
            Customer customer = CustomerDAO.Instance.GetCustomerByCustomerID(Int32.Parse(dtgvManageCustomer.SelectedRows[0].Cells["id"].Value.ToString()));
            FListBill f = new FListBill(customer);
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbIDCustomer_CheckedChanged(object sender, EventArgs e)
        {
            cbIDCustomer.Enabled = ckbIDCustomer.Checked == true;

            if (ckbIDCustomer.Checked == false)
                Search();
        }

        private void ckbNameCustomer_CheckedChanged(object sender, EventArgs e)
        {
            txbNameCustomer.Enabled = ckbNameCustomer.Checked == true;

            if (ckbNameCustomer.Checked == false)
                Search();
        }

        private void ckbPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            txbPhoneNumber.Enabled = ckbPhoneNumber.Checked == true;

            if (ckbPhoneNumber.Checked == false)
                Search();
        }

        private void ckbEmail_CheckedChanged(object sender, EventArgs e)
        {
            txbEmail.Enabled = ckbEmail.Checked == true;

            if (ckbEmail.Checked == false)
                Search();
        }

        private void ckbMoneyOwe_CheckedChanged(object sender, EventArgs e)
        {
            nmOweFrom.Enabled = ckbMoneyOwe.Checked == true;
            nmOweTo.Enabled = ckbMoneyOwe.Checked == true;

            if (ckbMoneyOwe.Checked == false)
                Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
