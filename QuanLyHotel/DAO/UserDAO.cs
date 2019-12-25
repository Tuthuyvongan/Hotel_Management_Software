using userDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace userDAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set { UserDAO.instance = value; }
        }
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public UserDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        //
        //Add Edit Delete
        #region Add Edit Delete
        public bool add(UserDTO nd)
        {
            string query = string.Empty;
            query += "INSERT INTO [manager] (idm,name,phone,email,password,level,gender,cmnd) ";
            query += "VALUES (@idm,@name,@phone,@email,@password,@level,@gender,@cmnd)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idm", nd.Idm);
                    cmd.Parameters.AddWithValue("@name", nd.Name);
                    cmd.Parameters.AddWithValue("@password", nd.Password);
                    cmd.Parameters.AddWithValue("@phone", nd.Phone);
                    cmd.Parameters.AddWithValue("@email", nd.Email);
                    cmd.Parameters.AddWithValue("@level", nd.Level);
                    cmd.Parameters.AddWithValue("@gender", nd.Gender);
                    cmd.Parameters.AddWithValue("@cmnd", nd.Cmnd);

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
        public bool delete(UserDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM manager WHERE [idm] = @idm"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idm", pt.Idm);
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
        public bool edit(UserDTO us)
        {
            string query = string.Empty;
            query += "UPDATE manager SET [name] = @name, [phone] = @phone, [email] = @email,[level] = @level,[gender] = @gender,[cmnd] = @cmnd  WHERE [idm] = @idm";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@idm", us.Idm);
                    cmd.Parameters.AddWithValue("@name", us.Name);
                    cmd.Parameters.AddWithValue("@password", us.Password);
                    cmd.Parameters.AddWithValue("@phone", us.Phone);
                    cmd.Parameters.AddWithValue("@email", us.Email);
                    cmd.Parameters.AddWithValue("@level", us.Level);
                    cmd.Parameters.AddWithValue("@gender", us.Gender);
                    cmd.Parameters.AddWithValue("@cmnd", us.Cmnd);
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
        public bool fix(UserDTO nd)
        {
            string query = string.Empty;
            query += "UPDATE manager SET [password] = @password, WHERE [idm] = @idm";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idm", nd.Idm);
                    cmd.Parameters.AddWithValue("@password", nd.Password);

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
        #endregion
        //
        //List/Search/Login
        //
        #region List/Search/Login
        public List<UserDTO> select(string IDM, string PASSWORD)
        {
            string query = string.Empty;
            query += "SELECT *from [manager]";
            query += "where idm = '" + IDM + "'and password = '" + PASSWORD + "'";




            List<UserDTO> listNguoidungDTO = new List<UserDTO>();

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
                                UserDTO nc = new UserDTO();

                                nc.Idm = reader["idm"].ToString();
                                nc.Password = reader["password"].ToString();
                                listNguoidungDTO.Add(nc);
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
            return listNguoidungDTO;
        }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public bool kiemtra(UserDTO nd, string IDU, string PASSWORD)
        {
            string query = string.Empty;

            query += "SELECT (idm),(password) from [manager]";
            query += "where [idm] = N'" + @IDU + "'and [password] = N'" + PASSWORD + "'";

            DataTable resuft = ExcuteQuery(query);
            return resuft.Rows.Count > 0;

            
        }
        public List<UserDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [idm], [password], [name], [gender], [phone], [email], [level], [cmnd] ";
            query += "FROM [manager]";

            List<UserDTO> IsNameService = new List<UserDTO>();

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
                                UserDTO srv = new UserDTO();
                                srv.Idm = reader["idm"].ToString();
                                srv.Password = reader["password"].ToString();
                                srv.Name = reader["name"].ToString();
                                srv.Email = reader["email"].ToString();
                                srv.Phone = reader["phone"].ToString();
                                srv.Gender = reader["gender"].ToString();
                                srv.Cmnd = reader["cmnd"].ToString();
                                srv.Level =int.Parse(reader["level"].ToString());
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
        public List<UserDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [name], [phone], [email], [gender], [cmnd]";
            query += "FROM [manager]";
            query += " WHERE ([name] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([phone] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([email] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([gender] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cmnd] LIKE CONCAT('%',@Keyword,'%'))";

            List<UserDTO> lsTimKiem = new List<UserDTO>();

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
                                UserDTO mng = new UserDTO();
                                mng.Name = reader["name"].ToString();
                                mng.Phone = reader["phone"].ToString();
                                mng.Email = reader["email"].ToString();
                                mng.Gender = reader["gender"].ToString();
                                mng.Cmnd = reader["cmnd"].ToString();
                                lsTimKiem.Add(mng);
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
        #endregion
        //
        //Sum
        //
        #region Sum
        public int GetSumAccount()
        {
            string query = string.Empty;
            query += "SELECT [name]";
            query += "FROM [manager]";

            int Sum = 0;

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
                                UserDTO pt = new UserDTO();
                                pt.Name = reader["name"].ToString();
                                Sum++;
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
            return Sum;
        }
        public int GetSumLevelAccount()
        {
            string query = string.Empty;
            query += "SELECT [name]";
            query += "FROM [manager]";
            query += "WHERE [level] = @level";

            int Sum = 0;

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
                                UserDTO pt = new UserDTO();
                                pt.Name = reader["name"].ToString();
                                pt.Level = int.Parse(reader["level"].ToString());
                                Sum++;
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
            return Sum;
        }
        public int GetSumGenderAccount()
        {
            string query = string.Empty;
            query += "SELECT [name]";
            query += "FROM [manager]";
            query += "WHERE [gender] = @gender";

            int Sum = 0;

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
                                UserDTO pt = new UserDTO();
                                pt.Name = reader["name"].ToString();
                                pt.Gender = reader["gender"].ToString();
                                Sum++;
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
            return Sum;
        }
        #endregion
    }
}
