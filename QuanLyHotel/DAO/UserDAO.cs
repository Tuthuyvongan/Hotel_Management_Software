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
        public bool add(UserDTO nd)
        {
            string query = string.Empty;
            query += "INSERT INTO [User] (iDU,nAME,pASSWORD) ";
            query += "VALUES (@iDU,@nAME,@pASSWORD)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDU", nd.IDU);
                    cmd.Parameters.AddWithValue("@nAME", nd.NAME);
                    cmd.Parameters.AddWithValue("@pASSWORD", nd.PASSWORD);

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
            query += "UPDATE User SET [PASSWORD] = @pASSWORD WHERE [IDU] = @iDU";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDU", nd.IDU);
                    cmd.Parameters.AddWithValue("@pASSWORD", nd.PASSWORD);

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


        public List<UserDTO> select(string IDU, string PASSWORD)
        {
            string query = string.Empty;
            query += "SELECT *from [User]";
            query += "where iDU = '" + IDU + "'and pASSWORD = '" + PASSWORD + "'";




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

                                nc.IDU = reader["iDu"].ToString();
                                nc.PASSWORD = reader["pASSWORD"].ToString();
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

            query += "SELECT (iDU),(pASSWORD) from [User]";
            query += "where [iDU] = N'" + @IDU + "'and [PassWord] = N'" + PASSWORD + "'";

            DataTable resuft = ExcuteQuery(query);
            return resuft.Rows.Count > 0;

            
        }
    }
}
