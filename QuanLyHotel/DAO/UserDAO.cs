using userDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userDAO
{
    public class UserDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public UserDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
}
}
