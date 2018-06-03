using QuanLyNhaSach.DAO;
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
    public partial class FAddCategory : Form
    {
        private static FAddCategory instance;

        public static FAddCategory Instance
        {
            get { if (instance == null) instance = new FAddCategory(); return instance; }
            set => instance = value;
        }

        public FAddCategory()
        {
            InitializeComponent();
        }
        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }
        public bool AddCategory(string name)
        {
            return CategoryBookDAO.Instance.AddCategory(name);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txbCategory.Text;
                if (name == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên thể loại sách");
                    return;
                }

                if (AddCategory(name))
                {
                    MessageBox.Show("Thêm thể loại sách thành công !");
                    if (updateForm != null)
                        updateForm(this, new EventArgs());
                }
                else
                    MessageBox.Show("Thêm không thành công !");
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }
    }
}
