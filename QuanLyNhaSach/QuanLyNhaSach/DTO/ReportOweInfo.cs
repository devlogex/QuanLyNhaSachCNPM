using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class ReportOweInfo
    {
        private int month;
        private int year;
        private int idCustomer;
        private float firstOwe;
        private float lastOwe;
        private float addOwe;

        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public float FirstOwe { get => firstOwe; set => firstOwe = value; }
        public float LastOwe { get => lastOwe; set => lastOwe = value; }
        public float AddOwe { get => addOwe; set => addOwe = value; }

        public ReportOweInfo(DataRow row)
        {
            this.Month = (int)row["month"];
            this.Year = (int)row["year"];
            this.IdCustomer = (int)row["idCustomer"];
            this.FirstOwe = (float)Double.Parse(row["firstOwe"].ToString());
            this.LastOwe = (float)Double.Parse(row["lastOwe"].ToString());
            this.AddOwe = (float)Double.Parse(row["addOwe"].ToString());
        }
    }
}
