using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ReportOweInfoDAO
    {
        private static ReportOweInfoDAO instance;

        public static ReportOweInfoDAO Instance
        {
            get { if (instance == null) instance = new ReportOweInfoDAO(); return instance; }
            set => instance = value;
        }
        private ReportOweInfoDAO() { }

        public ReportOweInfo GetReportOweInfoByTimeAndCustomerID(int month,int year,int idCustomer)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetReportOweInfoByTimeAndCustomerID @month , @year , @idCustomer", new object[] { month, year, idCustomer });
            if (data.Rows.Count > 0)
                return new ReportOweInfo(data.Rows[0]);
            else
                return null;
        }
        public bool InsertReportOweInfo(int month,int year,int idCustomer,float firstOwe,float addOwe,float lastOwe)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertReportOweInfo @month , @year , @idCustomer , @firstOwe , @lastOwe , @addOwe", new object[] { month, year, idCustomer, firstOwe, lastOwe, addOwe }) > 0;
        }
        public void RemoveAllReportOweInfoInTime(int month, int year)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_RemoveAllReportOweInfoInTime @month , @year", new object[] { month, year });
        }
    }
}
