using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class BillInfo
    {
        private int idBill;
        private int idBook;
        private int count;
        private float priceOut;

        public int IdBill { get => idBill; set => idBill = value; }
        public int IdBook { get => idBook; set => idBook = value; }
        public int Count { get => count; set => count = value; }
        public float PriceOut { get => priceOut; set => priceOut = value; }

        public BillInfo(int idBill,int idBook,int count,float price)
        {
            this.IdBill = idBill;
            this.IdBook = idBook;
            this.Count = count;
            this.PriceOut = price;
        }
        public BillInfo(DataRow row)
        {
            this.IdBill = Int32.Parse(row["idBill"].ToString());
            this.IdBook = Int32.Parse(row["idBook"].ToString());
            this.Count = Int32.Parse(row["count"].ToString());
            this.PriceOut = (float)Double.Parse(row["priceOut"].ToString());
        }
    }
}
