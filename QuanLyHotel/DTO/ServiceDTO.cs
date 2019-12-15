using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceDTO
{
    public class ServiceDTO
    {
        private string ids;
        private string name;
        private string kind;
        private Decimal cost;

        public string IDS { get => ids; set => ids = value; }
        public string NAME { get => name; set => name = value; }
        public string KIND { get => kind; set => kind = value; }
        public Decimal COST { get => cost; set => cost = value; }

    }
}
