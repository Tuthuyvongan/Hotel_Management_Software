using billDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billDAO
{
    public class BillDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public BillDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
    }
}
