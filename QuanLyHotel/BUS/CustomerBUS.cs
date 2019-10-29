using customerDAO;
using customerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerBUS
{
    public class CustomerBUS
    {
        private CustomerDAO ctmDao;
        public CustomerBUS()
        {
            ctmDao = new CustomerDAO();
        }
    }
}
