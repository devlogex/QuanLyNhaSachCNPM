using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class CategoryBook
    {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public CategoryBook(int id,string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public CategoryBook(DataRow row)
        {
            this.ID = Int32.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
        }
    }
}
