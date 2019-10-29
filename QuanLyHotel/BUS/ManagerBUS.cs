using managerDAO;
using managerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerBUS
{
    public class ManagerBUS
    {
        private ManagerDAO mngDao;
        public ManagerBUS()
        {
            mngDao = new ManagerDAO();
        }
    }
}
