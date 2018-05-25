using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get{ if (instance == null) instance = new BillInfoDAO(); return instance; }
            set => instance = value;
        }
        private BillInfoDAO() { }

        public bool InsertBillInfo(int idBook,int count,float priceOut)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBillInfoIntoDatabase @idBook , @count , @priceOut", new object[] { idBook,count,priceOut }) > 0;
        }
        public List<BillInfo> GetListBillInfoByTime(int month,int year)
        {
            List<BillInfo> list = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillInfoByTime @month , @year", new object[] { month, year });
            foreach (DataRow item in data.Rows)
            {
                list.Add(new BillInfo(item));
            }
            return list;
        }
        public DataTable LoadListBillInfo(int id)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_LoadListBillInfo @id", new object[] { id });
        }
    }
}
