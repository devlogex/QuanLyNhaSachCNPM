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
    public partial class FUpdateCategory : Form
    {
        private CategoryBook category;
        public FUpdateCategory(CategoryBook category)
        {
            InitializeComponent();

            this.Category = category;
            LoadForm();
        }
        public CategoryBook Category { get => category; set => category = value; }
        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }
        public void LoadForm()
        {
            txbCategory.Text = Category.Name;
        }
        public bool UpdateCategory(int id, string name)
        {
            return CategoryBookDAO.Instance.UpdateCategory(id, name);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Category.ID;
                string name = txbCategory.Text;
                if (name == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên thể loại sách", "Thông báo");
                    return;
                }
                if (UpdateCategory(id, name))
                {
                    MessageBox.Show("Cập nhật thể loại sách thành công !", "Thông báo");
                    if (updateForm != null)
                        updateForm(this, new EventArgs());
                }
                else
                    MessageBox.Show("Cập nhật không thành công !", "Thông báo");
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }
    }
}
