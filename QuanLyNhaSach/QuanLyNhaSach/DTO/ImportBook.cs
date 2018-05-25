using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class ImportBook
    {
        private int iD;
        private DateTime date;

        public int ID { get => iD; set => iD = value; }
        public DateTime Date { get => date; set => date = value; }
        public ImportBook(int id,DateTime date)
        {
            this.ID = id;
            this.Date = date;
        }
        public ImportBook(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Date = (DateTime)row["date"];
        }
    }
}
