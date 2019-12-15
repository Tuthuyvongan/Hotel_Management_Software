using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerDTO
{
    public class CustomerDTO
    {
        /*#Fix*/
        private string idc;
        private string name;
        private DateTime date;
        private string phone;
        private string cmnd;

        /*#Fix*/
        public string IDC { get => idc; set => idc = value; }
        public string NAME { get => name; set => name = value; }
        public DateTime DATE { get => date; set => date = value; }
        public string PHONE { get => phone; set => phone = value; }
        public string CMND { get => cmnd; set => cmnd = value; }
    }
}
