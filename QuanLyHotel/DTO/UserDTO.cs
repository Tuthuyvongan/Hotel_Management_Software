using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userDTO
{
    public class UserDTO
    {
        private string iDU;
        private string nAME;
        private string pASSWORD;
        private int lEVEL;

        public string IDU { get => iDU; set => iDU = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public string PASSWORD { get => pASSWORD; set => pASSWORD = value; }
        public int LEVEL { get => lEVEL; set => lEVEL = value; }
    }
}
