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
    public partial class FManager : Form
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }
        public FManager(Account acc)
        {
        InitializeComponent();

            this.Acc = acc;
            LoadForm();
        }
        public void LoadForm()
        {
            if (this.Acc.DisplayName != "")
                itemDisplayName.Text = this.Acc.DisplayName;
            else
                itemDisplayName.Text = this.Acc.UserName;

            if (this.Acc.Type == 1)
                msAccount.Items.Remove(itemAdmin);
        }

        private void lbManageCategoryAndAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FManageCategoryAndAuthor f = new FManageCategoryAndAuthor();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void lbManageBookTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FManageBookTitle f = new FManageBookTitle();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void lbManageCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FManageCustomer f = new FManageCustomer();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void lbImportBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FImportBook f = new FImportBook();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void lbBill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FBill f = new FBill();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void lbCollectMoney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FReceipt f = new FReceipt();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void lbReportCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FReportBook f = new FReportBook();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void lbReportOwe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FReportOwe f = new FReportOwe();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void itemLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FSystem f = new FSystem();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void lbSearchBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FSearchBook f = new FSearchBook();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void lbSearchCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FSearchCustomer f = new FSearchCustomer();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void itemAccount_Click(object sender, EventArgs e)
        {
            try
            {
                FUpdateAccount f = new FUpdateAccount(this.Acc);
                f.UpdateListAccount += delegate (object _sender, EventArgs _e)
                  {
                      this.Acc = AccountDAO.Instance.GetAccountByUserName(this.Acc.UserName);
                      if (this.Acc.DisplayName != "")
                          itemDisplayName.Text = this.Acc.DisplayName;
                      else
                          itemDisplayName.Text = this.Acc.UserName;
                  };
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void itemAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                FAccount f = new FAccount();
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }
    }
}
