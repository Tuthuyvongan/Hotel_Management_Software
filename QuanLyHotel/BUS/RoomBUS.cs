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
        public bool them(RoomDTO pt)
        {
            bool re = rDao.them(pt);
            return re;
        }

        public bool xoa(RoomDTO pt)
        {
            bool re = rDao.xoa(pt);
            return re;
        }

        public bool sua(RoomDTO pt)
        {
            bool re = rDao.sua(pt);
            return re;
        }

        public List<RoomDTO> select()
        {
            return rDao.select();
        }
        public List<RoomDTO> selectTenPhuTung()
        {
            return rDao.selectTenPhuTung();
        }
        public List<RoomDTO> TimKiem(string Keyword)
        {
            return rDao.TimKiem(Keyword);
        }
        public List<RoomDTO> selectgia(string sKeyword)
        {
            return rDao.selectgia(sKeyword);
        }
    }
}
