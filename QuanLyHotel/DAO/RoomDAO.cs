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
        public bool them(RoomDTO pt)
        {
            string query = string.Empty;
            query += "INSERT INTO [PhuTung] (tenphutung,maphutung,dongia,tondau,toncuoi) ";
            query += "VALUES (@tenphutung,@maphutung,@dongia,@tondau,@toncuoi)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenphutung", pt.NAME);
                    cmd.Parameters.AddWithValue("@maphutung", pt.STATUS);
                    cmd.Parameters.AddWithValue("@dongia", pt.COST);

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
        public bool xoa(RoomDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM PhuTung WHERE [maphutung] = @maphutung"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maphutung", pt.IDR);
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
        public bool sua(RoomDTO pt)
        {
            string query = string.Empty;
            query += "UPDATE PhuTung SET [tenphutung] = @tenphutung, [dongia] = @dongia, [tondau] = @tondau, [toncuoi] = @toncuoi  WHERE [maphutung] = @maphutung";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenphutung", pt.NAME);
                    cmd.Parameters.AddWithValue("@maphutung", pt.STATUS);
                    cmd.Parameters.AddWithValue("@dongia", pt.COST);
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
            query += "SELECT [tenphutung], [dongia], [tondau], [toncuoi], [maphutung]";
            query += "FROM [PhuTung]";

            List<RoomDTO> lsTenPhuTung = new List<RoomDTO>();

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
                                pt.NAME = reader["tenphutung"].ToString();
                                pt.STATUS = reader["tenphutung"].ToString();
                                pt.COST = Decimal.Parse(reader["dongia"].ToString());
                                lsTenPhuTung.Add(pt);
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
            return lsTenPhuTung;
        }
        public List<RoomDTO> selectTenPhuTung()
        {
            string query = string.Empty;
            query += "SELECT [tenphutung]";
            query += "FROM [PhuTung]";

            List<RoomDTO> lsTenPhuTung = new List<RoomDTO>();

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
                                pt.NAME = reader["tenphutung"].ToString();
                                lsTenPhuTung.Add(pt);
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
            return lsTenPhuTung;
        }
        public List<RoomDTO> TimKiem(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [tenphutung], [dongia], [tondau], [toncuoi], [maphutung]";
            query += "FROM [PhuTung]";
            query += " WHERE ([tenphutung] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([maphutung] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([dongia] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([tondau] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([toncuoi] LIKE CONCAT('%',@Keyword,'%'))";

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
                                RoomDTO pt = new RoomDTO();
                                pt.NAME = reader["tenphutung"].ToString();
                                pt.STATUS = reader["tenphutung"].ToString();
                                pt.COST = Decimal.Parse(reader["dongia"].ToString());
                                lsTimKiem.Add(pt);
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
        public List<RoomDTO> selectgia(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT [dongia]";
            query += "FROM [PhuTung]";
            query += " WHERE ([tenphutung] LIKE CONCAT('%',@sKeyword,'%'))";

            List<RoomDTO> lsDonGia = new List<RoomDTO>();

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
                                pt.COST = Decimal.Parse(reader["dongia"].ToString());
                                lsDonGia.Add(pt);
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
            return lsDonGia;
        }
    }
}
