using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            set => instance = value;
        }
        private AccountDAO() { }

        public bool Login(string userName,string passWord)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_Login @userName , @passWord",new object[] {userName,passWord });

            return data.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetAccountByUserName @userName", new object[] { userName });
            Account acc = new Account(data.Rows[0]);
            return acc;
        }
        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListAccount");
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Account(item));
            }
            return list;
        }
        public bool InsertAccount(string userName, string displayName, string passWord)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertAccount @userName , @displayName , @passWord ", new object[] { userName, displayName, passWord }) > 0;
        }
        public bool RemoveAccountByUserName(string userName)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_RemoveAccountByUserName @userName", new object[] { userName }) > 0;
        }
        public bool UpdateAccountByUserName(string userName, string displayName, string passWord)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccountByUserName @userName , @displayName , @passWord", new object[] { userName, displayName, passWord }) > 0;
        }
    }
}
