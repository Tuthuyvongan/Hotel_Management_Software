using customerDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerDAO
{
    public class CustomerDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public CustomerDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
}
}
