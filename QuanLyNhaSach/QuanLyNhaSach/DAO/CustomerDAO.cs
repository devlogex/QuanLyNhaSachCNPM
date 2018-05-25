using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            set => instance = value;
        }
        private CustomerDAO() { }

        public List<Customer> GetListCustomer()
        {
            List<Customer> list = new List<Customer>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListCustomer");
            foreach(DataRow item in data.Rows)
            {
                list.Add(new Customer(item));
            }
            return list;
        }
        public bool AddCustomer(string name, string address, string phonenumber, string email, float owe)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddCustomer @name , @address , @phoneNumber , @email , @owe", new object[] { name, address, phonenumber, email, owe }) > 0;
        }
        public bool UpdateCustomer(int id,string name, string address, string phonenumber, string email, float owe)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateCustomer @id , @name , @address , @phoneNumber , @email , @owe", new object[] {id, name, address, phonenumber, email, owe }) > 0;
        }
        public bool RemoveCustomerByCustomerID(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_RemoveCustomerByCustomerID @id", new object[] { id}) > 0;
        }
        public Customer GetCustomerByCustomerID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetCustomerByCustomerID @id", new object[] { id });
            Customer customer=new Customer(data.Rows[0]);

            return customer;
        }
        public List<Customer> SearchCustomerByName(string name)
        {
            List<Customer> list = new List<Customer>();
            DataTable data = DataProvider.Instance.ExecuteQuery(String.Format("SELECT * FROM Customer WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name));
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Customer(item));
            }
            return list;
        }
        public List<Customer> SearchCustomerByPhoneNumber(string phoneNumber)
        {
            List<Customer> list = new List<Customer>();
            DataTable data = DataProvider.Instance.ExecuteQuery(String.Format("SELECT * FROM Customer WHERE phoneNumber='"+phoneNumber+"'"));
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Customer(item));
            }
            return list;
        }
        public List<int> GetListCustomerID()
        {
            List<int> list = new List<int>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListCustomerID");
            foreach (DataRow item in data.Rows)
            {
                list.Add((int)item[0]);
            }
            return list;
        }
    }
}
