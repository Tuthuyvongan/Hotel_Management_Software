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
        public bool add(BillDTO pt)
        {
            bool re = bDao.add(pt);
            return re;
        }

        public bool delete(BillDTO pt)
        {
            bool re = bDao.delete(pt);
            return re;
        }

        public bool edit(BillDTO pt)
        {
            bool re = bDao.edit(pt);
            return re;
        }

        public List<BillDTO> select()
        {
            return bDao.select();
        }
        public List<BillDTO> selectNameBill()
        {
            return bDao.selectNameBill();
        }
        public List<BillDTO> search(string Keyword)
        {
            return bDao.search(Keyword);
        }
    }
}
