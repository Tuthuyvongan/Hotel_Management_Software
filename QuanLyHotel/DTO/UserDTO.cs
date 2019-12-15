using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userDTO
{
    public class UserDTO
    {
        private string idm;
        private string name;
        private string phone;
        private string email;
        private string password;
        private int level;
        private string gender;
        private string cmnd;


        public string Idm { get => idm; set => idm = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Level { get => level; set => level = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
    }
}
