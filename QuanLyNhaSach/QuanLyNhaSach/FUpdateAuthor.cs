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
    public partial class FUpdateAuthor : Form
    {
        private Author author;
        public Author Author { get => author; set => author = value; }
        public FUpdateAuthor(Author author)
        {
            InitializeComponent();

            this.Author = author;
            LoadForm();
        }

        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }
        public void LoadForm()
        {
            txbAuthor.Text = Author.Name;
        }
        public bool UpdateAuthor(int id, string name)
        {
            return AuthorDAO.Instance.UpdateAuthor(id, name);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            int id = Author.ID;
            string name = txbAuthor.Text;
            if (name == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả !");
                return;
            }
            if (UpdateAuthor(id, name))
            {
                MessageBox.Show("Sửa tác giả thành công !");
                if (updateForm != null)
                    updateForm(this, new EventArgs());
            }
            else
                MessageBox.Show("Sửa không thành công !");
        }
    }
}
