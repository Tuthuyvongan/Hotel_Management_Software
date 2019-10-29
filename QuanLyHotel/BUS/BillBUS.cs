using billDTO;
using billDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billBUS
{
    public class BillBUS
    {
        private BillDAO bDao;
        public BillBUS()
        {
            bDao = new BillDAO();
        }
    }
}
