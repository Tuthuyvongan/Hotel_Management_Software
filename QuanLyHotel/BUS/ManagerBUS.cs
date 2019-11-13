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
        public bool add(ManagerDTO pt)
        {
            bool re = mngDao.add(pt);
            return re;
        }

        public bool delete(ManagerDTO pt)
        {
            bool re = mngDao.delete(pt);
            return re;
        }

        public bool edit(ManagerDTO pt)
        {
            bool re = mngDao.edit(pt);
            return re;
        }

        public List<ManagerDTO> select()
        {
            return mngDao.select();
        }
        public List<ManagerDTO> selectNameManager()
        {
            return mngDao.selectNameManager();
        }
        public List<ManagerDTO> search(string Keyword)
        {
            return mngDao.search(Keyword);
        }
    }
}
