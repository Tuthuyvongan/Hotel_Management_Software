using reportDAO;
using reportDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reportBUS
{
    public class ReportBUS
    {
        private ReportDAO rpDao;

        public ReportBUS()
        {
            rpDao = new ReportDAO();
        }
        public bool add(ReportDTO pt)
        {
            bool re = rpDao.add(pt);
            return re;
        }

        public bool delete(ReportDTO pt)
        {
            bool re = rpDao.delete(pt);
            return re;
        }

        public bool edit(ReportDTO pt)
        {
            bool re = rpDao.edit(pt);
            return re;
        }

        //public List<ReportDTO> select()
        //{
        //    return rpDao.select();
        //}
        //public List<ReportDTO> selectNameService()
        //{
        //    return rpDao.selectNameService();
        //}
        //public List<ReportDTO> search(string Keyword)
        //{
        //    return rpDao.search(Keyword);
        //}
        //public List<ReportDTO> selectCost(string sKeyword)
        //{
        //    return rpDao.selectCost(sKeyword);
        //}


        #region Sum
        //public int GetSumService()
        //{
        //    return rpDao.GetSumService();
        //}

        #endregion
    }
}
