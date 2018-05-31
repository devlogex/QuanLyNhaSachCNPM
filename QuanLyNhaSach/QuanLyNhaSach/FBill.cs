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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FBill : Form
    {
        private float percentPrice;
        private float maxOwe;
        private float minCount;
        public FBill()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            dtpk.Value = DateTime.Now;

            percentPrice = ThamSoDAO.Instance.GetPercentPrice();
            maxOwe = ThamSoDAO.Instance.GetMaxOwe();
            minCount = ThamSoDAO.Instance.GetMinCount();
            lb.Text = "*Chỉ bán cho các khác hàng nợ không quá "+ maxOwe.ToString() +" và đầu sách có lượng tồn sau khi bán ít nhất là "+minCount.ToString();
            txbIdBill.Text = BillDAO.Instance.GetNewIDBill().ToString();
            dtpk.Value = DateTime.Now;
            txbReceiveMoney.Text = "0";
            txbTotalMoney.Text = "0";
            txbMoneyOwe.Text = "0";
            txbReceiveMoney.TextChanged += txbReciveMoney_TextChanged;
            LoadSTT();
            LoadListBookIntoCombobox();
            LoadListCustomerIntoCombobox();
            cbIdCustomer.SelectedIndexChanged += cbIdCustomer_SelectedIndexChanged;

            txbIdCustomer.Text = CustomerDAO.Instance.GetNewIDCustomer().ToString();

        }

        private void LoadListCustomerIntoCombobox()
        {
            cbIdCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
            cbIdCustomer.DisplayMember = "id";
        }

        public void LoadListBookIntoCombobox()
        {
            id.DataSource = BookDAO.Instance.GetListBook();
            id.DisplayMember = "id";
        }
        public void LoadSTT()
        {
            for (int i = 0; i < dtgvBill.RowCount; i++)
                dtgvBill.Rows[i].Cells["STT"].Value = i + 1;
        }




        //#region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtgvBill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (cbm != null)
            {
                cbm.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
            }
            try
            {
                List<Book> listBook = BookDAO.Instance.GetListBook();
                Book book = null;
                foreach (Book item in listBook)
                {
                    if (item.ID == Int32.Parse(dtgvBill.Rows[e.RowIndex].Cells["id"].Value.ToString()))
                    {
                        book = item;
                        break;
                    }
                }

                for (int i=0;i<dtgvBill.RowCount-1;i++)
                {
                    if(i!=e.RowIndex && book.ID==Int32.Parse(dtgvBill.Rows[i].Cells["id"].Value.ToString()))
                    {
                        dtgvBill.Rows[i].Cells["count"].Selected = true;
                        dtgvBill.Rows.RemoveAt(e.RowIndex);
                        return;
                    }
                }

                if (dtgvBill.Rows[e.RowIndex].Cells["count"].Value != null)
                {
                    
                    if ((book.Count - Int64.Parse(dtgvBill.Rows[e.RowIndex].Cells["count"].Value.ToString())) < 0)
                    {
                        MessageBox.Show("Số lượng sách không đủ. Sách " + book.Name + " hiện tại chỉ còn " + book.Count.ToString());
                        dtgvBill.Rows[e.RowIndex].Cells["count"].Value = null;
                        return;
                    }
                    if ((book.Count - Int64.Parse(dtgvBill.Rows[e.RowIndex].Cells["count"].Value.ToString())) < minCount)
                    {
                        MessageBox.Show("Số lượng sách sau khi bán phải nhỏ hơn "+minCount.ToString()+" . Sách " + book.Name + " hiện tại chỉ còn " + book.Count.ToString());
                        dtgvBill.Rows[e.RowIndex].Cells["count"].Value = null;
                        return;
                    }

                    int countBookTitle = 0;
                    foreach (DataRow row in BookTitleDAO.Instance.LoadListBookTitle().Rows)
                    {
                        if ((Int32.Parse(row["id"].ToString())) == book.IdBookTitle)
                        {
                            countBookTitle = Int32.Parse(row["totalCount"].ToString());
                            break;
                        }
                    }
                    if (countBookTitle - Int64.Parse(dtgvBill.Rows[e.RowIndex].Cells["count"].Value.ToString()) < minCount)
                    {
                        MessageBox.Show("Đầu sách có lượng tồn sau khi bán ít nhất là " + minCount.ToString() + "\nĐầu sách " + book.Name + " có lượng tồn là " + countBookTitle.ToString());
                        dtgvBill.Rows[e.RowIndex].Cells["count"].Value = null;
                        return;
                    }

                }

                if (dtgvBill.Rows[e.RowIndex].Cells["count"].Value != null)
                {
                    dtgvBill.Rows[e.RowIndex].Cells["totalPrice"].Value = Double.Parse(dtgvBill.Rows[e.RowIndex].Cells["priceOut"].Value.ToString()) * Int64.Parse(dtgvBill.Rows[e.RowIndex].Cells["count"].Value.ToString());
                }
            }
            catch
            {
                dtgvBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                MessageBox.Show("Lỗi dữ liệu nhập không đúng định dạng !");
            }

            double totalMoney = 0.0;
            foreach (DataGridViewRow item in dtgvBill.Rows)
            {
                if (item.Cells["totalPrice"].Value != null)
                    totalMoney += Double.Parse(item.Cells["totalPrice"].Value.ToString());
            }
            txbTotalMoney.Text = totalMoney.ToString();
            
        }
        ComboBox cbm;
        DataGridViewCell currentCell;
        private void dtgvBill_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                cbm = (ComboBox)e.Control;
                if (cbm != null)
                {
                    cbm.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
                }
                currentCell = this.dtgvBill.CurrentCell;
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(EndEdit));
        }
        void EndEdit()
        {
            if (cbm != null)
            {
                if (cbm.SelectedIndex == -1)
                    return;
                Book book = cbm.SelectedItem as Book;
                
                if (book != null)
                {
                    dtgvBill.SelectedCells[0].OwningRow.Cells["name"].Value = book.Name;
                    string authors = "";
                    for (int i = 0; i < book.Authors.Count - 1; i++)
                    {
                        authors += book.Authors[i].Name + ", ";
                    }
                    if (book.Authors.Count > 0)
                        authors += book.Authors[book.Authors.Count - 1].Name;
                    dtgvBill.SelectedCells[0].OwningRow.Cells["author"].Value = authors;
                    dtgvBill.SelectedCells[0].OwningRow.Cells["category"].Value = book.Category.Name;
                    dtgvBill.SelectedCells[0].OwningRow.Cells["publishing"].Value = "Nhà xuất bản " + book.PublishCompany + ", năm " + book.PublishYear;
                    dtgvBill.SelectedCells[0].OwningRow.Cells["priceOut"].Value = (book.PriceIn*percentPrice).ToString();

                    this.dtgvBill.EndEdit();
                }
            }
        }
        private void dtgvBill_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtgvBill.Rows[dtgvBill.RowCount - 1].Cells["STT"].Value = dtgvBill.RowCount;
        }
        private void dtgvBill_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            LoadSTT();
        }

        private void txbReciveMoney_TextChanged(object sender, EventArgs e)
        {
            if (txbReceiveMoney.Text == "")
                txbReceiveMoney.Text = "0";
            txbMoneyOwe.Text = (Double.Parse(txbTotalMoney.Text) - Double.Parse(txbReceiveMoney.Text)).ToString();
        }
        private void txbTotalMoney_TextChanged(object sender, EventArgs e)
        {
            txbMoneyOwe.Text = (Double.Parse(txbTotalMoney.Text) - Double.Parse(txbReceiveMoney.Text)).ToString();
        }
     

        private void F_LoadListCustomerAfterAdd(object sender, EventArgs e)
        {
            LoadListCustomerIntoCombobox();
        }
        private void cbIdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = cbIdCustomer.SelectedItem as Customer;
            if(customer.Owe >maxOwe)
            {
                MessageBox.Show("Khách hàng nợ quá quy định !");
                cbIdCustomer.SelectedIndex = -1;
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Tag != null)
                if (Int32.Parse(btnSave.Tag.ToString()) == 1)
                {
                    MessageBox.Show("Bạn chưa tạo hóa đơn mới !");
                    return;
                }
            if(cbIdCustomer.SelectedItem==null)
            {
                MessageBox.Show("Bạn chưa nhập khách hàng !");
                return;
            }
            if(dtgvBill.RowCount==1)
            {
                MessageBox.Show("Bạn chưa nhập sách !");
                return;
            }
            for(int i=0;i<dtgvBill.RowCount-1;i++)
            {
                if(dtgvBill.Rows[i].Cells["totalPrice"].Value==null)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng của sách !");
                    dtgvBill.Rows[i].Cells["count"].Selected = true;
                    return;
                }
            }
            if(((cbIdCustomer.SelectedItem as Customer).Owe+Double.Parse(txbMoneyOwe.Text))>maxOwe)
            {
                MessageBox.Show("Nợ cũ và nợ lần này của khách hàng vượt quá quy định !");
                return;
            }

            Customer customer = cbIdCustomer.SelectedItem as Customer;
            DateTime date = dtpk.Value;
            float totalMoney = (float)Double.Parse(txbTotalMoney.Text);
            float receiveMoney = (float)Double.Parse(txbReceiveMoney.Text);
            float moneyOwe = (float)Double.Parse(txbMoneyOwe.Text);

            if (!BillDAO.Instance.InsertBill(customer,date,totalMoney,receiveMoney,moneyOwe))
            {
                MessageBox.Show("Thêm hóa đơn thất bại !");
                return;
            }
            for(int i=0;i<dtgvBill.RowCount-1;i++)
            {
                int idBook = Int32.Parse(dtgvBill.Rows[i].Cells["id"].Value.ToString());
                int count= Int32.Parse(dtgvBill.Rows[i].Cells["count"].Value.ToString());
                float priceOut= (float)Double.Parse(dtgvBill.Rows[i].Cells["priceOut"].Value.ToString());
                float totalPrice = (float)Double.Parse(dtgvBill.Rows[i].Cells["totalPrice"].Value.ToString());
                if (!BillInfoDAO.Instance.InsertBillInfo(idBook,count,priceOut,totalPrice))
                {
                    MessageBox.Show("Thêm hóa đơn thất bại !");
                    return;
                }
            }
            MessageBox.Show("Thêm hóa đơn thành công !");
            btnSave.Tag = 1;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            txbIdBill.Text = BillDAO.Instance.GetNewIDBill().ToString();
            for (int i = 0; i < dtgvBill.RowCount - 1; i++)
                dtgvBill.Rows.RemoveAt(0);
            txbReceiveMoney.Text = "0";
            txbTotalMoney.Text = "0";
            txbMoneyOwe.Text = "0";
            btnSave.Tag = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (btnSave.Tag == null)
            {
                MessageBox.Show("Bạn phải lưu phiếu nhập trước !");
                return;
            }

            string name = "HOADON" + txbIdBill.Text.ToString() + ".pdf";
            try
            {
                List<Phrase> data = new List<Phrase>()
                {
                    ExportDataToPDF.Instance.GetPhraseHeader("HÓA ĐƠN BÁN SÁCH\n"),
                    ExportDataToPDF.Instance.GetPhrase("Số hóa đơn: "),
                    ExportDataToPDF.Instance.GetPhrase(txbIdBill.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Khách hàng: "+(cbIdCustomer.SelectedItem as Customer).Name + "     Mã khách hàng: "+(cbIdCustomer.SelectedItem as Customer).ID.ToString()+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Ngày lập: "+ dtpk.Value.ToString()+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Tổng tiền: "+txbTotalMoney.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Số tiền trả: "+txbReceiveMoney.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Còn lại: "+txbMoneyOwe.Text+'\n')

                };
                ExportDataToPDF.Instance.ExportDataToPdf(name, data, ExportDataToPDF.Instance.GetTable(dtgvBill));
                if (MessageBox.Show("In thành công ! Bạn có muốn mở file ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Process.Start( name);
            }
            catch { MessageBox.Show("In thất bại "); }
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

        public bool AddCustomer(string name, string address, string phonenumber, string email, float owe)
        {
            return CustomerDAO.Instance.AddCustomer(name, address, phonenumber, email, owe);
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txbCustomerName.Text == "")
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
                LoadListCustomerIntoCombobox();
                txbIdCustomer.Text = CustomerDAO.Instance.GetNewIDCustomer().ToString();
            }
            else
                MessageBox.Show("Thêm không thành công!");
        }
    }
}
