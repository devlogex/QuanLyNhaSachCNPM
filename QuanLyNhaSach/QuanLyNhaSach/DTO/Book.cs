using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Book
    {
        private int iD;
        private string name;
        private int iDCategory;
        private string author;
        private float priceIn;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IDCategory { get => iDCategory; set => iDCategory = value; }
        public string Author { get => author; set => author = value; }
        public int Count { get => count; set => count = value; }
        public float PriceIn { get => priceIn; set => priceIn = value; }

        public Book(int id,string name,int idCategory,string author,int price,int count)
        {
            this.ID = id;
            this.Name = name;
            this.IDCategory = idCategory;
            this.Author = author;
            this.PriceIn = price;
            this.Count = count;
        }
        public Book(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IDCategory = (int)row["idCategory"];
            this.Author = row["author"].ToString();
            this.PriceIn = (float)Double.Parse(row["priceIn"].ToString());
            this.Count = (int)row["count"];
        }

    }
}
