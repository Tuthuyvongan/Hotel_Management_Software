using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billDTO
{
    public class BillDTO
    {
        private int iDB;
        private string checkIn;
        private string checkOut;
        private Decimal cOST;

        public int IDB { get => iDB; set => iDB = value; }
        public string CheckIn { get => checkIn; set => checkIn = value; }
        public string CheckOut { get => checkOut; set => checkOut = value; }
        public Decimal COST { get => cOST; set => cOST = value; }
    }
}
