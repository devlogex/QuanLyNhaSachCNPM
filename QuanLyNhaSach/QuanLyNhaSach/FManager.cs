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

        }
    }
}
