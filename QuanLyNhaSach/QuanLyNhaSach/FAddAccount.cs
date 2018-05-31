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
    public partial class FAddAccount : Form
    {
        public FAddAccount()
        {
            InitializeComponent();
        }
        private event EventHandler updateListAccount;
        public event EventHandler UpdateListAccount
        {
            add { updateListAccount += value; }
            remove { updateListAccount -= value; }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (errorProviderAccount.GetError(txbUserName) != "")
            {
                MessageBox.Show("Lỗi tên đăng nhập !");
                return;
            }
            if (txbUserName.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập !");
                return;
            }
            if(txbPassWord.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !");
                return;
            }
           

            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            string displayName = txbDisplayName.Text;
            try
            {
                if (AccountDAO.Instance.InsertAccount(userName, displayName, passWord))
                {
                    MessageBox.Show("Thêm tài khoản thành công !");
                    if (updateListAccount != null)
                        updateListAccount(this, new EventArgs());
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ ");
            }
            catch { MessageBox.Show("Lỗi tài khoản mới thêm đã có ");}
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Account acc = AccountDAO.Instance.GetAccountByUserName(txbUserName.Text);
                errorProviderAccount.SetError(txbUserName, "Tên đăng nhập đã tồn tài");
            }
            catch
            {
                errorProviderAccount.SetError(txbUserName, "");
            }
        }
    }
}
