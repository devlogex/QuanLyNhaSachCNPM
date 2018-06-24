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
    public partial class FChooseAuthor : Form
    {
        public FChooseAuthor()
        {
            InitializeComponent();
            LoadForm();

        }
        public void LoadForm()
        {
            LoadAuthorIntoCombobox();
           
        }
        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }
        public void LoadAuthorIntoCombobox()
        {
            List<Author> temple = AuthorDAO.Instance.GetListAuthor();
            List<Author> list = new List<Author>();
            list.Add(new Author(-1, "Thêm..."));
            foreach(Author item in temple)
            {
                list.Add(item);
            }
            cbAuthor.SelectedIndexChanged -= cbAuthor_SelectedIndexChanged;
            cbAuthor.DataSource = list;
            cbAuthor.DisplayMember = "name";
            cbAuthor.SelectedIndex = -1;
            cbAuthor.SelectedIndexChanged += cbAuthor_SelectedIndexChanged;
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
            try
            {
                if (dtgvAuthor.SelectedRows.Count > 0)
                {
                    dtgvAuthor.Rows.RemoveAt(dtgvAuthor.SelectedRows[0].Index);
                }
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvAuthor.RowCount == 0)
                {
                    MessageBox.Show("Bạn chưa nhập tác giả", "Thông báo");
                    return;
                }
                List<Author> authors = new List<Author>();
                foreach (DataGridViewRow item in dtgvAuthor.Rows)
                {
                    authors.Add(new Author(Int32.Parse(item.Cells["id"].Value.ToString()), item.Cells["name"].Value.ToString()));
                }
                if (updateForm != null)
                    updateForm(authors, new EventArgs());
                this.Close();
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }
        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((cbAuthor.SelectedItem as Author).ID == -1)
                {
                    FAddAuthor f = new FAddAuthor();
                    f.UpdateForm += delegate (object _sender, EventArgs _e)
                    {
                        LoadAuthorIntoCombobox();
                    };
                    f.ShowDialog();
                }
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
