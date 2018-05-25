using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class CollectMoneyDAO
    {
        private static CollectMoneyDAO instance;

        public static CollectMoneyDAO Instance
        {
            get
            {
                if (instance == null) instance = new CollectMoneyDAO(); return instance;
            }
            set => instance = value;
        }
        private CollectMoneyDAO() { }
        
        public bool SaveCollectMoney(int idCustomer,DateTime date,float moneyCollect)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertCollectMoneyIntoDatabase @idCustomer , @date , @money", new object[] { idCustomer,date,moneyCollect }) > 0;
        }
        public List<CollectMoney> GetListCollectMoneyByTime(int month,int year)
        {
            List<CollectMoney> list = new List<CollectMoney>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListCollectMoneyByTime @month , @year", new object[] { month, year });
            foreach (DataRow item in data.Rows)
            {
                list.Add(new CollectMoney(item));
            }
            return list;
        }
    }
}
