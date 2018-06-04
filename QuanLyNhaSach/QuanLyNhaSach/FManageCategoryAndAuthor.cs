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
    public partial class FManageCategoryAndAuthor : Form
    {
        BindingSource categoryList = new BindingSource();
        BindingSource authorList = new BindingSource();

        public FManageCategoryAndAuthor()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            dtgvManageCategory.DataSource = categoryList;
            LoadListCategory();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageCategory.Rows.Count; i++)
                {
                    dtgvManageCategory.Rows[i].Cells["STTCategory"].Value = i + 1;
                }
            };

            dtgvManageAuthor.DataSource = authorList;
            LoadListAuthor();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageAuthor.Rows.Count; i++)
                {
                    dtgvManageAuthor.Rows[i].Cells["STTAuthor"].Value = i + 1;
                }
            };

            dtgvManageAuthor.Sorted += delegate (object _sender, EventArgs _e)
            {
                for (int i = 0; i < dtgvManageAuthor.Rows.Count; i++)
                {
                    dtgvManageAuthor.Rows[i].Cells["STTAuthor"].Value = i + 1;
                }
            };

            dtgvManageCategory.Sorted += delegate (object _sender, EventArgs _e)
            {
                for (int i = 0; i < dtgvManageCategory.Rows.Count; i++)
                {
                    dtgvManageCategory.Rows[i].Cells["STTCategory"].Value = i + 1;
                }
            };
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryBookDAO.Instance.GetListCategory();
            for (int i = 0; i < dtgvManageCategory.Rows.Count; i++)
            {
                dtgvManageCategory.Rows[i].Cells["STTCategory"].Value = i + 1;
            }
        }
        void LoadListAuthor()
        {
            authorList.DataSource = AuthorDAO.Instance.GetListAuthor();
            for (int i = 0; i < dtgvManageAuthor.Rows.Count; i++)
            {
                dtgvManageAuthor.Rows[i].Cells["STTAuthor"].Value = i + 1;
            }
        }
        public bool RemoveCategoryByCategoryID(int id)
        {
            return CategoryBookDAO.Instance.RemoveCategoryByCategoryID(id);
        }
        public bool RemoveAuthorByAuthorID(int id)
        {
            return AuthorDAO.Instance.RemoveAuthorByAuthorID(id);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                FAddCategory f = new FAddCategory();
                f.UpdateForm += F_LoadListCategoryAfterAdd;
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void F_LoadListCategoryAfterAdd(object sender, EventArgs e)
        {
            LoadListCategory();

            for (int i = 0; i < dtgvManageCategory.SelectedRows.Count; i++)
            {
                dtgvManageCategory.SelectedRows[i].Selected = false;
            }
            dtgvManageCategory.Rows[dtgvManageCategory.Rows.Count - 1].Selected = true;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvManageCategory.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn thể loại sách để sửa", "Thông báo");
                    return;
                }

                CategoryBook category = new CategoryBook(Int32.Parse(dtgvManageCategory.SelectedRows[0].Cells["idCategory"].Value.ToString()), dtgvManageCategory.SelectedRows[0].Cells["nameCategory"].Value.ToString());
                FUpdateCategory f = new FUpdateCategory(category);
                f.UpdateForm += F_LoadListCategoryAfterUpdate;
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void F_LoadListCategoryAfterUpdate(object sender, EventArgs e)
        {
            LoadListCategory();

            for (int i = 0; i < dtgvManageCategory.SelectedRows.Count; i++)
            {
                dtgvManageCategory.SelectedRows[i].Selected = false;
            }

            CategoryBook category = (sender as FUpdateCategory).Category;
            int index = 0;
            while (Int32.Parse(dtgvManageCategory.Rows[index].Cells["idCategory"].Value.ToString()) != category.ID)
            {
                index++;
            }
            dtgvManageCategory.Rows[index].Selected = true;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvManageCategory.SelectedCells.Count > 0)
                {
                    int id = Int32.Parse(dtgvManageCategory.SelectedCells[0].OwningRow.Cells["idCategory"].Value.ToString());
                    if (RemoveCategoryByCategoryID(id))
                    {
                        MessageBox.Show("Đã xóa thành công !", "Thông báo");
                        LoadListCategory();
                    }
                    else
                        MessageBox.Show("Xóa không thành công !", "Thông báo");

                }
                else
                    MessageBox.Show("Bạn chưa chọn thể loại sách ! ", "Thông báo");
            }
            catch { MessageBox.Show("Xóa không thành công !", "Thông báo"); }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                FAddAuthor f = new FAddAuthor();
                f.UpdateForm += F_LoadListAuthorAfterAdd;
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void F_LoadListAuthorAfterAdd(object sender, EventArgs e)
        {
            LoadListAuthor();

            for (int i = 0; i < dtgvManageAuthor.SelectedRows.Count; i++)
            {
                dtgvManageAuthor.SelectedRows[i].Selected = false;
            }
            dtgvManageAuthor.Rows[dtgvManageAuthor.Rows.Count - 1].Selected = true;
        }

        private void btnRemoveAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvManageAuthor.SelectedCells.Count > 0)
                {
                    int id = Int32.Parse(dtgvManageAuthor.SelectedCells[0].OwningRow.Cells["idAuthor"].Value.ToString());
                    if (RemoveAuthorByAuthorID(id))
                    {
                        MessageBox.Show("Đã xóa thành công !", "Thông báo");
                        LoadListAuthor();
                    }
                    else
                        MessageBox.Show("Xóa không thành công !", "Thông báo");

                }
                else
                    MessageBox.Show("Bạn chưa chọn tác giả ", "Thông báo");
            }
            catch { MessageBox.Show("Xóa không thành công !", "Thông báo"); }
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvManageAuthor.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn tác giả để cập nhật", "Thông báo");
                    return;
                }

                Author author = new Author(Int32.Parse(dtgvManageAuthor.SelectedRows[0].Cells["idAuthor"].Value.ToString()), dtgvManageAuthor.SelectedRows[0].Cells["nameAuthor"].Value.ToString());
                FUpdateAuthor f = new FUpdateAuthor(author);
                f.UpdateForm += F_LoadListAuthorAfterUpdate; ;
                f.ShowDialog();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void F_LoadListAuthorAfterUpdate(object sender, EventArgs e)
        {
            LoadListAuthor();

            for (int i = 0; i < dtgvManageAuthor.SelectedRows.Count; i++)
            {
                dtgvManageAuthor.SelectedRows[i].Selected = false;
            }

            Author author = (sender as FUpdateAuthor).Author;
            int index = 0;
            while (Int32.Parse(dtgvManageAuthor.Rows[index].Cells["idAuthor"].Value.ToString()) != author.ID)
            {
                index++;
            }
            dtgvManageAuthor.Rows[index].Selected = true;
        }
    }
}
