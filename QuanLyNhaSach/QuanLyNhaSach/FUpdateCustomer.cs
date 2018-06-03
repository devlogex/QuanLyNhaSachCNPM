using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
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
    public partial class FUpdateCustomer : Form
    {
        private Customer customer;
        public Customer Customer { get => customer; set => customer = value; }

        public FUpdateCustomer(Customer customer)
        {
            InitializeComponent();
            
            this.Customer = customer;
            LoadForm();
        }

        #region Method
        public void LoadForm()
        {
            txbCustomerName.Text = customer.Name;
            txbCustomerAddress.Text = customer.Address;
            txbPhoneNumber.Text = customer.Phonenumber;
            txbEmail.Text = customer.Email;
        }
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

        public bool UpdateCustomer(int id, string name, string address, string phonenumber, string email, float owe)
        {
            return CustomerDAO.Instance.UpdateCustomer(id, name, address, phonenumber, email, owe);
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

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCustomerName.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng ", "Thông báo");
                    return;
                }
                if (txbPhoneNumber.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại của khách hàng ", "Thông báo");
                    return;
                }
                if (txbEmail.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập email của khách hàng ", "Thông báo");
                    return;
                }
                if (txbCustomerAddress.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ của khách hàng ", "Thông báo");
                    return;
                }
                if (!CheckIsPhone(txbPhoneNumber.Text))
                {
                    MessageBox.Show("Số điện thoại không đúng đinh dạng", "Thông báo");
                    return;
                }
                if (!CheckIsMail(txbEmail.Text))
                {
                    MessageBox.Show("Email không đúng đinh dạng", "Thông báo");
                    return;
                }

                int id = Customer.ID;
                string name = txbCustomerName.Text;
                string address = txbCustomerAddress.Text;
                string phonenumber = txbPhoneNumber.Text;
                string email = txbEmail.Text;
                float owe = Customer.Owe;
                if (UpdateCustomer(id, name, address, phonenumber, email, owe))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công !", "Thông báo");
                    if (updateForm != null)
                        updateForm(this, new EventArgs());
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }
        #endregion
    }
}
