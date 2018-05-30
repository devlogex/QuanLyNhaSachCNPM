using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class CollectMoney
    {
        private int iD;
        private int idCustomer;
        private DateTime date;
        private float money;

        public int ID { get => iD; set => iD = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public DateTime Date { get => date; set => date = value; }
        public float Money { get => money; set => money = value; }

        public CollectMoney(int id,int idCustomer,DateTime date,float money)
        {
            this.ID = id;
            this.IdCustomer = idCustomer;
            this.Date = date;
            this.Money = money;
        }
        public CollectMoney(DataRow row)
        {
            this.ID = Int32.Parse(row["id"].ToString());
            this.IdCustomer = Int32.Parse(row["idCustomer"].ToString());
            this.Date = (DateTime)row["date"];
            this.Money = (float)Double.Parse(row["money"].ToString());
        }
    }
}
