using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ReportCountDAO
    {
        private static ReportCountDAO instance;
        public static ReportCountDAO Instance
        {
            get { if (instance == null) instance = new ReportCountDAO(); return instance; }
            set => instance = value;
        }
        private ReportCountDAO() { }
        public bool CheckReportCount(int month, int year)
        {
            return (DataProvider.Instance.ExecuteQuery("EXEC USP_GetReportCount @month , @year", new object[] { month, year })).Rows.Count > 0;
        }
        public DataTable LoadReportCount(int month, int year)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LoadReportCount @month , @year", new object[] { month, year });
            return data;
        }
        public bool InsertReportCount(int month, int year)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertReportCount @month , @year", new object[] { month, year }) > 0;
        }
        public void RemoveReportCount(int month,int year)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_RemoveReportCount @month , @year", new object[] { month, year });
        }
    }
}
