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
    public partial class FListImportBook : Form
    {
        public FListImportBook()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            dtgvListImportBook.DataSource = ImportBookDAO.Instance.GetListImportBook();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvListImportBook.Rows.Count; i++)
                {
                    dtgvListImportBook.Rows[i].Cells["STT"].Value = i + 1;
                }
            };
        }
        private void dtgvListImportBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id=Int32.Parse(dtgvListImportBook.SelectedRows[0].Cells["id"].Value.ToString());
            dtgvListImportBookInfo.DataSource = ImportBookInfoDAO.Instance.LoadListImportBookInfo(id);

            for (int i = 0; i < dtgvListImportBookInfo.Rows.Count; i++)
            {
                dtgvListImportBookInfo.Rows[i].Cells["STT2"].Value = i + 1;
            }
        }
    }
}
