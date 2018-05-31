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

        public int GetNewIDBill()
        {
            int id;
            if (Int32.TryParse(DataProvider.Instance.ExecuteQuery("EXEC USP_GetNewIDBill").Rows[0][0].ToString(), out id))
            {
                return id;
            }
            else
                return 1;
        }

        public bool InsertBill(Customer customer, DateTime date, float totalMoney, float receiveMoney,float moneyOwe)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBillIntoDatabase @idCustomer , @date , @totalMoney , @receiveMoney , @moneyOwe", new object[] { customer.ID, date, totalMoney, receiveMoney,moneyOwe }) > 0;
        }
        public List<Bill> GetListBillByTime(int month, int year)
        {
            List<Bill> list = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByTime @month , @year", new object[] { month, year });
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Bill(item));
            }
            return list;
        }
        public DataTable GetListBillByCustomerID(int id)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByCustomerID @id",new object[] { id });
        }
    }
}
