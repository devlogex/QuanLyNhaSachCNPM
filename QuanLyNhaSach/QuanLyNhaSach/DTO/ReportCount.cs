using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class ReportCount
    {
        private int month;
        private int year;
        private int idBook;
        private int firstCount;
        private int lastCount;
        private int addCount;

        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public int FirstCount { get => firstCount; set => firstCount = value; }
        public int LastCount { get => lastCount; set => lastCount = value; }
        public int AddCount { get => addCount; set => addCount = value; }
        public int IdBook { get => idBook; set => idBook = value; }

        public ReportCount(DataRow row)
        {
            this.Month = Int32.Parse(row["month"].ToString());
            this.Year = Int32.Parse(row["year"].ToString());
            this.IdBook = Int32.Parse(row["idBook"].ToString());
            this.FirstCount = Int32.Parse(row["firstCount"].ToString());
            this.LastCount = Int32.Parse(row["lastCount"].ToString());
            this.AddCount = Int32.Parse(row["addCount"].ToString());
        }
    }
}
