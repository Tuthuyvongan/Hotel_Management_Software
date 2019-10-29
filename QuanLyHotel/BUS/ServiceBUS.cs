using serviceDAO;
using serviceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceBUS
{
    public class ServiceBUS
    {
        private ServiceDAO sDao;
        public ServiceBUS()
        {
            sDao = new ServiceDAO();
        }
    }
}
