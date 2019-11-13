using userDAO;
using userDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userBUS
{
    public class UserBUS
    {
        private UserDAO usDao;
        public UserBUS()
        {
            usDao = new UserDAO();
        }
        public bool add(UserDTO tn)
        {
            bool re = usDao.add(tn);
            return re;
        }

        public bool fix(UserDTO tn)
        {
            bool re = usDao.fix(tn);
            return re;
        }
        public bool kiemtra(UserDTO tn, string IDU, string PASSWORD)
        {
            bool re = usDao.kiemtra(tn, IDU, PASSWORD);
            return re;
        }
    }
  
}
