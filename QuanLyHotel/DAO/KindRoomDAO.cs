using kindRoomDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kindRoomDAO
{
    public class KindRoomDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public KindRoomDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool add(KindRoomDTO kr)
        {
            string query = string.Empty;
            query += "INSERT INTO [KindRoom] (iDKR,nAME,numberOFBED,nOTE) ";
            query += "VALUES (@iDKR,@nAME,@numberOFBED,@nOTE)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDKR", kr.IDKR);
                    cmd.Parameters.AddWithValue("@nAME", kr.NAME);
                    cmd.Parameters.AddWithValue("@numberOFBED", kr.NumberOFBED);
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
        public bool delete(KindRoomDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM KindRoom WHERE [iDKR] = @iDKR"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDKR", pt.IDKR);
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
        public bool edit(KindRoomDTO kr)
        {
            string query = string.Empty;
            query += "UPDATE KindRoom SET [nAME] = @nAME, [numberOFBED] = @numberOFBED, [nOTE] = @nOTE  WHERE [iDKR] = @iDKR";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDKR", kr.IDKR);
                    cmd.Parameters.AddWithValue("@nAME", kr.NAME);
                    cmd.Parameters.AddWithValue("@numberOFBED", kr.NumberOFBED);
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
        public List<KindRoomDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [iDKR], [nAME], [numberOFBED], [nOTE]";
            query += "FROM [KindRoom]";

            List<KindRoomDTO> IsNameKindRoom = new List<KindRoomDTO>();

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
                                KindRoomDTO kr = new KindRoomDTO();
                                kr.IDKR = int.Parse(reader["iDKR"].ToString());
                                kr.NAME = reader["nAME"].ToString();
                                kr.NumberOFBED = int.Parse(reader["numberOFBED"].ToString());
                                kr.NOTE = reader["nOTE"].ToString();
                                IsNameKindRoom.Add(kr);
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
            return IsNameKindRoom;
        }
        public List<KindRoomDTO> selectNameKindRoom()
        {
            string query = string.Empty;
            query += "SELECT [nAME]";
            query += "FROM [KindRoom]";

            List<KindRoomDTO> lsNameKindRoom = new List<KindRoomDTO>();

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
                                KindRoomDTO kr = new KindRoomDTO();
                                kr.NAME = reader["nAME"].ToString();
                                lsNameKindRoom.Add(kr);
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
            return lsNameKindRoom;
        }
        public List<KindRoomDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [iDKR], [nAME], [numberOFBED], [nOTE]";
            query += "FROM [KindRoom]";
            query += " WHERE ([nAME] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDKR] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([numberOFBED] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([nOTE] LIKE CONCAT('%',@Keyword,'%'))";

            List<KindRoomDTO> lsTimKiem = new List<KindRoomDTO>();

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
                                KindRoomDTO kr = new KindRoomDTO();
                                kr.IDKR = int.Parse(reader["iDKR"].ToString());
                                kr.NAME = reader["nAME"].ToString();
                                kr.NumberOFBED = int.Parse(reader["numberOFBED"].ToString());
                                kr.NOTE = reader["nOTE"].ToString();
                                lsTimKiem.Add(kr);
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
        
    }
}
