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
    public partial class FAddAuthor : Form
    {
        public FAddAuthor()
        {
            InitializeComponent();
        }
        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }
        public bool AddAuthor(string name)
        {
            return AuthorDAO.Instance.AddAuthor(name);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string name = txbAuthor.Text;
            if (name == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả");
                return;
            }

            if (AddAuthor(name))
            {
                MessageBox.Show("Thêm tác giả thành công !");
                if (updateForm != null)
                    updateForm(this, new EventArgs());
            }
            else
                MessageBox.Show("Thêm không thành công !");
        }
    }
}
