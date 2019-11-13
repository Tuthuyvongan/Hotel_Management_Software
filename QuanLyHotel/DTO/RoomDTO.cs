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
        private int nBED;
        
        private string nAME;
        private string sTATUS;
        private string nOTE;

        private Decimal cOST;


        public int IDR { get => iDR; set => iDR = value; }
        
        public string NAME { get => nAME; set => nAME = value; }
        public string STATUS { get => sTATUS; set => sTATUS = value; }
        public Decimal COST { get => cOST; set => cOST = value; }
        public int NBED { get => nBED; set => nBED = value; }
        public string NOTE { get => nOTE; set => nOTE = value; }
    }
}
