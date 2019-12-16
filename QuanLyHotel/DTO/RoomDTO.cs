using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomDTO
{
    public class RoomDTO
    {
        private string idr;
        private string name;
        private string status;
        private decimal cost;
        private int bedamount;
        private string roomkind;

        //public RoomDTO(DataRow row)
        //{
        //    this.Idr = row["idr"].ToString();
        //    this.Name = row["name"].ToString();
        //    this.Status = row["status"].ToString();
        //    this.Cost = (decimal)row["cost"];
        //    this.Bedamount = (int)row["bedamount"];
        //    this.Roomkind = row["romkind"].ToString();
        //}
        public string Idr { get => idr; set => idr = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public decimal Cost { get => cost; set => cost = value; }
        public int Bedamount { get => bedamount; set => bedamount = value; }
        public string Roomkind { get => roomkind; set => roomkind = value; }
    }
}
