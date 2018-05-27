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
    public partial class FImportBook : Form
    {
        public FImportBook()
        {
            InitializeComponent();
            LoadForm();
        }
        #region Method

        public void LoadForm()
        {
            txbIDImportBook.Text = ImportBookDAO.Instance.GetNewIDImportBook().ToString();
            txbIDBookTitle.Text = BookTitleDAO.Instance.GetNewIDBookTitle().ToString();
            txbIDBook.Text = BookDAO.Instance.GetNewIDBook().ToString();
            dtpk.Value = DateTime.Now;
            LoadListBookIntoCombobox();
            LoadCategoryIntoCombobox();
            LoadBookTitleIntoCombobox();
            txbTotalPrice.Text = "0";

            cbAuthor.Items.Add("Thêm");
            LoadSTT();
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
            cbCategory.DataSource = CategoryBookDAO.Instance.GetListCategory();
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
                MessageBox.Show("Có lỗi khi lưu phiếu nhập sách !");
                return;
            }

            for (int i = 0; i < dtgvImportBook.Rows.Count-1; i++)
            {
                int idBook = Int32.Parse(dtgvImportBook.Rows[i].Cells["id"].Value.ToString());
                int count = Int32.Parse(dtgvImportBook.Rows[i].Cells["count"].Value.ToString());
                float priceIn = (float)Double.Parse(dtgvImportBook.Rows[i].Cells["priceIn"].Value.ToString());
                if (!ImportBookInfoDAO.Instance.InsertImportBookInfo(idBook, count, priceIn,count*priceIn))
                {
                    MessageBox.Show(String.Format("Có lỗi khi lưu sách {0}", dtgvImportBook.Rows[i].Cells["nameBook"].Value));
                    return;
                }
            }
            MessageBox.Show("Lưu phiếu nhập sách thành công !");
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

            if(dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value!=null && dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value!=null)
            {
                dtgvImportBook.Rows[e.RowIndex].Cells["totalPrice"].Value = Double.Parse(dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value.ToString()) * Int64.Parse(dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value.ToString());
            }

            //if(dtgvImportBook.Rows[e.RowIndex].Cells["id"].Value!=null && dtgvImportBook.Rows[e.RowIndex].Cells["count"].Value != null && dtgvImportBook.Rows[e.RowIndex].Cells["priceIn"].Value != null && dtgvImportBook.Rows[e.RowIndex].Cells["publishing"].Value != null)
            //{
            //    DataGridViewRow data = dtgvImportBook.Rows[e.RowIndex];
            //    for(int i=0;i<dtgvImportBook.RowCount-1;i++)
            //    {
            //        if(i!=e.RowIndex)
            //        {
            //            if(dtgvImportBook.Rows[i].Cells["id"].Value.ToString()==data.Cells["id"].Value.ToString() && dtgvImportBook.Rows[i].Cells["publishing"].Value.ToString()==data.Cells["publishing"].Value.ToString())
            //            {
            //                dtgvImportBook.Rows[i].Cells["count"].Value = Int64.Parse(dtgvImportBook.Rows[i].Cells["count"].Value.ToString()) + Int64.Parse(data.Cells["count"].Value.ToString());
            //                dtgvImportBook.Rows[i].Cells["priceIn"].Value =Double.Parse(data.Cells["priceIn"].Value.ToString());
            //                dtgvImportBook.Rows.Remove(data);

            //            }
            //        }
            //    }
            //}

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
                Book book = cbm.SelectedItem as Book;
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
            DateTime date = dtpk.Value;
            SaveImportBook(date);
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbAuthor.SelectedItem.ToString() =="Thêm")
            {
                FChooseAuthor f = new FChooseAuthor();
                f.UpdateForm += F_LoadAfterChooseAuthor;
                f.ShowDialog();
            }
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
            if (txbNameBookTitle.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đầu sách !");
                return;
            }

            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn thể loại sách !");
                return;
            }
            if (cbAuthor.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa nhập tác giả !");
                return;
            }
            string name = txbNameBookTitle.Text;
            int idCategory = (cbCategory.SelectedItem as CategoryBook).ID;
            List<Author> authors = cbAuthor.Tag as List<Author>;
            List<int> idAuthors = new List<int>();
            foreach(Author item in authors)
            {
                idAuthors.Add(item.ID);
            }


            if (AddBookTitle(name, idCategory, idAuthors))
            {
                MessageBox.Show("Thêm đầu sách thành công!");
                LoadBookTitleIntoCombobox();
            }
            else
                MessageBox.Show("Thêm đầu sách thất bại !");

        }

        #endregion

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(cbBookTitle.SelectedItem==null)
            {
                MessageBox.Show("Bạn chưa nhập mã đầu sách !");
                return;
            }
            if(txbPublishCompany.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập nhà xuất bản !");
                return;
            }
            if (txbPublishYear.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm xuất bản !");
                return;
            }
            if (BookDAO.Instance.AddBook((cbBookTitle.SelectedItem as BookTitle).ID, txbPublishCompany.Text, Int32.Parse(txbPublishYear.Text)))
            {
                MessageBox.Show("Thêm sách thành công !");
                LoadListBookIntoCombobox();
            }
            else
                MessageBox.Show("Thêm sách thất bại !");
        }

        private void txbPublishYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
