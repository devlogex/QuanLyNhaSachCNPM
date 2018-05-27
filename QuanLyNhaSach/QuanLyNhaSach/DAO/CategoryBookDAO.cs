using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class CategoryBookDAO
    {
        private static CategoryBookDAO instance;

        public static CategoryBookDAO Instance
        {
            get {if (instance == null) instance = new CategoryBookDAO(); return instance; }
            set => instance = value;
        }
        private CategoryBookDAO() { }

        public List<CategoryBook> GetListCategory()
        {
            List<CategoryBook> list = new List<CategoryBook>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListCategory");
            foreach(DataRow item in data.Rows)
            {
                list.Add(new CategoryBook(item));
            }
            return list;
        }
        public bool AddCategory(string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddCategory @name", new object[] { name }) > 0;
        }
        public bool RemoveCategoryByCategoryID(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_RemoveCategoryByCategoryID @id", new object[] { id }) > 0;
        }
        public bool UpdateCategory(int id,string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateCategory @id , @name", new object[] { id, name }) > 0;
        }
        public CategoryBook GetCategoryBookByBookTitleID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetCategoryBookByBookTitleID @id", new object[] { id });
            if (data.Rows.Count > 0)
                return new CategoryBook(data.Rows[0]);
            else
                return null;
        }
    }
}
