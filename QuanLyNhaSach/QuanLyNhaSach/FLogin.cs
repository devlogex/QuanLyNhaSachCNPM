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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        #region Method
        public bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        #endregion

        #region Event
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {
                Account acc = AccountDAO.Instance.GetAccountByUserName(userName);
                FManager f = new FManager(acc);
                this.Hide();
                f.ShowDialog();
                try
                {
                    this.Show();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","Thông báo");
            }
        }
        #endregion
    }
}
