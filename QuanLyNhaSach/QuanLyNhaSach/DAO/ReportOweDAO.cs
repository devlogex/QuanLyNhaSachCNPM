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
        public DataTable LoadReportOwe(int month,int year)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_LoadReportOwe @month , @year", new object[] { month, year });
        }

        public ReportOwe GetReportOweInfoByTimeAndCustomerID(int month, int year, int idCustomer)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetReportOweByTimeAndCustomerID @month , @year , @idCustomer", new object[] { month, year, idCustomer });
            if (data.Rows.Count > 0)
                return new ReportOwe(data.Rows[0]);
            else
                return null;
        }
        public bool InsertReportOwe(int month, int year, int idCustomer, float firstOwe, float addOwe, float lastOwe)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertReportOwe @month , @year , @idCustomer , @firstOwe , @addOwe , @lastOwe", new object[] { month, year, idCustomer, firstOwe, addOwe, lastOwe }) > 0;
        }

    }
}
