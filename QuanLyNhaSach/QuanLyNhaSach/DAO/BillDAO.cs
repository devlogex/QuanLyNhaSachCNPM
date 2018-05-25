using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            set => instance = value;
        }
        private BillDAO() { }

        public bool InsertBill(Customer customer,DateTime date,float value,float owe)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBillIntoDatabase @idCustomer , @date , @value , @owe", new object[] { customer.ID,date,value , owe }) > 0;
        }
        public List<Bill> GetListBillByTime(int month,int year)
        {
            List<Bill> list = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByTime @month , @year", new object[] { month, year });
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Bill(item));
            }
            return list;
        }
        public DataTable GetListBill()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBill");
        }
    }
}
