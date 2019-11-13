using roomDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomDAO
{
    public class RoomDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public RoomDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool add(RoomDTO kr)
        {
            string query = string.Empty;
            query += "INSERT INTO [Room] (iDR,nBED,nAME,sTATUS,cOST,nOTE) ";
            query += "VALUES (@iDR,@iBED,@nAME,@sTATUS,@cOST,@nOTE)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDR", kr.IDR);
                    cmd.Parameters.AddWithValue("@nBED", kr.NBED);
                    cmd.Parameters.AddWithValue("@nAME", kr.NAME);
                    cmd.Parameters.AddWithValue("@sTATUS", kr.STATUS);
                    cmd.Parameters.AddWithValue("@cOST", kr.COST);
                    cmd.Parameters.AddWithValue("@nOTE", kr.NOTE);

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
        public bool delete(RoomDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM Room WHERE [IDR] = @iDR"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDR", pt.IDR);
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
        public bool edit(RoomDTO kr)
        {
            string query = string.Empty;
            query += "UPDATE Room SET [nBED] = @iBED, [nAME] = @nAME, [sTATUS] = @sTATUS, [cOST] = @cOST,[nOTE]=@nOTE  WHERE [IDR] = @iDR";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDR", kr.IDR);
                    cmd.Parameters.AddWithValue("@nBED", kr.NBED);
                    cmd.Parameters.AddWithValue("@nAME", kr.NAME);
                    cmd.Parameters.AddWithValue("@sTATUS", kr.STATUS);
                    cmd.Parameters.AddWithValue("@cOST", kr.COST);
                    cmd.Parameters.AddWithValue("@nOTE", kr.NOTE);
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
        public List<RoomDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [nAME], [sTATUS], [cOST], [nBED], [iDR],[nOTE] ";
            query += "FROM [Room]";

            List<RoomDTO> IsNameRoom = new List<RoomDTO>();

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
                                RoomDTO rm = new RoomDTO();
                                rm.IDR = int.Parse(reader["iDR"].ToString());
                                rm.NBED = int.Parse(reader["nBED"].ToString());
                                rm.NAME = reader["nAME"].ToString();
                                rm.STATUS = reader["sTATUS"].ToString();
                                rm.COST = Decimal.Parse(reader["cOST"].ToString());
                                rm.NOTE = reader["nOTE"].ToString();
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
        public List<RoomDTO> selectNameRoom()
        {
            string query = string.Empty;
            query += "SELECT [nAME]";
            query += "FROM [Room]";

            List<RoomDTO> lsNameRoom = new List<RoomDTO>();

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
                                RoomDTO pt = new RoomDTO();
                                pt.NAME = reader["nAME"].ToString();
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
        public List<RoomDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [nAME], [nBED], [sTATUS], [cOST], [iDR]";
            query += "FROM [Room]";
            query += " WHERE ([nAME] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([nBED] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([sTATUS] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cOST] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDR] LIKE CONCAT('%',@Keyword,'%'))";

            List<RoomDTO> lsTimKiem = new List<RoomDTO>();

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
                                RoomDTO rm = new RoomDTO();
                                rm.IDR = int.Parse(reader["iDR"].ToString());
                                rm.NBED = int.Parse(reader["nBED"].ToString());
                                rm.NAME = reader["nAME"].ToString();
                                rm.STATUS = reader["sTATUS"].ToString();
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
        public List<RoomDTO> selectCost(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT [cOST]";
            query += "FROM [Room]";
            query += " WHERE ([nAME] LIKE CONCAT('%',@sKeyword,'%'))";

            List<RoomDTO> lsCost = new List<RoomDTO>();

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
                                RoomDTO pt = new RoomDTO();
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
