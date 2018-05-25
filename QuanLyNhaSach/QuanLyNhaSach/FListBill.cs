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
    public partial class FListBill : Form
    {
        public FListBill()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            dtgvListBill.DataSource = BillDAO.Instance.GetListBill();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvListBill.Rows.Count; i++)
                {
                    dtgvListBill.Rows[i].Cells["STT"].Value = i + 1;
                }
            };
        }

        private void dtgvListBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dtgvListBill.SelectedRows[0].Cells["idBill"].Value.ToString());
            dtgvListBillInfo.DataSource = BillInfoDAO.Instance.LoadListBillInfo(id);

            for (int i = 0; i < dtgvListBillInfo.Rows.Count; i++)
            {
                dtgvListBillInfo.Rows[i].Cells["STT2"].Value = i + 1;
            }
        }
    }
}
