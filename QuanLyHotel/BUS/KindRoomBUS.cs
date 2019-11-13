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
        public bool add(KindRoomDTO pt)
        {
            bool re = krDao.add(pt);
            return re;
        }

        public bool delete(KindRoomDTO pt)
        {
            bool re = krDao.delete(pt);
            return re;
        }

        public bool edit(KindRoomDTO pt)
        {
            bool re = krDao.edit(pt);
            return re;
        }

        public List<KindRoomDTO> select()
        {
            return krDao.select();
        }
        public List<KindRoomDTO> selectNameKindRoom()
        {
            return krDao.selectNameKindRoom();
        }
        public List<KindRoomDTO> search(string Keyword)
        {
            return krDao.search(Keyword);
        }

    }
}
