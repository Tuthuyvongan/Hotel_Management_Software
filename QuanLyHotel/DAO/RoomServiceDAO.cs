using roomserviceDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomServiceDAO
{
    public class RoomServiceDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public RoomServiceDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
}
}
