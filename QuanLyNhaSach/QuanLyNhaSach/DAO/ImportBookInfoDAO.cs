using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ImportBookInfoDAO
    {
        private static ImportBookInfoDAO instance;

        public static ImportBookInfoDAO Instance
        {
            get { if (instance == null) instance = new ImportBookInfoDAO(); return instance; }
            set => instance = value;
        }
        private ImportBookInfoDAO() { }

        public bool InsertImportBookInfo(int idBook,int count,float priceIn)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertImportBookInfoIntoDatabase @idBook , @count , @priceIn", new object[] {idBook,count,priceIn}) > 0;
        }
        public List<ImportBookInfo> GetListImportBookInfoByTime(int month,int year)
        {
            List<ImportBookInfo> list = new List<ImportBookInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListImportBookInfoByTime @month , @year", new object[] { month, year });
            foreach(DataRow item in data.Rows)
            {
                list.Add(new ImportBookInfo(item));
            }
            return list;
        }
        public DataTable LoadListImportBookInfo(int id)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_LoadListImportBookInfo @id", new object[] { id });
        }

    }
}
