using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class BookTitle
    {
        private int iD;
        private string name;
        private int idCategory;
        private List<Author> authors;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public List<Author> Authors { get => authors; set => authors = value; }

        public BookTitle(DataRow row,List<Author>authors)
        {
            this.ID = Int32.Parse(row["id"].ToString());
            this.name = row["name"].ToString();
            this.IdCategory =Int32.Parse(row["idCategory"].ToString());
            this.Authors = authors;
        }
    }
}
