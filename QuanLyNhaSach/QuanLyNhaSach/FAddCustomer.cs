using QuanLyNhaSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FAddCustomer : Form
    {
        private static FAddCustomer instance;

        public static FAddCustomer Instance
        {
            get { if (instance == null) instance = new FAddCustomer(); return instance; }
            set => instance = value;
        }

        public FAddCustomer()
        {
            InitializeComponent();
        }
        #region Method
        public bool CheckIsMail(string email)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            return reg.IsMatch(email);
        }
        public bool CheckIsPhone(string phone)
        {
            if (phone.Length > 11 || phone.Length < 10)
            {
                return false;
            }
            Regex reg = new Regex("(\\+84|0)\\d{9,10}");
            return reg.IsMatch(phone);
        }

        public bool AddCustomer(string name, string address, string phonenumber, string email, float owe)
        {
            return CustomerDAO.Instance.AddCustomer(name, address, phonenumber, email, owe);
        }

        #endregion

        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }

        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(txbCustomerName.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng ");
                return;
            }
            if (txbPhoneNumber.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại của khách hàng ");
                return;
            }
            if (txbEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập email của khách hàng ");
                return;
            }
            if (txbCustomerAddress.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ của khách hàng ");
                return;
            }
            if (!CheckIsPhone(txbPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại không đúng đinh dạng");
                return;
            }
            if (!CheckIsMail(txbEmail.Text))
            {
                MessageBox.Show("Email không đúng đinh dạng");
                return;
            }
       

            string name = txbCustomerName.Text;
            string address = txbCustomerAddress.Text;
            string phonenumber = txbPhoneNumber.Text;
            string email = txbEmail.Text;
            float owe = 0.0f;
            if (AddCustomer(name, address, phonenumber, email, owe))
            {
                MessageBox.Show("Thêm khách hàng thành công !");
                if (updateForm != null)
                    updateForm(this, new EventArgs());
            }
            else
                MessageBox.Show("Thêm không thành công!");
        }
        #endregion
    }
}
