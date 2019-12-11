using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceDTO
{
    public class ServiceDTO
    {
        private string iDS;
        private string nAME;
        private string kIND;
        private Decimal cOST;
        private string nOTE;

        public string IDS { get => iDS; set => iDS = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public string KIND { get => kIND; set => kIND = value; }
        public Decimal COST { get => cOST; set => cOST = value; }
        public string NOTE { get => nOTE; set => nOTE = value; }

    }
}
