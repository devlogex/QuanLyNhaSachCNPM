using iTextSharp.text;
using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FListBill : Form
    {
        private Customer customer;
        public FListBill(Customer customer)
        {
            InitializeComponent();

            this.Customer = customer;
            LoadForm();
        }

        public Customer Customer { get => customer; set => customer = value; }

        public void LoadForm()
        {
            dtgvListBill.DataSource = BillDAO.Instance.GetListBillByCustomerID(Customer.ID);
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvListBill.Rows.Count; i++)
                {
                    dtgvListBill.Rows[i].Cells["STT"].Value = i + 1;
                }
            };
            foreach(DataGridViewCell cell in dtgvListBill.SelectedCells)
            {
                cell.Selected = false;
            }

            dtgvListBill.CellClick += dtgvListBill_CellClick;
        }

        private void dtgvListBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Int32.Parse(dtgvListBill.SelectedRows[0].Cells["idBill"].Value.ToString());
                dtgvListBillInfo.DataSource = BillInfoDAO.Instance.LoadListBillInfo(id);

                for (int i = 0; i < dtgvListBillInfo.Rows.Count; i++)
                {
                    dtgvListBillInfo.Rows[i].Cells["STT2"].Value = i + 1;
                }
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dtgvListBill.SelectedRows.Count==0)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn !", "Thông báo");
                return;
            }
            string name = "HOADON" + dtgvListBill.SelectedRows[0].Cells["idBill"].Value.ToString() + ".pdf";
            try
            {
                List<Phrase> data = new List<Phrase>()
                {
                    ExportDataToPDF.Instance.GetPhraseHeader("HÓA ĐƠN BÁN SÁCH\n"),
                    ExportDataToPDF.Instance.GetPhrase("Số hóa đơn: "),
                    ExportDataToPDF.Instance.GetPhrase(dtgvListBill.SelectedRows[0].Cells["idBill"].Value.ToString()+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Khách hàng: "+dtgvListBill.SelectedRows[0].Cells["nameCustomer"].Value.ToString()+ "     Mã khách hàng: "+dtgvListBill.SelectedRows[0].Cells["idCustomer"].Value.ToString()+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Ngày lập: "+ dtgvListBill.SelectedRows[0].Cells["date"].Value.ToString()+'\n'),
                    ExportDataToPDF.Instance.GetPhrase("Tổng tiền: "+dtgvListBill.SelectedRows[0].Cells["value"].Value.ToString()+'\n'),
                };
                ExportDataToPDF.Instance.ExportDataToPdf(name, data, ExportDataToPDF.Instance.GetTable(dtgvListBillInfo));
                if (MessageBox.Show("In thành công ! Bạn có muốn mở file ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Process.Start(name);
            }
            catch { MessageBox.Show("In thất bại ", "Thông báo"); }
        }
    }
}
