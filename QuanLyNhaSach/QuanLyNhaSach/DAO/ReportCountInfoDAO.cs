using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ReportCountInfoDAO
    {
        private static ReportCountInfoDAO instance;
        public static ReportCountInfoDAO Instance
        {
            get { if (instance == null) instance = new ReportCountInfoDAO(); return instance; }
            set => instance = value;
        }
        private ReportCountInfoDAO() { }

        public bool InsertReportCountInfo(int month,int year,int idBook,int firstCount, int addCount, int lastCount )
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertReportCountInfo @month , @year , @idBook , @firstCount , @lastCount , @addCount", new object[] { month,  year,  idBook,  firstCount,  lastCount, addCount }) > 0;
        }
        public ReportCountInfo GetReportCountInfoByTimeAndBookID(int month,int year,int idBook)
        {
            DataTable data=DataProvider.Instance.ExecuteQuery("EXEC USP_GetReportCountInfoByTimeAndBookID @month , @year , @idBook", new object[] { month, year,idBook });
            if (data.Rows.Count > 0)
                return new ReportCountInfo(data.Rows[0]);
            else
                return null;
        }
        public void RemoveAllReportCountInfoInTime(int month,int year)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_RemoveAllReportCountInfoInTime @month , @year", new object[] { month, year });
        }
    }
}
