using kindRoomDAO;
using kindRoomDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kindRoomBUS
{
    public class KindRoomBUS
    {
        private KindRoomDAO krDao;
        public KindRoomBUS()
        {
            krDao = new KindRoomDAO();
        }
        public bool them(KindRoomDTO pt)
        {
            bool re = krDao.them(pt);
            return re;
        }

        public bool xoa(KindRoomDTO pt)
        {
            bool re = krDao.xoa(pt);
            return re;
        }

        public bool sua(KindRoomDTO pt)
        {
            bool re = krDao.sua(pt);
            return re;
        }

        public List<KindRoomDTO> select()
        {
            return krDao.select();
        }
        public List<KindRoomDTO> selectTenPhuTung()
        {
            return krDao.selectTenPhuTung();
        }
        public List<KindRoomDTO> TimKiem(string Keyword)
        {
            return krDao.TimKiem(Keyword);
        }

    }
}
