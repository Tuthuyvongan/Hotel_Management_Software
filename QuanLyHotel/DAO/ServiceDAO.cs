using serviceDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceDAO
{
    public class ServiceDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public ServiceDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
}
}
