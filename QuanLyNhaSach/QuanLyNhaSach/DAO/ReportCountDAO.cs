using QuanLyNhaSach.DTO;
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
            return (DataProvider.Instance.ExecuteQuery("EXEC USP_GetReportCountByTime @month , @year", new object[] { month, year })).Rows.Count > 0;
        }
        public DataTable LoadReportCount(int month, int year)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LoadReportCount @month , @year", new object[] { month, year });
            return data;
        }

        public void RemoveReportCount(int month,int year)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_RemoveReportCount @month , @year", new object[] { month, year });
        }
        public ReportCount GetReportCountInfoByTimeAndBookID(int month,int year,int idBook)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetReportCountByTimeAndBookID @month , @year , @idBook", new object[] { month, year, idBook });
            if (data.Rows.Count == 0)
                return null;
            else
                return new ReportCount(data.Rows[0]);
        }
        public bool InsertReportCount(int month,int year,int idBook,int firstCount,int addCount,int lastCount)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC  USP_InsertReportCount @month , @year , @idBook , @firstCount , @addCount , @lastCount", new object[] { month, year, idBook, firstCount, addCount, lastCount }) > 0;
        }


    }
}
