using customerDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerDAO
{
    public class CustomerDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public CustomerDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool add(CustomerDTO ctm)
        {
            string query = string.Empty;
            /*#Fix*/
            query += "INSERT INTO [Customer] (iDC,nAME,gENDER,bIRTHDAY,aDDRESS,phoneNUMBER,eMAIL,identifyCARD) ";
            query += "VALUES (@iDC,@nAME,@gENDER,@bIRTHDAY,@aDDRESS,@phoneNUMBER,@eMAIL,@identifyCARD)";
            
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDC", ctm.IDC);
                    cmd.Parameters.AddWithValue("@name", ctm.NAME);
                    cmd.Parameters.AddWithValue("@phone", ctm.PHONE);
                    cmd.Parameters.AddWithValue("@date", ctm.DATE);
                    cmd.Parameters.AddWithValue("@cmnd", ctm.CMND);

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
        public bool delete(CustomerDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM customer WHERE [idc] = @idc"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idc", pt.IDC);
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
        public bool edit(CustomerDTO ctm)
        {
            string query = string.Empty;
            query += "UPDATE customer SET [name] = @name, [phone] = @phone, [date] = @date, [cmnd] = @cmnd  WHERE [idc] = @idc";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDC", ctm.IDC);
                    cmd.Parameters.AddWithValue("@name", ctm.NAME);
                    cmd.Parameters.AddWithValue("@phone", ctm.PHONE);
                    cmd.Parameters.AddWithValue("@date", ctm.DATE);
                    cmd.Parameters.AddWithValue("@cmnd", ctm.CMND);
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
        public List<CustomerDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [idc], [name], [phone], [date], [cmnd]";
            query += "FROM [customer]";

            List<CustomerDTO> IsNameCustomer = new List<CustomerDTO>();

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
                                CustomerDTO ctm = new CustomerDTO();
                                ctm.IDC = reader["idc"].ToString();
                                ctm.NAME = reader["nAME"].ToString();
                                ctm.PHONE = reader["phone"].ToString();
                                ctm.DATE = DateTime.Parse(reader["date"].ToString());
                                ctm.CMND = reader["cmnd"].ToString();
                                IsNameCustomer.Add(ctm);
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
            return IsNameCustomer;
        }
        public List<CustomerDTO> selectNameCustomer()
        {
            string query = string.Empty;
            query += "SELECT [name]";
            query += "FROM [customer]";

            List<CustomerDTO> lsNameCustomer = new List<CustomerDTO>();

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
                                CustomerDTO kr = new CustomerDTO();
                                kr.NAME = reader["name"].ToString();
                                lsNameCustomer.Add(kr);
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
            return lsNameCustomer;
        }
        public List<CustomerDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [idc], [name], [phone], [date], [cmnd]";
            query += "FROM [customer]";
            query += " WHERE ([namee] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([idc] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([phone] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([date] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cmnd] LIKE CONCAT('%',@Keyword,'%'))";

            List<CustomerDTO> lsTimKiem = new List<CustomerDTO>();

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
                                CustomerDTO ctm = new CustomerDTO();
                                ctm.IDC = reader["idc"].ToString();
                                ctm.NAME = reader["nAME"].ToString();
                                ctm.PHONE = reader["phone"].ToString();
                                ctm.DATE = DateTime.Parse(reader["date"].ToString());
                                ctm.CMND = reader["cmnd"].ToString();
                                lsTimKiem.Add(ctm);
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
