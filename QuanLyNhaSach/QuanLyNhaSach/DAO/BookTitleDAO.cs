using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BookTitleDAO
    {
        private static BookTitleDAO instance;

        public static BookTitleDAO Instance
        {
            get { if (instance == null) instance = new BookTitleDAO(); return instance; }
            set => instance = value;
        }
        private BookTitleDAO() { }
        
        public DataTable LoadListBookTitle()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LoadListBookTitle");

            data.Columns.Add("author");
            data.Columns.Add("countVersion");
            data.Columns.Add("totalCount");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                int id = Int32.Parse(data.Rows[i]["id"].ToString());

                string author = "";
                DataTable tableAuthor = DataProvider.Instance.ExecuteQuery("EXEC USP_GetAuthorsByBookTitleID @id", new object[] { id });
                foreach (DataRow row in tableAuthor.Rows)
                {
                    author += row["name"].ToString() + ", ";
                }
                data.Rows[i]["author"] = author;

                DataTable tableCountVerion = DataProvider.Instance.ExecuteQuery("EXEC USP_GetCountVersionByBookTitleID @id", new object[] { id });
                data.Rows[i]["countVersion"] = Int32.Parse(tableCountVerion.Rows[0][0].ToString());

                int totalCount = 0;
                DataTable tableTotalCount = DataProvider.Instance.ExecuteQuery("EXEC USP_GetTotalCountByBookTitleID @id", new object[] { id });
                if (Int32.TryParse(tableTotalCount.Rows[0][0].ToString(), out totalCount))
                {
                    data.Rows[i]["totalCount"] = totalCount;
                }
                else
                {
                    data.Rows[i]["totalCount"] = 0;
                }
            }
            return data;
        }
        public bool AddBookTitle(string name, int idCategory, List<int> authors)
        {
            if (DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddBookTitle @name , @idCategory", new object[] { name, idCategory }) == 0)
            {
                return false;
            }
            foreach (int idAuthor in authors)
            {
                if (DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddAuthorInfo @idAuthor", new object[] { idAuthor }) == 0)
                    return false;
            }
            return true;
        }
        public BookTitle GetBookTitleByBookTitleID(int id)
        {
            DataTable dataBookTitle = DataProvider.Instance.ExecuteQuery("EXEC USP_GetBookTitleByBookTitleID @id", new object[] { id });

            List<Author> authors = new List<Author>();
            DataTable dataAuthor = DataProvider.Instance.ExecuteQuery("EXEC USP_GetAuthorsByBookTitleID @id", new object[] { id });
            foreach(DataRow item in dataAuthor.Rows)
            {
                authors.Add(new Author(item));
            }

            return new BookTitle(dataBookTitle.Rows[0], authors);
            
        }
        public bool UpdateBookTitle(int id,string name,int idCategory,List<int>authors)
        {
            if (DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateBookTitle @id , @name , @idCategory", new object[] { id, name, idCategory }) == 0)
            {
                return false;
            }
            foreach (int idAuthor in authors)
            {
                if (DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddAuthorInfo @idAuthor", new object[] { idAuthor }) == 0)
                    return false;
            }
            return true;
        }
        public bool RemoveBookTitleByBookTitleID(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_RemoveBookTitleByBookTitleID @id", new object[] { id }) > 0;
        }
    }
}
