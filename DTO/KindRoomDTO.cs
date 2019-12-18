using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kindRoomDTO
{
    public class KindRoomDTO
    {
        private string iDKR;
        private string nAME;
        private int bedsAMOUNT;
        private string nOTE;

        public string IDKR { get => iDKR; set => iDKR = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public int BedsAMOUNT { get => bedsAMOUNT; set => bedsAMOUNT = value; }
        public string NOTE { get => nOTE; set => nOTE = value; }
    }
}