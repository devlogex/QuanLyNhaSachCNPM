using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get{ if (instance == null) instance = new BillInfoDAO(); return instance; }
            set => instance = value;
        }
        private BillInfoDAO() { }

        public bool InsertBillInfo(int idBook,int count,float priceOut,float totalPrice)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBillInfoIntoDatabase @idBook , @count , @priceOut , @totalPrice", new object[] { idBook,count,priceOut,totalPrice }) > 0;
        }
        public List<BillInfo> GetListBillInfoByTime(int month,int year)
        {
            List<BillInfo> list = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillInfoByTime @month , @year", new object[] { month, year });
            foreach (DataRow item in data.Rows)
            {
                list.Add(new BillInfo(item));
            }
            return list;
        }
        public DataTable LoadListBillInfo(int id)
        {
            DataTable data= DataProvider.Instance.ExecuteQuery("EXEC USP_LoadListBillInfo @id", new object[] { id });

            data.Columns.Add("author");
            data.Columns.Add("publishing");
            foreach(DataRow row in data.Rows)
            {
                int idBookTitle = Int32.Parse(row["idBookTitle"].ToString());

                string author = "";
                List<Author> listAuthor = AuthorDAO.Instance.GetListAuthorByBookTitleID(idBookTitle); ;
                for (int j = 0; j < listAuthor.Count - 1; j++)
                {
                    author += listAuthor[j].Name+ ", ";
                }
                if (listAuthor.Count > 0)
                    author += listAuthor[listAuthor.Count-1].Name;
                row["author"] = author;

                int idBook = Int32.Parse(row["id"].ToString());
                string publishing = "";
                DataTable tablePublish = DataProvider.Instance.ExecuteQuery("EXEC USP_GetPublishingByBookID @id", new object[] { idBook });
                if(tablePublish.Rows.Count>0)
                    publishing += tablePublish.Rows[0]["publishCompany"].ToString() + ", năm " + tablePublish.Rows[0]["publishYear"].ToString();
                row["publishing"] = publishing;
            }

            return data;
        }
    }
}
