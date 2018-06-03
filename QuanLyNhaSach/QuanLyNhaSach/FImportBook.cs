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
    public partial class FImportBook : Form
    {
        public FImportBook()
        {
            InitializeComponent();
            LoadForm();
        }
        private int minImport;
        private int maxCount;
        #region Method

        public void LoadForm()
        {
            minImport = ThamSoDAO.Instance.GetMinImport();
            maxCount = ThamSoDAO.Instance.GetMaxCount();
            lb.Text = "*Chỉ nhập các sách có số lượng tồn nhỏ hơn " + maxCount.ToString() + ". Số lượng nhập lớn hơn hoặc bằng " + minImport.ToString();

            txbIDImportBook.Text = ImportBookDAO.Instance.GetNewIDImportBook().ToString();
            txbIDBookTitle.Text = BookTitleDAO.Instance.GetNewIDBookTitle().ToString();
            txbIDBook.Text = BookDAO.Instance.GetNewIDBook().ToString();
            dtpk.Value = DateTime.Now;
            LoadListBookIntoCombobox();
            txbTotalPrice.Text = "0";

            cbAuthor.Items.Add("Chọn tác giả");
            cbAuthor.SelectedIndex = -1;
            cbAuthor.SelectedIndexChanged += cbAuthor_SelectedIndexChanged;

            LoadCategoryIntoCombobox();
            cbCategory.SelectedIndex = -1;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;

            LoadBookTitleIntoCombobox();
            cbBookTitle.SelectedIndex = -1;

            LoadSTT();

            dtgvImportBook.CellEndEdit += dtgvImportBook_CellEndEdit;
            dtgvImportBook.EditingControlShowing += dtgvImportBook_EditingControlShowing;
            dtgvImportBook.RowsAdded += dtgvImportBook_RowsAdded;
            dtgvImportBook.RowsRemoved += dtgvImportBook_RowsRemoved;
        }
        public void LoadSTT()
        {
            for (int i = 0; i < dtgvImportBook.RowCount; i++)
                dtgvImportBook.Rows[i].Cells["STT"].Value = i + 1;
        }
        public void LoadListBookIntoCombobox()
        {
            id.DataSource = BookDAO.Instance.GetListBook();
            id.DisplayMember = "id";
        }
        public void LoadCategoryIntoCombobox()
        {
            List<CategoryBook> list = CategoryBookDAO.Instance.GetListCategory();
            list.Add(new CategoryBook(-1, "Thêm"));
            cbCategory.DataSource = list;
            cbCategory.DisplayMember = "name";
        }
        public void LoadBookTitleIntoCombobox()
        {
            cbBookTitle.DataSource = BookTitleDAO.Instance.GetListBookTitle();
            cbBookTitle.DisplayMember = "id";
        }
        public void SaveImportBook(DateTime date)
        {
            if (!ImportBookDAO.Instance.InsertImportBook(date))
            {
                MessageBox.Show("Có lỗi khi lưu phiếu nhập sách !", "Thông báo");
                return;
            }

            for (int i = 0; i < dtgvImportBook.Rows.Count - 1; i++)
            {
                int idBook = Int32.Parse(dtgvImportBook.Rows[i].Cells["id"].Value.ToString());
                int count = Int32.Parse(dtgvImportBook.Rows[i].Cells["count"].Value.ToString());
                float priceIn = (float)Double.Parse(dtgvImportBook.Rows[i].Cells["priceIn"].Value.ToString());
                if (!ImportBookInfoDAO.Instance.InsertImportBookInfo(idBook, count, priceIn, count * priceIn))
                {
                    return;
                }
            }
            MessageBox.Show("Lưu phiếu nhập sách thành công !", "Thông báo");
            btnSaveImport.Tag = 1;
        }
        public bool AddBookTitle(string name, int idCategory, List<int> authors)
        {
            return BookTitleDAO.Instance.AddBookTitle(name, idCategory, authors);
        }


        #endregion

        #region Event

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvImportBook_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (cbm != null)
            {
                cbm.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
            }
            try
            {

                if (dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value != null)
                {
                    if (Int64.Parse(dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value.ToString()) < minImport)
                    {
                        MessageBox.Show("Số lượng nhập tối thiểu là " + minImport.ToString());
                        dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value = "";
                        return;
                    }
                }

                if (dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value != null && dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value != null)
                {
                    dtgvImportBook.Rows[e.RowIndex].Cells["totalPrice"].Value = Double.Parse(dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value.ToString()) * Int64.Parse(dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value.ToString());
                }
            }
            catch
            {
                dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value = null;
                dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value = null;
                MessageBox.Show("Lỗi dữ liệu nhập không đúng định dạng !", "Thông báo");
            }

            double totalPrice = 0.0;
            foreach(DataGridViewRow item in dtgvImportBook.Rows)
            {
                if (item.Cells["totalPrice"].Value != null)
                    totalPrice += Double.Parse(item.Cells["totalPrice"].Value.ToString());
            }
            txbTotalPrice.Text = totalPrice.ToString();
        }
        ComboBox cbm;
        DataGridViewCell currentCell;
        private void dtgvImportBook_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                cbm = (ComboBox)e.Control;
                if (cbm != null)
                {
                    cbm.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
                }
                currentCell = this.dtgvImportBook.CurrentCell;
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
                if(book.Count>=maxCount)
                {
                    MessageBox.Show("Chỉ nhập các sách có số lượng nhỏ hơn " + maxCount.ToString() + ".\nSách " + book.Name + " có lượng tồn là " + book.Count.ToString());
                    dtgvImportBook.Rows.RemoveAt(dtgvImportBook.SelectedCells[0].OwningRow.Index);
                    return;
                }
                if (book != null)
                {
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["name"].Value = book.Name;
                    string authors = "";
                    for(int i=0;i<book.Authors.Count-1;i++)
                    {
                        authors += book.Authors[i].Name+", ";
                    }
                    if (book.Authors.Count > 0)
                        authors += book.Authors[book.Authors.Count - 1].Name;
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["author"].Value = authors;
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["category"].Value = book.Category.Name;
                    dtgvImportBook.SelectedCells[0].OwningRow.Cells["publishing"].Value ="Nhà xuất bản "+book.PublishCompany+", năm "+book.PublishYear;


                    this.dtgvImportBook.EndEdit();
                }
            }
        }

        private void dtgvImportBook_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtgvImportBook.Rows[dtgvImportBook.RowCount - 1].Cells["STT"].Value = dtgvImportBook.RowCount;
        }
        private void dtgvImportBook_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            LoadSTT();
        }

        private void btnSaveImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSaveImport.Tag != null)
                {
                    MessageBox.Show("Bạn phải tạo phiếu nhập mới !", "Thông báo");
                    return;
                }
                for (int i = 0; i < dtgvImportBook.RowCount - 1; i++)
                {
                    if (dtgvImportBook.Rows[i].Cells["totalPrice"].Value == null)
                    {
                        MessageBox.Show("Bạn chưa nhập đủ dữ liệu ở hàng thứ " + (i + 1).ToString(), "Thông báo");
                        return;
                    }

                }

                DateTime date = dtpk.Value;
                SaveImportBook(date);
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAuthor.SelectedItem.ToString() == "Chọn tác giả")
                {
                    FChooseAuthor f = new FChooseAuthor();
                    f.UpdateForm += F_LoadAfterChooseAuthor;
                    f.ShowDialog();
                }
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void F_LoadAfterChooseAuthor(object sender, EventArgs e)
        {
            List<Author> authors = sender as List<Author>;
            string author = "";
            for(int i=0;i<authors.Count-1;i++)
            {
                author += authors[i].Name + ", ";
            }
            if (authors.Count > 0)
                author += authors[authors.Count - 1].Name;

            cbAuthor.Items.Add(author);
            cbAuthor.SelectedIndex = cbAuthor.Items.Count-1;
            cbAuthor.Tag = authors;
        }

        private void btnAddBookTitle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbNameBookTitle.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đầu sách !", "Thông báo");
                    return;
                }

                if (cbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Bạn chưa chọn thể loại sách !", "Thông báo");
                    return;
                }
                if (cbAuthor.SelectedItem == null)
                {
                    MessageBox.Show("Bạn chưa nhập tác giả !", "Thông báo");
                    return;
                }
                string name = txbNameBookTitle.Text;
                int idCategory = (cbCategory.SelectedItem as CategoryBook).ID;
                List<Author> authors = cbAuthor.Tag as List<Author>;
                List<int> idAuthors = new List<int>();
                foreach (Author item in authors)
                {
                    idAuthors.Add(item.ID);
                }


                if (AddBookTitle(name, idCategory, idAuthors))
                {
                    MessageBox.Show("Thêm đầu sách thành công!", "Thông báo");
                    LoadBookTitleIntoCombobox();
                    txbIDBookTitle.Text = BookTitleDAO.Instance.GetNewIDBookTitle().ToString();
                    txbNameBookTitle.Text = "";
                }
                else
                    MessageBox.Show("Thêm đầu sách thất bại !", "Thông báo");
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBookTitle.SelectedItem == null)
                {
                    MessageBox.Show("Bạn chưa nhập mã đầu sách !", "Thông báo");
                    return;
                }
                if (txbPublishCompany.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập nhà xuất bản !", "Thông báo");
                    return;
                }
                if (txbPublishYear.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập năm xuất bản !", "Thông báo");
                    return;
                }
                if (BookDAO.Instance.AddBook((cbBookTitle.SelectedItem as BookTitle).ID, txbPublishCompany.Text, Int32.Parse(txbPublishYear.Text)))
                {
                    MessageBox.Show("Thêm sách thành công !", "Thông báo");
                    LoadListBookIntoCombobox();
                    txbIDBook.Text = BookDAO.Instance.GetNewIDBook().ToString();
                    txbPublishCompany.Text = "";
                    txbPublishYear.Text = "";
                }
                else
                    MessageBox.Show("Thêm sách thất bại !", "Thông báo");
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void txbPublishYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPrintImport_Click(object sender, EventArgs e)
        {
            if (btnSaveImport.Tag == null)
            {
                MessageBox.Show("Bạn phải lưu phiếu nhập trước !", "Thông báo");
                return;
            }

            string name = "PHIEUNHAPSACH" + txbIDImportBook.Text.ToString() + ".pdf";
            try
            {
                List<Phrase> data = new List<Phrase>()
                {
                    ExportDataToPDF.Instance.GetPhraseHeader("PHIẾU NHẬP SÁCH\n"),
                    ExportDataToPDF.Instance.GetPhrase("Số phiếu nhập: \t"),
                    ExportDataToPDF.Instance.GetPhrase(txbIDImportBook.Text+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Ngày lập: \t"+ dtpk.Value.ToString()+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Tổng tiền: \t"+txbTotalPrice.Text+'\n')
                };
                ExportDataToPDF.Instance.ExportDataToPdf(name,data,ExportDataToPDF.Instance.GetTable(dtgvImportBook));
                if(MessageBox.Show("In thành công ! Bạn có muốn mở file ?","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    Process.Start(name);
            }
            catch { MessageBox.Show("In thất bại "); }

        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((cbCategory.SelectedItem as CategoryBook).ID == -1)
                {
                    FAddCategory f = new FAddCategory();
                    f.UpdateForm += delegate (object _sender, EventArgs _e)
                    {
                        LoadCategoryIntoCombobox();
                    };
                    f.ShowDialog();
                }
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }
        #endregion
    }
}
