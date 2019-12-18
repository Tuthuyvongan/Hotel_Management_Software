using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomserviceDTO
{
    public class RoomServiceDTO
    {
        private string iDR_S;
        private string iDR;
        private string iDS;
        private DateTime tIME;
        private int nUMBER;
        private Decimal cOST;

        public string IDR_S { get => iDR_S; set => iDR_S = value; }
        public string IDR { get => iDR; set => iDR = value; }
        public string IDS { get => iDS; set => iDS = value; }
        public DateTime TIME { get => tIME; set => tIME = value; }
        public int NUMBER { get => nUMBER; set => nUMBER = value; }
        public Decimal COST { get => cOST; set => cOST = value; }

    }
}
