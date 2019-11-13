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
        public bool add(CustomerDTO pt)
        {
            bool re = ctmDao.add(pt);
            return re;
        }

        public bool delete(CustomerDTO pt)
        {
            bool re = ctmDao.delete(pt);
            return re;
        }

        public bool edit(CustomerDTO pt)
        {
            bool re = ctmDao.edit(pt);
            return re;
        }

        public List<CustomerDTO> select()
        {
            return ctmDao.select();
        }
        public List<CustomerDTO> selectNameCustomer()
        {
            return ctmDao.selectNameCustomer();
        }
        public List<CustomerDTO> search(string Keyword)
        {
            return ctmDao.search(Keyword);
        }
    }
}
