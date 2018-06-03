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
    public partial class FSearchBook : Form
    {
        public FSearchBook()
        {
            InitializeComponent();
            LoadForm();
        }
        #region Method
        public void LoadForm()
        {
            LoadListBookTitle();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageBookTitle.Rows.Count; i++)
                {
                    dtgvManageBookTitle.Rows[i].Cells["STT"].Value = i + 1;
                }
            };
            LoadListBookTitleIntoCombobox();
            LoadCategoryIntoCombobox();
            cbAuthor.Items.Add("Chọn tác giả");
            cbAuthor.SelectedIndex = -1;
            cbAuthor.SelectedIndexChanged += cbAuthor_SelectedIndexChanged;

            cbIDBookTitle.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;

            cbIDBookTitle.Enabled = false;
            txbNameBookTitle.Enabled = false;
            cbCategory.Enabled = false;
            cbAuthor.Enabled = false;
            nmCountFrom.Enabled = false;
            nmCountTo.Enabled = false;
        }
        public void LoadListBookTitle()
        {
            dtgvManageBookTitle.DataSource = BookTitleDAO.Instance.LoadListBookTitle();
            LoadSTT();
        }
        public void LoadListBookTitleIntoCombobox()
        {
            cbIDBookTitle.DataSource = BookTitleDAO.Instance.GetListBookTitle();
            cbIDBookTitle.DisplayMember = "id";
        }
        public void LoadCategoryIntoCombobox()
        {
            cbCategory.DataSource = CategoryBookDAO.Instance.GetListCategory();
            cbCategory.DisplayMember = "name";
        }
        public void LoadSTT()
        {
            for (int i = 0; i < dtgvManageBookTitle.Rows.Count; i++)
            {
                dtgvManageBookTitle.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        public void SearchBook()
        {
            try
            {
                dtgvManageBookTitle.DataSource = BookTitleDAO.Instance.LoadListBookTitle();
                if (ckbIDBookTitle.Checked == true)
                {
                    if(cbIDBookTitle.SelectedItem==null)
                    {
                        MessageBox.Show("Bạn chưa chọn mã đầu sách !", "Thông báo");
                        return;
                    }
                    BookTitle bookTitle = cbIDBookTitle.SelectedItem as BookTitle;
                    for (int i = 0; i < dtgvManageBookTitle.RowCount; i++)
                    {
                        if (Int32.Parse(dtgvManageBookTitle.Rows[i].Cells["id"].Value.ToString()) != bookTitle.ID)
                        {
                            dtgvManageBookTitle.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                if (ckbNameBookTitle.Checked == true)
                {
                    List<int> listIDBookTitle = BookTitleDAO.Instance.SearchBookTitleByName(txbNameBookTitle.Text);
                    for (int i = 0; i < dtgvManageBookTitle.RowCount; i++)
                    {
                        int j = 0;
                        for (; j < listIDBookTitle.Count; j++)
                        {
                            if (Int32.Parse(dtgvManageBookTitle.Rows[i].Cells["id"].Value.ToString()) == listIDBookTitle[j])
                            {
                                break;
                            }
                        }
                        if (j == listIDBookTitle.Count)
                        {
                            dtgvManageBookTitle.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                if (ckbCategory.Checked == true)
                {
                    for (int i = 0; i < dtgvManageBookTitle.RowCount; i++)
                    {
                        if (dtgvManageBookTitle.Rows[i].Cells["category"].Value.ToString() != (cbCategory.SelectedItem as CategoryBook).Name)
                        {
                            dtgvManageBookTitle.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                if (ckbAuthor.Checked == true)
                {
                    string[] authorSearch = cbAuthor.SelectedItem.ToString().Split(',');
                    for (int i = 0; i < dtgvManageBookTitle.RowCount; i++)
                    {
                        string[] authorDTGV = dtgvManageBookTitle.Rows[i].Cells["author"].Value.ToString().Split(',');
                        int j = 0;
                        for (; j < authorSearch.Length; j++)
                        {
                            if (!authorDTGV.Contains(authorSearch[j]))
                            {
                                break;
                            }
                        }
                        if (j != authorSearch.Length)
                        {
                            dtgvManageBookTitle.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                if (ckbCount.Checked == true)
                {
                    for (int i = 0; i < dtgvManageBookTitle.RowCount; i++)
                    {
                        if (Int32.Parse(dtgvManageBookTitle.Rows[i].Cells["totalCount"].Value.ToString()) < (int)nmCountFrom.Value ||
                            Int32.Parse(dtgvManageBookTitle.Rows[i].Cells["totalCount"].Value.ToString()) > (int)nmCountTo.Value)
                        {
                            dtgvManageBookTitle.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                LoadSTT();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }
        #endregion

        #region Event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBook();
        }
        private void ckbCategory_CheckedChanged(object sender, EventArgs e)
        {
            cbCategory.Enabled = ckbCategory.Checked == true;

            if (ckbCategory.Checked == false)
                SearchBook();
        }
        private void ckbCount_CheckedChanged(object sender, EventArgs e)
        {
            nmCountFrom.Enabled = ckbCount.Checked == true;
            nmCountTo.Enabled = ckbCount.Checked == true;

            if (ckbCount.Checked == false)
                SearchBook();
        }

        private void ckbAuthor_CheckedChanged(object sender, EventArgs e)
        {
            cbAuthor.Enabled = ckbAuthor.Checked == true;

            if (ckbAuthor.Checked == false)
                SearchBook();
        }



        private void ckbIDBookTitle_CheckedChanged(object sender, EventArgs e)
        {
            cbIDBookTitle.Enabled = ckbIDBookTitle.Checked == true;

            if (ckbIDBookTitle.Checked == false)
                SearchBook();
        }

        private void ckbNameBookTitle_CheckedChanged(object sender, EventArgs e)
        {
            txbNameBookTitle.Enabled = ckbNameBookTitle.Checked == true;

            if (ckbNameBookTitle.Checked == false)
                SearchBook();
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
            for (int i = 0; i < authors.Count - 1; i++)
            {
                author += authors[i].Name + ",";
            }
            if (authors.Count > 0)
                author += authors[authors.Count - 1].Name;

            cbAuthor.Items.Add(author);
            cbAuthor.SelectedIndex = cbAuthor.Items.Count - 1;
            cbAuthor.Tag = authors;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdateBookTitle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvManageBookTitle.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn đầu sách để sửa", "Thông báo");
                    return;
                }

                BookTitle bookTitle = BookTitleDAO.Instance.GetBookTitleByBookTitleID(Int32.Parse(dtgvManageBookTitle.SelectedRows[0].Cells["id"].Value.ToString()));
                FUpdateBookTitle f = new FUpdateBookTitle(bookTitle);
                f.UpdateForm += F_LoadListBookTitleAfterUpdate;
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void F_LoadListBookTitleAfterUpdate(object sender, EventArgs e)
        {
            SearchBook();
        }
        #endregion
    }
}
