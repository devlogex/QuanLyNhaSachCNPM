using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Bill
    {
        private int iD;
        private int idCustomer;
        private DateTime date;
        private float value;
        private float owe;

        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public DateTime Date { get => date; set => date = value; }
        public float Value { get => value; set => this.value = value; }
        public int ID { get => iD; set => iD = value; }
        public float Owe { get => owe; set => owe = value; }

        public Bill(int id,int idCustomer,DateTime date,float value,float owe)
        {
            this.ID = id;
            this.IdCustomer = idCustomer;
            this.Date = date;
            this.Value = value;
            this.Owe = owe;
        }
        public Bill(DataRow row)
        {
            this.ID = Int32.Parse(row["id"].ToString());
            this.IdCustomer = Int32.Parse(row["idCustomer"].ToString());
            this.Date = (DateTime)row["date"];
            this.Value = (float)Double.Parse(row["value"].ToString());
            this.Owe = (float)Double.Parse(row["owe"].ToString());
            if (this.Owe < 0)
                this.Owe = 0;
        }
    }
}
