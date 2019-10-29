using managerDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDAO
{
    public class ManagerDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public ManagerDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
}
}
