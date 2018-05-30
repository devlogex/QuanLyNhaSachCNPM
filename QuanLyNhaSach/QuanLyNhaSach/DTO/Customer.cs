using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Customer
    {
        private int iD;
        private string name;
        private string address;
        private string phonenumber;
        private string email;
        private float owe;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Email { get => email; set => email = value; }
        public float Owe { get => owe; set => owe = value; }

        public Customer(int id,string name,string address,string phonenumber,string email,float owe)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Phonenumber = phonenumber;
            this.Email = email;
            this.Owe = owe; ;
        }
        public Customer(DataRow row)
        {
            this.ID = Int32.Parse(row["id"].ToString());
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString(); ;
            this.Phonenumber = row["phonenumber"].ToString();
            this.Email = row["email"].ToString() ;
            this.Owe = (float)Double.Parse(row["owe"].ToString());
        }
    }
}
