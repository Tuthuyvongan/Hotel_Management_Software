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
        public bool add(ServiceDTO pt)
        {
            bool re = sDao.add(pt);
            return re;
        }

        public bool delete(ServiceDTO pt)
        {
            bool re = sDao.delete(pt);
            return re;
        }

        public bool edit(ServiceDTO pt)
        {
            bool re = sDao.edit(pt);
            return re;
        }

        public List<ServiceDTO> select()
        {
            return sDao.select();
        }
        public List<ServiceDTO> selectNameService()
        {
            return sDao.selectNameService();
        }
        public List<ServiceDTO> search(string Keyword)
        {
            return sDao.search(Keyword);
        }
        public List<ServiceDTO> selectCost(string sKeyword)
        {
            return sDao.selectCost(sKeyword);
        }
        public List<ServiceDTO> selectKind()
        {
            return sDao.selectKind();
        }
        #region Sum
        public int GetSumService()
        {
            return sDao.GetSumService();
        }

        #endregion
    }
}
