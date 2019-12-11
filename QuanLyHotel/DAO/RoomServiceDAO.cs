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
        public bool add(RoomServiceDTO rm)
        {
            string query = string.Empty;
            query += "INSERT INTO [Room_Service] (iDR_S,iDR,iDS,tIME,nUMBER,cOST) ";
            query += "VALUES (@iDR_S,@iDR,@iDS,@tIME,@nUMBER,@cOST)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDR_S", rm.IDR_S);
                    cmd.Parameters.AddWithValue("@iDR", rm.IDR);
                    cmd.Parameters.AddWithValue("@iDS", rm.IDS);
                    cmd.Parameters.AddWithValue("@tIME", rm.TIME);
                    cmd.Parameters.AddWithValue("@nUMBER", rm.NUMBER);
                    cmd.Parameters.AddWithValue("@cOST", rm.COST);

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
        public bool delete(RoomServiceDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM Room_Service WHERE [iDR_S] = @iDR_S"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDR_S", pt.IDR);
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
        public bool edit(RoomServiceDTO rm)
        {
            string query = string.Empty;
            query += "UPDATE Room_Service SET [iDR] = @iDR, [iDS] = @iDS, [tIME] = @tIME, [nUMBER] = @nUMBER, [cOST] = @cOST  WHERE [iDR_S] = @iDR_S";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDR_S", rm.IDR_S);
                    cmd.Parameters.AddWithValue("@iDR", rm.IDR);
                    cmd.Parameters.AddWithValue("@iDS", rm.IDS);
                    cmd.Parameters.AddWithValue("@tIME", rm.TIME);
                    cmd.Parameters.AddWithValue("@nUMBER", rm.NUMBER);
                    cmd.Parameters.AddWithValue("@cOST", rm.COST);
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
        public List<RoomServiceDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [nAME], [sTATUS], [cOST], [nBED], [iDR],[nOTE] ";
            query += "FROM [Room_Service]";

            List<RoomServiceDTO> IsNameRoom = new List<RoomServiceDTO>();

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
                                RoomServiceDTO rm = new RoomServiceDTO();
                                rm.IDR_S = reader["iDR_S"].ToString();
                                rm.IDR = reader["iDR"].ToString();
                                rm.IDS = reader["iDS"].ToString();
                                rm.NUMBER = int.Parse(reader["nUMBER"].ToString());
                                rm.COST = Decimal.Parse(reader["cOST"].ToString());
                                IsNameRoom.Add(rm);
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
            return IsNameRoom;
        }
        public List<RoomServiceDTO> selectNameRoom()
        {
            string query = string.Empty;
            query += "SELECT [iDR_S]";
            query += "FROM [Room_Service]";

            List<RoomServiceDTO> lsNameRoom = new List<RoomServiceDTO>();

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
                                RoomServiceDTO pt = new RoomServiceDTO();
                                pt.IDR_S = reader["iDR_S"].ToString();
                                lsNameRoom.Add(pt);
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
            return lsNameRoom;
        }
        public List<RoomServiceDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [iDR], [iDS], [nUMBER], [cOST], [tIME], [iDR_S]";
            query += "FROM [Room_Service]";
            query += " WHERE ([iDR] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDS] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([nUMBER] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cOST] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([tIME] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDR_S] LIKE CONCAT('%',@Keyword,'%'))";

            List<RoomServiceDTO> lsTimKiem = new List<RoomServiceDTO>();

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
                                RoomServiceDTO rm = new RoomServiceDTO();
                                rm.IDR_S = reader["iDR_S"].ToString();
                                rm.IDR = reader["iDR"].ToString();
                                rm.IDS = reader["iDS"].ToString();
                                rm.NUMBER = int.Parse(reader["nUMBER"].ToString());
                                rm.COST = Decimal.Parse(reader["cOST"].ToString());
                                lsTimKiem.Add(rm);
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
        public List<RoomServiceDTO> selectCost(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT [cOST]";
            query += "FROM [Room_Service]";
            query += " WHERE ([iDR_S] LIKE CONCAT('%',@sKeyword,'%'))";

            List<RoomServiceDTO> lsCost = new List<RoomServiceDTO>();

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
                                RoomServiceDTO pt = new RoomServiceDTO();
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
