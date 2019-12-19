using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billDTO
{
    public class BillDTO
    {
        private string iDB;
        private string iDR;
        private string iDC;
        private DateTime checkIn;
        private DateTime checkOut;
        private Decimal cOST;

        public string IDB { get => iDB; set => iDB = value; }
        public string IDR { get => iDR; set => iDR = value; }
        public string IDC { get => iDC; set => iDC = value; }
        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public Decimal COST { get => cOST; set => cOST = value; }
    }
}
