using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ThamSoDAO
    {
        private static ThamSoDAO instance;

        public static ThamSoDAO Instance
        {
            get { if (instance == null) instance = new ThamSoDAO(); return instance; }
            set => instance = value;
        }
        private ThamSoDAO() { }

        public int GetMinImport()
        {
            DataTable data= DataProvider.Instance.ExecuteQuery("EXEC USP_GetMinImport");
            return Int32.Parse(data.Rows[0]["GiaTri"].ToString());
            
        }
        public bool SetMinImport(int minImport)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_SetMinImport @minImport", new object[] { minImport }) > 0;
        }
        public int GetMaxCount()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetMaxCount");
            return Int32.Parse(data.Rows[0]["GiaTri"].ToString());
        }
        public bool SetMaxCount(int maxCount)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_SetMaxCount @maxCount", new object[] { maxCount }) > 0;
        }
        public int GetMinCount()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetMinCount");
            return Int32.Parse(data.Rows[0]["GiaTri"].ToString());
        }
        public bool SetMinCount(int minCount)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_SetMinCount @minCount", new object[] { minCount }) > 0;
        }
        public float GetMaxOwe()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetMaxOwe");
            return Int32.Parse(data.Rows[0]["GiaTri"].ToString());
        }
        public bool SetMaxOwe(float maxOwe)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_SetMaxOwe @maxOwe", new object[] { maxOwe }) > 0;
        }
        public float GetPercentPrice()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetPercentPrice");
            return (float)Double.Parse(data.Rows[0]["GiaTri"].ToString());
        }
        public bool SetPercentPrice(float perCentPrice)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_SetPercentPrice @percentPrice", new object[] { perCentPrice }) > 0;
        }
        public bool GetCheck()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetCheck");
            return Int32.Parse(data.Rows[0]["GiaTri"].ToString())==1;
        }
        public bool SetCheck(int check)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_SetCheck @check", new object[] { check }) > 0;
        }
    }
}
