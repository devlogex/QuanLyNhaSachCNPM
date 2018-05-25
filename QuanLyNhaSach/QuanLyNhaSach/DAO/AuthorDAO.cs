using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class AuthorDAO
    {
        private static AuthorDAO instance;

        public static AuthorDAO Instance
        {
            get { if (instance == null) instance = new AuthorDAO(); return instance; }
            set => instance = value;
        }
        private AuthorDAO() { }
        
        public List<Author>GetListAuthor()
        {
            List<Author> list = new List<Author>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListAuthor");
            foreach(DataRow item in data.Rows)
            {
                list.Add(new Author(item));
            }
            return list;
        }
        public bool AddAuthor(string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddAuthor @name",new object[] { name })>0;
        }
        public bool RemoveAuthorByAuthorID(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_RemoveAuthorByAuthorID @id", new object[] { id }) > 0;
        }
        public bool UpdateAuthor(int id,string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAuthor @id , @name", new object[] { id, name }) > 0;
        }
    }
}
