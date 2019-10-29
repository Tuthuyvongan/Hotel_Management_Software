using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomserviceDTO
{
    public class RoomServiceDTO
    {
        private int iDRS;
        private string tIME;
        private int nUMBER;
        private Decimal cOST;

        public int IDRS { get => iDRS; set => iDRS = value; }
        public string TIME { get => tIME; set => tIME = value; }
        public int NUMBER { get => nUMBER; set => nUMBER = value; }
        public Decimal COST { get => cOST; set => cOST = value; }

    }
}
