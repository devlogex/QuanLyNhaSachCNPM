using iTextSharp.text;
using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FReceipt : Form
    {
        private bool check;
        public FReceipt()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            txbIDReceipt.Text = CollectMoneyDAO.Instance.GetNewID().ToString();
            LoadCustomerIntoCombobox();
            cbCustomer.SelectedIndex = -1;
            cbCustomer.SelectedIndexChanged += cbCustomer_SelectedIndexChanged;
            check = ThamSoDAO.Instance.GetCheck();
            if (check)
            {
                lb.Visible = true;
            }
            else
                lb.Visible = false;
        }
        public void LoadCustomerIntoCombobox()
        {
            cbCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
            cbCustomer.DisplayMember = "id";
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCustomer.SelectedItem != null)
                {
                    Customer customer = cbCustomer.SelectedItem as Customer;
                    txbCustomerName.Text = customer.Name;
                    txbAddress.Text = customer.Address;
                    txbEmail.Text = customer.Email;
                    txbMoneyOwe.Text = customer.Owe.ToString();
                    txbPhoneNumber.Text = customer.Phonenumber.ToString();
                }
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Tag != null)
                {
                    MessageBox.Show("Bạn phải tạo phiếu thu mới trước !", "Thông báo");
                    return;
                }
                Customer customer = cbCustomer.SelectedItem as Customer;
                double moneyCollect;
                if (!Double.TryParse(txbReceiveMoney.Text, out moneyCollect))
                {
                    MessageBox.Show("Số tiền nhập không đúng đinh dạng !", "Thông báo");
                    txbReceiveMoney.Text = "";
                    return;
                }
                if (moneyCollect > customer.Owe && check)
                {
                    MessageBox.Show("Số tiền thu không được vượt quá số tiền khách hàng đang nợ !", "Thông báo");
                    txbReceiveMoney.Text = "";
                    return;
                }
                if (CollectMoneyDAO.Instance.SaveCollectMoney(customer.ID, dtpk.Value, (float)moneyCollect))
                {
                    MessageBox.Show("Lưu thành công !", "Thông báo");
                    btnSave.Tag = 1;
                }
                else
                    MessageBox.Show("Lưu thất bại !", "Thông báo");
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                LoadForm();
                btnSave.Tag = null;
                cbCustomer.SelectedIndex = -1;
                txbCustomerName.Text = "";
                txbAddress.Text = "";
                txbEmail.Text = "";
                txbMoneyOwe.Text = "";
                txbPhoneNumber.Text = "";
                txbReceiveMoney.Text = "";
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (btnSave.Tag == null)
            {
                MessageBox.Show("Bạn phải lưu phiếu nhập trước !", "Thông báo");
                return;
            }

            string name = "PHIEUNHAPSACH" + txbIDReceipt.Text.ToString() + ".pdf";
            try
            {
                List<Phrase> data = new List<Phrase>()
                {
                    ExportDataToPDF.Instance.GetPhraseHeader("PHIẾU THU TIỀN\n"),
                    ExportDataToPDF.Instance.GetPhrase("Số phiếu thu: "+txbIDReceipt.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Ngày lập: "+ dtpk.Value.ToString()+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Mã khách hàng: "+(cbCustomer.SelectedItem as Customer).ID.ToString()+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Họ tên khách hàng: "+txbCustomerName.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Địa chỉ: "+txbAddress.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Số điện thoại: "+txbPhoneNumber.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Email: "+txbEmail.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Số tiền nợ: "+txbMoneyOwe.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Số tiền thu: "+txbReceiveMoney.Text+'\n')
                };
                string path=ExportDataToPDF.Instance.ExportDataToPdf(name, data);
                if (path != "")
                {
                    if (MessageBox.Show("In thành công ! Bạn có muốn mở file ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Process.Start(path);
                }
                else
                {
                    MessageBox.Show("In thất bại !", "Thông báo");
                }
            }
            catch { MessageBox.Show("In thất bại ", "Thông báo"); }
        }
    }
}
