using roomDAO;
using roomDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomBUS
{
    public class RoomBUS
    {
        private RoomDAO rDao;
        public RoomBUS()
        {
            rDao = new RoomDAO();
        }
        public bool add(RoomDTO pt)
        {
            bool re = rDao.add(pt);
            return re;
        }

        public bool delete(RoomDTO pt)
        {
            bool re = rDao.delete(pt);
            return re;
        }

        public bool edit(RoomDTO pt)
        {
            bool re = rDao.edit(pt);
            return re;
        }

        public List<RoomDTO> select()
        {
            return rDao.select();
        }
        public List<RoomDTO> selectNameRoom()
        {
            return rDao.selectNameRoom();
        }
        public List<RoomDTO> search(string Keyword)
        {
            return rDao.search(Keyword);
        }
        public List<RoomDTO> selectCost(string sKeyword)
        {
            return rDao.selectCost(sKeyword);
        }
    }
}
