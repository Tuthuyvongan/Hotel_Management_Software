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
            //query += "INSERT INTO [Service] (iDS,nAME,kINd,cOST) ";
            //query += "VALUES (@iDS,@nAME,@kINd,@cOST)";
            query += "INSERT INTO [service] (name,kind,cost) ";
            query += "VALUES (@name,@kind,@cost)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    //cmd.Parameters.AddWithValue("@iDS", rm.IDS);
                    cmd.Parameters.AddWithValue("@name", rm.NAME);
                    cmd.Parameters.AddWithValue("@kind", rm.KIND);
                    cmd.Parameters.AddWithValue("@cost", rm.COST);

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
            query += "DELETE FROM service WHERE [ids] = @ids"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ids", pt.IDS);
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
            query += "UPDATE Service SET [name] = @name, [kind] = @kind, [cost] = @cost  WHERE [ids] = @ids";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    //cmd.Parameters.AddWithValue("@iDS", rm.IDS);
                    cmd.Parameters.AddWithValue("@name", rm.NAME);
                    cmd.Parameters.AddWithValue("@kind", rm.KIND);
                    cmd.Parameters.AddWithValue("@cost", rm.COST);
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
            query += "SELECT [name], [kind], [cost], [ids] ";
            query += "FROM [service]";

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
                                srv.IDS = int.Parse(reader["ids"].ToString());
                                srv.NAME = reader["name"].ToString();
                                srv.KIND = reader["kind"].ToString();
                                srv.COST = Decimal.Parse(reader["cost"].ToString());
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
            query += "SELECT [name]";
            query += "FROM [service]";

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
                                pt.NAME = reader["name"].ToString();
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
            query += "SELECT [name], [kind], [cost], [idr]";
            query += "FROM [service]";
            query += " WHERE ([name] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([kind] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cost] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDR] LIKE CONCAT('%',@Keyword,'%'))";

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
                                srv.IDS = int.Parse(reader["ids"].ToString());
                                srv.NAME = reader["name"].ToString();
                                srv.KIND = reader["kind"].ToString();
                                srv.COST = Decimal.Parse(reader["cost"].ToString());
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
            query += "SELECT [cost]";
            query += "FROM [service]";
            query += " WHERE ([name] LIKE CONCAT('%',@sKeyword,'%'))";

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
                                pt.COST = Decimal.Parse(reader["cost"].ToString());
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
