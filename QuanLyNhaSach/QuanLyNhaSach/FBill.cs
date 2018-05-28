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
            txbReciveMoney.Text = "0";
            txbTotalMoney.Text = "0";
            txbMoneyOwe.Text = "0";
            txbReciveMoney.TextChanged += txbReciveMoney_TextChanged;
            LoadSTT();
            LoadListBookIntoCombobox();
            LoadListCustomerIntoCombobox();
            cbIdCustomer.SelectedIndexChanged += cbIdCustomer_SelectedIndexChanged;
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
                if (dtgvBill.Rows[e.RowIndex].Cells["count"].Value != null)
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
                    if ((book.Count - Int64.Parse(dtgvBill.Rows[e.RowIndex].Cells["count"].Value.ToString())) < 0)
                    {
                        MessageBox.Show("Số lượng sách không đủ. Sách " + book.Name + " hiện tại chỉ còn " + book.Count.ToString());
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
            catch { MessageBox.Show("Lỗi dữ liệu nhập không đúng định dạng !"); }

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
            if (txbReciveMoney.Text == "")
                txbReciveMoney.Text = "0";
            txbMoneyOwe.Text = (Double.Parse(txbTotalMoney.Text) - Double.Parse(txbReciveMoney.Text)).ToString();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FAddCustomer f = new FAddCustomer();
            f.UpdateForm += F_LoadListCustomerAfterAdd;
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

        }

       
    }
}
