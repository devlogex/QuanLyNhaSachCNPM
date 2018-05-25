using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ReportOweDAO
    {
        private static ReportOweDAO instance;

        public static ReportOweDAO Instance
        {
            get { if (instance == null) instance = new ReportOweDAO(); return instance; }
            set => instance = value;
        }
        private ReportOweDAO() { }
        public bool CheckReportOwe(int month, int year)
        {
            return (DataProvider.Instance.ExecuteQuery("EXEC USP_GetReportOwe @month , @year", new object[] { month, year })).Rows.Count > 0;
        }
        public void RemoveReportOwe(int month,int year)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_RemoveReportOwe @month , @year", new object[] { month, year });
        }
        public DataTable LoadReportOwe(int month,int year)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_LoadReportOwe @month , @year", new object[] { month, year });
        }
        public bool InsertReportOwe(int month,int year)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertReportOwe @month , @year", new object[] { month, year }) > 0;
        }
    }
}
