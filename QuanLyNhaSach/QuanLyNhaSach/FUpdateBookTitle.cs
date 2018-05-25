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
    public partial class FUpdateBookTitle : Form
    {
        private BookTitle bookTitle;
        public BookTitle BookTitle { get => bookTitle; set => bookTitle = value; }

        public FUpdateBookTitle(BookTitle bookTitle)
        {
            InitializeComponent();

            this.BookTitle = bookTitle;
            LoadForm();
        }
        #region Method
        public void LoadForm()
        {
            LoadCategoryIntoCombobox();
            LoadAuthorIntoCombobox();

            txbBookTitle.Text = BookTitle.Name;

            int index = -1;
            int i = 0;
            foreach(CategoryBook item in cbCategory.Items)
            {
                if(item.ID==BookTitle.IdCategory)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbCategory.SelectedIndex = index;

            LoadListAuthor();
        }
        public void LoadListAuthor()
        {
            foreach(Author item in BookTitle.Authors)
            {
                dtgvAuthor.Rows.Add(item.ID, item.Name);
            }
        }
        public void LoadCategoryIntoCombobox()
        {
            cbCategory.DataSource = CategoryBookDAO.Instance.GetListCategory();
            cbCategory.DisplayMember = "name";
        }
        public void LoadAuthorIntoCombobox()
        {
            cbAuthor.DataSource = AuthorDAO.Instance.GetListAuthor();
            cbAuthor.DisplayMember = "name";
        }
        public bool UpdateBookTitle(int id, string name, int idCategory, List<int> authors)
        {
            return BookTitleDAO.Instance.UpdateBookTitle(id, name, idCategory, authors);
        }

        #endregion

        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbAddAuthor_Click(object sender, EventArgs e)
        {
            if (cbAuthor.SelectedItem != null)
            {
                Author author = cbAuthor.SelectedItem as Author;
                for (int i = 0; i < dtgvAuthor.Rows.Count; i++)
                {
                    if (Int32.Parse(dtgvAuthor.Rows[i].Cells["id"].Value.ToString()) == author.ID)
                        return;
                }
                dtgvAuthor.Rows.Add(author.ID, author.Name);
            }
        }

        private void pbRemoveAuthor_Click(object sender, EventArgs e)
        {
            if(dtgvAuthor.SelectedRows.Count>0)
            {
                dtgvAuthor.Rows.RemoveAt(dtgvAuthor.SelectedRows[0].Index);
            }
        }

        private void btnUpdateBookTitle_Click(object sender, EventArgs e)
        {
            if (txbBookTitle.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sách !");
                return;
            }

            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn thể loại sách !");
                return;
            }
            if (dtgvAuthor.RowCount == 0)
            {
                MessageBox.Show("Bạn chưa nhập tác giả !");
                return;
            }
            string name = txbBookTitle.Text;
            int idCategory = (cbCategory.SelectedItem as CategoryBook).ID;
            List<int> authors = new List<int>();
            for (int i = 0; i < dtgvAuthor.Rows.Count; i++)
            {
                authors.Add(Int32.Parse(dtgvAuthor.Rows[i].Cells["id"].Value.ToString()));
            }


            if (UpdateBookTitle(BookTitle.ID,name, idCategory, authors))
            {
                MessageBox.Show("Cập nhật đầu sách thành công!");
                if (updateForm != null)
                {
                    updateForm(this, new EventArgs());
                }
            }
            else
                MessageBox.Show("Sửa đầu sách thất bại !");
        }
    }
}
