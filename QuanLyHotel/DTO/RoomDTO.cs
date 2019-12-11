using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomDTO
{
    public class RoomDTO
    {
        private string iDR;
        private string iDRK;     
        private string nAME;
        private string sTATUS;
        private Decimal cOST;


        public string IDR { get => iDR; set => iDR = value; }
        public string IDRK { get => iDRK; set => iDRK = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public string STATUS { get => sTATUS; set => sTATUS = value; }
        public Decimal COST { get => cOST; set => cOST = value; }
        
    }
}
