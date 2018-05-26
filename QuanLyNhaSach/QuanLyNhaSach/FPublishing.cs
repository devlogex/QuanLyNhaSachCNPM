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
    public partial class FPublishing : Form
    {
        private int idBookTitle;
        public FPublishing(int idBookTitle)
        {
            InitializeComponent();

            this.idBookTitle = idBookTitle;
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
            cbPublishing.DataSource = BookDAO.Instance.GetPublishingByBookTitleID(idBookTitle);
        }
        public bool AddBook(int idBookTitle,string publishCompany,int publishYear)
        {
            return BookDAO.Instance.AddBook(idBookTitle, publishCompany, publishYear);
        }
        private void btnChose_Click(object sender, EventArgs e)
        {
            if (updateForm != null)
            {
                string publishing = cbPublishing.SelectedItem.ToString();
                updateForm(publishing, new EventArgs());
            }
            this.Close();
        }

        private void btnAddPublishing_Click(object sender, EventArgs e)
        {
            foreach(string item in cbPublishing.Items)
            {
                string publishCompany = item.Split(',')[0].Substring(13);
                string publishYear = item.Split(',')[1].Substring(5);
                if(publishCompany==txbPublishCompany.Text && publishYear==txbPublishYear.Text)
                {
                    MessageBox.Show("Nhà xuất bản và năm xuất bản đã tồn tại !");
                    return;
                }
            }
            if (AddBook(idBookTitle, txbPublishCompany.Text, Int32.Parse(txbPublishYear.Text)))
            {
                MessageBox.Show("Thêm sách thành công !");
            }
            else
                MessageBox.Show("Thêm thất bại !");
            string publishing = "Nhà xuất bản " + txbPublishCompany.Text + ", năm " + txbPublishYear.Text;
            if (updateForm != null)
                updateForm(publishing, new EventArgs());

            this.Close();
        }

        private void txbPublishYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
