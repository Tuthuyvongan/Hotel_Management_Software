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
                    cmd.Parameters.AddWithValue("@nAME", ctm.NAME);
                    cmd.Parameters.AddWithValue("@gENDER", ctm.GENDER);
                    cmd.Parameters.AddWithValue("@bIRTHDAY", ctm.BIRTHDAY);
                    cmd.Parameters.AddWithValue("@aDDRESS", ctm.ADDRESS);
                    cmd.Parameters.AddWithValue("@phoneNUMBER", ctm.PhoneNUMBER);
                    cmd.Parameters.AddWithValue("@eMAIL", ctm.EMAIL);
                    cmd.Parameters.AddWithValue("@identifyCARD", ctm.IdentifyCARD);


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
            query += "DELETE FROM Customer WHERE [iDC] = @iDC"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDC", pt.IDC);
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
            query += "UPDATE Customer SET [nAME] = @nAME, [gENDER] = @gENDER, [bIRTHDAY] = @bIRTHDAY, [aDDRESS] = @aDDRESS, [phoneNUMBER] = @phoneNUMBER, [eMAIL] = @eMAIL, [identifyCARD] = @identifyCARD  WHERE [iDC] = @iDC";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDC", ctm.IDC);
                    cmd.Parameters.AddWithValue("@nAME", ctm.NAME);
                    cmd.Parameters.AddWithValue("@gENDER", ctm.GENDER);
                    cmd.Parameters.AddWithValue("@bIRTHDAY", ctm.BIRTHDAY);
                    cmd.Parameters.AddWithValue("@aDDRESS", ctm.ADDRESS);
                    cmd.Parameters.AddWithValue("@phoneNUMBER", ctm.PhoneNUMBER);
                    cmd.Parameters.AddWithValue("@eMAIL", ctm.EMAIL);
                    cmd.Parameters.AddWithValue("@identifyCARD", ctm.IdentifyCARD);
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
            query += "SELECT [iDC], [nAME], [gENDER], [phoneNUMBER], [eMAIL], [identifyCARD]";
            query += "FROM [Customer]";

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
                                ctm.IDC = reader["iDC"].ToString();
                                ctm.NAME = reader["nAME"].ToString();
                                ctm.GENDER = reader["gENDER"].ToString();
                                ctm.PhoneNUMBER = reader["phoneNUMBER"].ToString();
                                ctm.EMAIL = reader["eMAIL"].ToString();
                                ctm.IdentifyCARD = reader["identifyCARD"].ToString();
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
            query += "SELECT [nAME]";
            query += "FROM [Customer]";

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
                                kr.NAME = reader["nAME"].ToString();
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
            query += "SELECT [iDC], [nAME], [gENDER], [phoneNUMBER], [eMAIL], [identifyCARD]";
            query += "FROM [Customer]";
            query += " WHERE ([nAME] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDC] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([gENDER] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([phoneNUMBER] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([eMAIL] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([identifyCARD] LIKE CONCAT('%',@Keyword,'%'))";

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
                                ctm.IDC = reader["iDC"].ToString();
                                ctm.NAME = reader["nAME"].ToString();
                                ctm.GENDER = reader["gENDER"].ToString();
                                ctm.PhoneNUMBER = reader["phoneNUMBER"].ToString();
                                ctm.EMAIL = reader["eMAIL"].ToString();
                                ctm.IdentifyCARD = reader["identifyCARD"].ToString();
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
