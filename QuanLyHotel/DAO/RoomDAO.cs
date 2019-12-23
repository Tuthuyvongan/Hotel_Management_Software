using roomDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roomDAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }
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


        public static int RoomWidth = 90;
        public static int RoomHeigh = 90;

        //public RoomDAO(DataRow row)
        //{
        //    connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        //    RoomDTO data = new RoomDTO();
        //    data.Idr = row["idr"].ToString();
        //    data.Name = row["name"].ToString();
        //    data.Status = row["status"].ToString();
        //    data.Cost = (decimal)row["cost"];
        //    data.Bedamount = (int)row["bedamount"];
        //    data.Roomkind = row["romkind"].ToString();
        //}
        public class DataProvider
        { 
            public DataTable ExcuteQuery(string query,string ConnectionString, object[] parameter=null)
            {               
                DataTable data = new DataTable();
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    if (parameter!=null)
                    {
                        string[] listpara = query.Split();
                        int i = 0;
                        foreach(string item in listpara)
                            {
                            if(item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    con.Close();
                }
                return data;
            }
        }
        public List<RoomDTO> LoadRoomList()
        {
            List<RoomDTO> RoomList = new List<RoomDTO>();
            DataProvider provider = new DataProvider();
            string connectionstring = "Data Source=.\\SQLEXPRESS01;Initial Catalog=Hotel_Management;Integrated Security=True";
            DataTable data=provider.ExcuteQuery("USP_GetRoomList", connectionstring);
            foreach(DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                RoomList.Add(room);
            }
            return RoomList;
        }
        public bool add(RoomDTO rm)
        {
            string query = string.Empty;
            query += "INSERT INTO [room] (idr,name,cost,status,bedamount,roomkind) ";
            query += "VALUES (@idr,@name,@cost,@status,@bedamount,@roomkind)";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idr", rm.Idr);
                    cmd.Parameters.AddWithValue("@name", rm.Name);
                    cmd.Parameters.AddWithValue("@cost", rm.Cost);
                    cmd.Parameters.AddWithValue("@status", rm.Status);
                    cmd.Parameters.AddWithValue("@bedamount", rm.Bedamount);
                    cmd.Parameters.AddWithValue("@roomkind", rm.Roomkind);

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
            query += "DELETE FROM room WHERE [idr] = @idr"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idr", pt.Idr);
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
        public bool edit(RoomDTO rm)
        {
            string query = string.Empty;
            query += "UPDATE room SET [name] = @name, [status] = @status, [cost] = @cost, [bedamount]=@bedamount, [roomkind]=@roomkind  WHERE [idr] = @idr";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idr", rm.Idr);
                    cmd.Parameters.AddWithValue("@name", rm.Name);
                    cmd.Parameters.AddWithValue("@cost", rm.Cost);
                    cmd.Parameters.AddWithValue("@status", rm.Status);
                    cmd.Parameters.AddWithValue("@bedamount", rm.Bedamount);
                    cmd.Parameters.AddWithValue("@roomkind", rm.Roomkind);
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
        public bool editStatus(RoomDTO rm)
        {
            string query = string.Empty;
            query += "UPDATE room SET [status] = @status WHERE [idr] = @idr";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idr", rm.Idr);
                    cmd.Parameters.AddWithValue("@status", rm.Status);

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
            query += "SELECT [name], [status], [cost], [bedamount], [roomkind], [idr] ";
            query += "FROM [room]";

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
                                rm.Idr = reader["idr"].ToString();
                                rm.Name = reader["name"].ToString();
                                rm.Bedamount = int.Parse(reader["bedamount"].ToString());
                                rm.Status = reader["status"].ToString();
                                rm.Cost = decimal.Parse(reader["cost"].ToString());
                                rm.Roomkind = reader["roomkind"].ToString();
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
            query += "SELECT [name]";
            query += "FROM [room]";

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
                                pt.Name = reader["name"].ToString();
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
            query += "SELECT [name], [bedamount], [status], [cost], [idr], [roomkind]";
            query += "FROM [room]";
            query += " WHERE ([name] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([bedamount] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([status] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cost] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([roomkind] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([idr] LIKE CONCAT('%',@Keyword,'%'))";

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
                                rm.Idr = reader["idr"].ToString();
                                rm.Name = reader["name"].ToString();
                                rm.Bedamount = int.Parse(reader["bedamount"].ToString());
                                rm.Status = reader["status"].ToString();
                                rm.Cost = decimal.Parse(reader["cost"].ToString());
                                rm.Roomkind = reader["roomkind"].ToString();
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
            query += "SELECT [cost]";
            query += "FROM [room]";
            query += " WHERE ([name] LIKE CONCAT('%',@sKeyword,'%'))";

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
                                pt.Cost = Decimal.Parse(reader["cost"].ToString());
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


