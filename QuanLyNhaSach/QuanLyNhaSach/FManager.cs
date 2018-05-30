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
            itemDisplayName.Text = this.Acc.DisplayName;
        }

        private void lbManageCategoryAndAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FManageCategoryAndAuthor f = new FManageCategoryAndAuthor();
            f.ShowDialog();
        }

        private void lbManageBookTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FManageBookTitle f = new FManageBookTitle();
            f.ShowDialog();
        }

        private void lbManageCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FManageCustomer f = new FManageCustomer();
            f.ShowDialog();
        }

        private void lbImportBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FImportBook f = new FImportBook();
            f.ShowDialog();
        }

        private void lbBill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FBill f = new FBill();
            f.ShowDialog();
        }

        private void lbCollectMoney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FReceipt f = new FReceipt();
            f.ShowDialog();
        }

        private void lbReportCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FReportBook f = new FReportBook();
            f.ShowDialog();
        }

        private void lbReportOwe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FReportOwe f = new FReportOwe();
            f.ShowDialog();
        }

        private void itemLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSystem f = new FSystem();
            f.ShowDialog();
        }
    }
}
