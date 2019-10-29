using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomDTO
{
    public class RoomDTO
    {
        private int iDR;
        private string nAME;
        private string sTATUS;
        private Decimal cOST;

        public int IDR { get => iDR; set => iDR = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public string STATUS { get => sTATUS; set => sTATUS = value; }
        public Decimal COST { get => cOST; set => cOST = value; }
    }
}
