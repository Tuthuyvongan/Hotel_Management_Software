using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kindRoomDTO
{
    public class KindRoomDTO
    {
        private int iDKR;
        private string nAME;
        private int numberOFBED;
        private string nOTE;

        public int IDKR { get => iDKR; set => iDKR = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public int NumberOFBED { get => numberOFBED; set => numberOFBED = value; }
        public string NOTE { get => nOTE; set => nOTE = value; }
    }
}