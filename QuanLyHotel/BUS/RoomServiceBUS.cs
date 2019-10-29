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
    }
}
