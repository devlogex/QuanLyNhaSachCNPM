using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class ReportCountInfo
    {
        private int month;
        private int year;
        private int idBook;
        private int firstCount;
        private int lastCount;
        private int addCount;

        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public int IdBook { get => idBook; set => idBook = value; }
        public int FirstCount { get => firstCount; set => firstCount = value; }
        public int LastCount { get => lastCount; set => lastCount = value; }
        public int AddCount { get => addCount; set => addCount = value; }

        public ReportCountInfo(int month, int year, int idBook, int firstCount, int lastCount, int addCount)
        {
            this.Month = month;
            this.Year = year;
            this.IdBook = idBook;
            this.FirstCount = firstCount;
            this.LastCount = lastCount;
            this.AddCount = addCount;
        }
        public ReportCountInfo(DataRow row)
        {
            this.Month = (int)row["month"];
            this.Year = (int)row["year"];
            this.IdBook = (int)row["idBook"];
            this.FirstCount = (int)row["firstCount"];
            this.LastCount = (int)row["lastCount"];
            this.AddCount = (int)row["addCount"];
        }

    }
}
