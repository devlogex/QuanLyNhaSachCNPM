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
    public partial class FUpdateAccount : Form
    {
        private Account acc;
        public Account Acc { get => acc; set => acc = value; }

        public FUpdateAccount(Account acc)
        {
            InitializeComponent();

            this.Acc = acc;
            LoadForm();
        }
        private event EventHandler updateListAccount;
        public event EventHandler UpdateListAccount
        {
            add { updateListAccount += value; }
            remove { updateListAccount -= value; }
        }

        public void LoadForm()
        {
            txbUserName.Text = Acc.UserName;
            txbPassWord.Text = Acc.PassWord;
            txbDisplayName.Text = Acc.DisplayName;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (txbPassWord.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !");
                return;
            }


            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            string displayName = txbDisplayName.Text;
            if (AccountDAO.Instance.UpdateAccountByUserName(userName, displayName, passWord))
            {
                MessageBox.Show("Cập nhật tài khoản thành công !");
                if (updateListAccount != null)
                    updateListAccount(this, new EventArgs());
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ ");
        }
    }
}
