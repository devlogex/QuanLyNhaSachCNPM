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
        public int GetNewIDCustomer()
        {
            int id;
            if (Int32.TryParse(DataProvider.Instance.ExecuteQuery("EXEC USP_GetNewIDCustomer").Rows[0][0].ToString(), out id))
            {
                return id;
            }
            else
                return 1;
        }
        public List<Customer> SearchCustomerByName(string name)
        {
            List<Customer> list = new List<Customer>();
            DataTable data = DataProvider.Instance.ExecuteQuery(String.Format("SELECT MaKhachHang as id,TenKhachHang as name,DiaChi as address, SoDienThoai as phoneNumber, Email as email, SoTienNo as owe FROM KHACHHANG WHERE dbo.fuConvertToUnsign1(TenKhachHang) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name));
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Customer(item));
            }
            return list;
        }
    }
}
