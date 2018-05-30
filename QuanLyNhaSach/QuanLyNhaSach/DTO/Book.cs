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
        private int idBookTitle;
        private string publishCompany;
        private string publishYear;
        private CategoryBook category;
        private List<Author> authors;
        private float priceIn;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IdBookTitle { get => idBookTitle; set => idBookTitle = value; }
        public string PublishCompany { get => publishCompany; set => publishCompany = value; }
        public string PublishYear { get => publishYear; set => publishYear = value; }
        public CategoryBook Category { get => category; set => category = value; }
        public float PriceIn { get => priceIn; set => priceIn = value; }
        public int Count { get => count; set => count = value; }
        public List<Author> Authors { get => authors; set => authors = value; }

        public Book(DataRow row,CategoryBook category,List<Author>authors)
        {
            this.ID = Int32.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.PriceIn = (float)Double.Parse(row["priceIn"].ToString());
            this.Count = Int32.Parse(row["count"].ToString());
            this.IdBookTitle = Int32.Parse(row["idBookTitle"].ToString());
            this.PublishCompany = row["publishCompany"].ToString();
            this.PublishYear = row["publishYear"].ToString();
            this.Category = category;
            this.Authors = authors;
        }

    }
}
