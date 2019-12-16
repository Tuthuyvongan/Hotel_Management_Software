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
            query += "INSERT INTO [room_service] (idrs,idr,ids,time,number,cost) ";
            query += "VALUES (@idrs,@idr,@ids,@time,@number,@cost)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idrs", rm.IDR_S);
                    cmd.Parameters.AddWithValue("@idr", rm.IDR);
                    cmd.Parameters.AddWithValue("@ids", rm.IDS);
                    cmd.Parameters.AddWithValue("@time", rm.TIME);
                    cmd.Parameters.AddWithValue("@number", rm.NUMBER);
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
        public bool delete(RoomServiceDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM room_service WHERE [idrs] = @idrs"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idrs", pt.IDR_S);
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
            query += "UPDATE room_service SET [idr] = @idr, [ids] = @ids, [time] = @time, [number] = @number, [cost] = @cost  WHERE [idrs] = @idrs";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idrs", rm.IDR_S);
                    cmd.Parameters.AddWithValue("@idr", rm.IDR);
                    cmd.Parameters.AddWithValue("@ids", rm.IDS);
                    cmd.Parameters.AddWithValue("@time", rm.TIME);
                    cmd.Parameters.AddWithValue("@number", rm.NUMBER);
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
        public List<RoomServiceDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [idr], [ids], [time], [number],[cost] ";
            query += "FROM [room_service]";

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
                                rm.IDR_S = reader["idrs"].ToString();
                                rm.IDR = reader["idr"].ToString();
                                rm.IDS = reader["ids"].ToString();
                                rm.TIME = DateTime.Parse(reader["time"].ToString());
                                rm.NUMBER = int.Parse(reader["number"].ToString());
                                rm.COST = Decimal.Parse(reader["cost"].ToString());
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
            query += "SELECT [idrs]";
            query += "FROM [room_service]";

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
                                pt.IDR_S = reader["idrs"].ToString();
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
            query += "SELECT [idr], [ids], [number], [cost], [time], [idrs]";
            query += "FROM [room_service]";
            query += " WHERE ([idr] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([ids] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([number] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cost] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([time] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([idrs] LIKE CONCAT('%',@Keyword,'%'))";

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
                                rm.IDR_S = reader["idrs"].ToString();
                                rm.IDR = reader["idr"].ToString();
                                rm.IDS = reader["ids"].ToString();
                                rm.TIME = DateTime.Parse(reader["time"].ToString());
                                rm.NUMBER = int.Parse(reader["number"].ToString());
                                rm.COST = Decimal.Parse(reader["cost"].ToString());
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
            query += "SELECT [cost]";
            query += "FROM [room_service]";
            query += " WHERE ([idrs] LIKE CONCAT('%',@sKeyword,'%'))";

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
