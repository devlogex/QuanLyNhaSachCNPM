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
                for (int j = 0; j < tableAuthor.Rows.Count - 1; j++)
                {
                    author += tableAuthor.Rows[j]["name"].ToString() + ",";
                }
                if (tableAuthor.Rows.Count > 0)
                    author += tableAuthor.Rows[tableAuthor.Rows.Count - 1]["name"].ToString();
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
            List<Author> authors = AuthorDAO.Instance.GetListAuthorByBookTitleID(id);
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
                if (DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddAuthorInfoByBookTitleID @id , @idAuthor", new object[] { id, idAuthor }) == 0)
                    return false;
            }
            return true;
        }
        public bool RemoveBookTitleByBookTitleID(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_RemoveBookTitleByBookTitleID @id", new object[] { id }) > 0;
        }
       public List<BookTitle>GetListBookTitle()
        {
            List<BookTitle> list = new List<BookTitle>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBookTitle");
            foreach (DataRow item in data.Rows)
            {
                List<Author> authors = AuthorDAO.Instance.GetListAuthorByBookTitleID(Int32.Parse(item["id"].ToString()));
                list.Add(new BookTitle(item, authors));
            }
            return list;
        }
        public int GetNewIDBookTitle()
        {
            int id;
            if (Int32.TryParse(DataProvider.Instance.ExecuteQuery("EXEC USP_GetNewIDBookTitle").Rows[0][0].ToString(), out id))
            {
                return id;
            }
            else
                return 1;
        }
        public List<int> SearchBookTitleByName(string name)
        {
            List<int> list = new List<int>();
            DataTable data = DataProvider.Instance.ExecuteQuery(String.Format("SELECT MaDauSach as id FROM DAUSACH WHERE dbo.fuConvertToUnsign1(TenDauSach) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name));
            foreach (DataRow item in data.Rows)
            {
                list.Add(Int32.Parse(item["id"].ToString()));
            }
            return list;
        }
    }
}


