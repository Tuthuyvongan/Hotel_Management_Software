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
        public bool add(ServiceDTO rm)
        {
            string query = string.Empty;
            query += "INSERT INTO [Service] (iDS,nAME,kINd,cOST,nOTE) ";
            query += "VALUES (@iDS,@nAME,@kINd,@cOST,@nOTE)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDS", rm.IDS);
                    cmd.Parameters.AddWithValue("@nAME", rm.NAME);
                    cmd.Parameters.AddWithValue("@kINd", rm.KIND);
                    cmd.Parameters.AddWithValue("@cOST", rm.COST);
                    cmd.Parameters.AddWithValue("@nOTE", rm.NOTE);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return true;
        }
        public bool delete(ServiceDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM Service WHERE [iDS] = @iDS"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDS", pt.IDS);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return true;
        }
        public bool edit(ServiceDTO rm)
        {
            string query = string.Empty;
            query += "UPDATE Service SET [nAME] = @nAME, [kINd] = @kINd, [cOST] = @cOST,[nOTE]=@nOTE  WHERE [iDS] = @iDS";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDS", rm.IDS);
                    cmd.Parameters.AddWithValue("@nAME", rm.NAME);
                    cmd.Parameters.AddWithValue("@kINd", rm.KIND);
                    cmd.Parameters.AddWithValue("@cOST", rm.COST);
                    cmd.Parameters.AddWithValue("@nOTE", rm.NOTE);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return true;
        }
        public List<ServiceDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [nAME], [kINd], [cOST], [iDS],[nOTE] ";
            query += "FROM [Service]";

            List<ServiceDTO> IsNameService = new List<ServiceDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                ServiceDTO srv = new ServiceDTO();
                                srv.IDS = reader["iDS"].ToString();
                                srv.NAME = reader["nAME"].ToString();
                                srv.KIND = reader["kINd"].ToString();
                                srv.COST = Decimal.Parse(reader["cOST"].ToString());
                                srv.NOTE = reader["nOTE"].ToString();
                                IsNameService.Add(srv);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return IsNameService;
        }
        public List<ServiceDTO> selectNameService()
        {
            string query = string.Empty;
            query += "SELECT [nAME]";
            query += "FROM [Service]";

            List<ServiceDTO> lsNameService = new List<ServiceDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                ServiceDTO pt = new ServiceDTO();
                                pt.NAME = reader["nAME"].ToString();
                                lsNameService.Add(pt);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return lsNameService;
        }
        public List<ServiceDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [nAME], [kINd], [cOST], [iDR], [nOTE]";
            query += "FROM [Service]";
            query += " WHERE ([nAME] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([kINd] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cOST] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDR] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([nOTE] LIKE CONCAT('%',@Keyword,'%'))";

            List<ServiceDTO> lsTimKiem = new List<ServiceDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Keyword", Keyword);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                ServiceDTO srv = new ServiceDTO();
                                srv.IDS = reader["iDS"].ToString();
                                srv.NAME = reader["nAME"].ToString();
                                srv.KIND = reader["kINd"].ToString();
                                srv.COST = Decimal.Parse(reader["cOST"].ToString());
                                srv.NOTE = reader["nOTE"].ToString();
                                lsTimKiem.Add(srv);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return lsTimKiem;
        }
        public List<ServiceDTO> selectCost(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT [cOST]";
            query += "FROM [Service]";
            query += " WHERE ([nAME] LIKE CONCAT('%',@sKeyword,'%'))";

            List<ServiceDTO> lsCost = new List<ServiceDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                ServiceDTO pt = new ServiceDTO();
                                pt.COST = Decimal.Parse(reader["cOST"].ToString());
                                lsCost.Add(pt);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return lsCost;
        }
    }
}
