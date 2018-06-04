using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get
            {
                if (instance == null) instance = new BookDAO(); return instance;
            }
            set => instance = value;
        }
        private BookDAO() { }

        public DataTable LoadListBook()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC  USP_LoadListBook");
            return data;
        }
        public List<string> GetPublishingByBookTitleID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetPublishingByBookTitleID @id", new object[] { id });
            List<string> publishing = new List<string>();
            foreach (DataRow item in data.Rows)
            {
                publishing.Add("Nhà xuất bản " + item["publishCompany"].ToString() + ", năm " + item["publishYear"].ToString());
            }
            return publishing;
        }
        public bool AddBook(int idBookTitle,string publishCompany,int publishYear)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddBook @idBookTitle , @publishCompany , @publishYear", new object[] { idBookTitle, publishCompany, publishYear })>0;
        }
        public List<Book> GetListBook()
        {
            List<Book> list = new List<Book>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBook");

            foreach(DataRow item in data.Rows)
            {
                List<Author> authors = AuthorDAO.Instance.GetListAuthorByBookTitleID(Int32.Parse(item["idBookTitle"].ToString()));
                CategoryBook category = CategoryBookDAO.Instance.GetCategoryBookByBookTitleID(Int32.Parse(item["idBookTitle"].ToString()));
                list.Add(new Book(item, category, authors));
            }

            return list;
        }
        public int GetNewIDBook()
        {
            int id;
            if (Int32.TryParse(DataProvider.Instance.ExecuteQuery("EXEC USP_GetNewIDBook").Rows[0][0].ToString(), out id))
            {
                return id;
            }
            else
                return 1;
        }
    }
}
