using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDTO
{
    public class ManagerDTO
    {
        private string iDM;
        private string iDU;
        private string nAME;
        private string phoneNUMBER;
        private string eMAIL;

        public string IDM { get => iDM; set => iDM = value; }
        public string IDU { get => iDU; set => iDU = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public string PhoneNUMBER { get => phoneNUMBER; set => phoneNUMBER = value; }
        public string EMAIL { get => eMAIL; set => eMAIL = value; }

    }
}
