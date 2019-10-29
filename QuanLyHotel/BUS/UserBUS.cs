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
    }
}
