﻿using iTextSharp.text;
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
    public partial class FReportOwe : Form
    {
        public FReportOwe()
        {
            InitializeComponent();
        }

  

        public bool CheckReportOwe(int month, int year)
        {
            return ReportOweDAO.Instance.CheckReportOwe(month, year);
        }
        public void LoadReportOwe(int month, int year)
        {
            dtgvReportOwe.DataSource = ReportOweDAO.Instance.LoadReportOwe(month, year);
            for (int i = 0; i < dtgvReportOwe.Rows.Count; i++)
            {
                dtgvReportOwe.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public void CreateReportOwe(int month, int year)
        {
            List<Customer> listCustomer = CustomerDAO.Instance.GetListCustomer();
            List<CollectMoney> listCollectMoney = CollectMoneyDAO.Instance.GetListCollectMoneyByTime(month, year);// trong thang xu ly
            List<Bill> listBill = BillDAO.Instance.GetListBillByTime(month, year); // trong thang xu ly

            foreach (Customer customer in listCustomer)
            {
                float firstOwe = 0;
                float lastOwe = 0;
                float addOwe = 0;
                float payInCollectMoney = 0;

                foreach (Bill item in listBill)
                {
                    if (item.IdCustomer == customer.ID)
                    {
                        addOwe += item.Owe;
                    }
                }
                foreach (CollectMoney item in listCollectMoney)
                {
                    if (item.IdCustomer == customer.ID)
                    {
                        payInCollectMoney += item.Money;
                    }
                }
                DateTime date = (new DateTime(year, month, 1)).AddMonths(-1); // thang truoc
                if (ReportOweDAO.Instance.CheckReportOwe(date.Month, date.Year))
                {
                    ReportOwe rp = ReportOweDAO.Instance.GetReportOweInfoByTimeAndCustomerID(date.Month, date.Year, customer.ID);
                    if (rp != null)
                        firstOwe = rp.LastOwe;
                    else
                        firstOwe = 0;
                }
                else
                {
                    firstOwe = 0;
                }
                lastOwe = firstOwe + addOwe - payInCollectMoney;

                if (!ReportOweDAO.Instance.InsertReportOwe(month, year, customer.ID, firstOwe, addOwe, lastOwe))
                {
                    MessageBox.Show("Có lỗi khi tạo báo cáo tháng!");
                    return;
                }
            }
        }
        private void btnReportOwe_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime date = new DateTime((int)nmYear.Value, (int)nmMonth.Value, today.Day);
            if (date > today)
            {
                MessageBox.Show("Thời gian không hợp lệ !");
                return;
            }

            if (CheckReportOwe(date.Month, date.Year))
            {
                LoadReportOwe(date.Month, date.Year);
            }
            else
            {
                if (today.Month == date.Month && today.Year == date.Year)
                {
                    if (today.Month == date.Month && today.Year == date.Year)
                    {
                        MessageBox.Show("Chưa có báo cáo trong tháng này !");
                        return;
                    }
                }
                else
                {
                    CreateReportOwe(date.Month, date.Year);
                    LoadReportOwe(date.Month, date.Year);
                }
            }
            btnReportOwe.Tag = 1;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (btnReportOwe.Tag == null)
            {
                MessageBox.Show("Bạn chưa thông kê báo cáo nào cả !");
                return;
            }
            string name = "BAOCAOCONGNO" + nmMonth.Value.ToString() + "_" + nmYear.Value.ToString() + ".pdf";
            try
            {
                List<Phrase> data = new List<Phrase>()
                {
                    ExportDataToPDF.Instance.GetPhraseHeader("BÁO CÁO CÔNG NỢ\n"),
                    ExportDataToPDF.Instance.GetPhrase("Tháng/Năm: "+nmMonth.Value.ToString()+"/"+nmYear.Value.ToString()),
                };
                ExportDataToPDF.Instance.ExportDataToPdf(name, data, ExportDataToPDF.Instance.GetTable(dtgvReportOwe));
                if (MessageBox.Show("In thành công ! Bạn có muốn mở file ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Process.Start(@"C:\Users\TND16\Documents\GitHub\QuanLyNhaSachCNPM\QuanLyNhaSach\QuanLyNhaSach\bin\Debug\" + name);
            }
            catch { MessageBox.Show("In thất bại "); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
