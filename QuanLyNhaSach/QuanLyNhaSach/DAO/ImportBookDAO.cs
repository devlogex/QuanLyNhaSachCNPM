using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ImportBookDAO
    {
        private static ImportBookDAO instance;

        public static ImportBookDAO Instance
        {
            get { if (instance == null) instance = new ImportBookDAO(); return instance; }
            set => instance = value;
        }
        private ImportBookDAO() { }

       public bool InsertImportBook(DateTime date)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertImportBookIntoDatabase @date", new object[] { date }) > 0;
        }
        public List<ImportBook> GetListImportBook()
        {
            List<ImportBook> list = new List<ImportBook>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListImportBook");
            foreach(DataRow item in data.Rows)
            {
                list.Add(new ImportBook(item));
            }
            return list;
        }
    }
}
