using roomServiceDAO;
using roomserviceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomServiceBUS
{
    public class RoomServiceBUS
    {
        private RoomServiceDAO rsDao;
        public RoomServiceBUS()
        {
            rsDao = new RoomServiceDAO();
        }
        public bool add(RoomServiceDTO pt)
        {
            bool re = rsDao.add(pt);
            return re;
        }

        public bool delete(RoomServiceDTO pt)
        {
            bool re = rsDao.delete(pt);
            return re;
        }

        public bool edit(RoomServiceDTO pt)
        {
            bool re = rsDao.edit(pt);
            return re;
        }

        public List<RoomServiceDTO> select()
        {
            return rsDao.select();
        }
        public List<RoomServiceDTO> selectNameRoom()
        {
            return rsDao.selectNameRoom();
        }
        public List<RoomServiceDTO> search(string Keyword)
        {
            return rsDao.search(Keyword);
        }
        public List<RoomServiceDTO> selectCost(string sKeyword)
        {
            return rsDao.selectCost(sKeyword);
        }
        #region Sum
        public int GetSumRoomService()
        {
            return rsDao.GetSumRoomService();
        }
        public decimal GetSumCostRoomServiceBill()
        {
            return rsDao.GetSumRoomService();
        }
        public decimal GetSumCostRoomServiceReport()
        {
            return rsDao.GetSumCostRoomServiceReport();
        }
        #endregion
    }
}
