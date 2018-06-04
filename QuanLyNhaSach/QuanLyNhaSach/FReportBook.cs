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
    public partial class FReportBook : Form
    {
        public FReportBook()
        {
            InitializeComponent();
        }

      
        public bool CheckReportCount(int month, int year)
        {
            return ReportCountDAO.Instance.CheckReportCount(month, year);
        }
        public void LoadReportCount(int month, int year)
        {
            dtgvReportBook.DataSource = ReportCountDAO.Instance.LoadReportCount(month, year);
            for (int i = 0; i < dtgvReportBook.Rows.Count; i++)
            {
                dtgvReportBook.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public void CreateReportCount(int month, int year)
        {
            List<Book> listBook = BookDAO.Instance.GetListBook();
            List<ImportBookInfo> listImportBookInfo = ImportBookInfoDAO.Instance.GetListImportBookInfoByTime(month, year);// trong thang xu ly
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfoByTime(month, year); // trong thang xu ly

            foreach (Book book in listBook)
            {
                int firstCount = 0;
                int lastCount = 0;
                int addCount = 0;
                int countBookInBill = 0;

                foreach (BillInfo item in listBillInfo)
                {
                    if (item.IdBook == book.ID)
                    {
                        countBookInBill += item.Count;
                    }
                }
                foreach (ImportBookInfo item in listImportBookInfo)
                {
                    if (item.IDBook == book.ID)
                    {
                        addCount += item.Count;
                    }
                }

                DateTime date = (new DateTime(year, month, 1)).AddMonths(-1); // thang truoc
                if (ReportCountDAO.Instance.CheckReportCount(date.Month, date.Year))
                {
                    ReportCount rp = ReportCountDAO.Instance.GetReportCountInfoByTimeAndBookID(date.Month, date.Year, book.ID);
                    if (rp != null)
                        firstCount = rp.LastCount;
                    else
                        firstCount = 0;
                }
                else
                {
                    firstCount = 0;
                }
                lastCount = firstCount + addCount - countBookInBill;

                if (!ReportCountDAO.Instance.InsertReportCount(month, year, book.ID, firstCount, addCount, lastCount))
                {
                    MessageBox.Show("Có lỗi khi tạo báo cáo tháng!", "Thông báo");
                    return;
                }
            }

        }
        private void btnReportBook_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTime date = new DateTime((int)nmYear.Value, (int)nmMonth.Value, 1);

                if (date > today)
                {
                    MessageBox.Show("Thời gian không hợp lệ !", "Thông báo");
                    return;
                }

                if (CheckReportCount(date.Month, date.Year))
                {
                    LoadReportCount(date.Month, date.Year);
                }
                else
                {
                    if (today.Month == date.Month && today.Year == date.Year)
                    {
                        MessageBox.Show("Chưa có báo cáo trong tháng này !", "Thông báo");
                        return;
                    }
                    else
                    {
                        CreateReportCount(date.Month, date.Year);
                        LoadReportCount(date.Month, date.Year);
                    }
                }

                btnReportBook.Tag = 1;
            }
            catch { MessageBox.Show("Tác vụ bị lỗi !", "Thông báo"); }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (btnReportBook.Tag == null)
            {
                MessageBox.Show("Bạn chưa thông kê báo cáo nào cả !", "Thông báo");
                return;
            }
            string name = "BAOCAOTON" + nmMonth.Value.ToString() + "_" + nmYear.Value.ToString() + ".pdf";
            try
            {
                List<Phrase> data = new List<Phrase>()
                {
                    ExportDataToPDF.Instance.GetPhraseHeader("BÁO CÁO TỒN\n"),
                    ExportDataToPDF.Instance.GetPhrase("Tháng/Năm: "+nmMonth.Value.ToString()+"/"+nmYear.Value.ToString()),
                };
                string path=ExportDataToPDF.Instance.ExportDataToPdf(name, data, ExportDataToPDF.Instance.GetTable(dtgvReportBook));
                if (path != "")
                {
                    if (MessageBox.Show("In thành công ! Bạn có muốn mở file ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Process.Start(path);
                }
                else
                {
                    MessageBox.Show("In thất bại !", "Thông báo");
                }
            }
            catch { MessageBox.Show("In thất bại ", "Thông báo"); }
        }

    }
}
