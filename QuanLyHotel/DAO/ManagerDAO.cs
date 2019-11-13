using managerDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDAO
{
    public class ManagerDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public ManagerDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool add(ManagerDTO mng)
        {
            string query = string.Empty;
            query += "INSERT INTO [Manager] (iDM,iDU,nAME,gENDER,bIRTHDAY,aDDRESS,phoneNUMBER,eMAIL,identifyCARD) ";
            query += "VALUES (@iDC,@iDU,@nAME,@gENDER,@bIRTHDAY,@aDDRESS,@phoneNUMBER,@eMAIL,@identifyCARD)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDC", mng.IDM);
                    //cmd.Parameters.AddWithValue("@iDU", mng.IDU);
                    cmd.Parameters.AddWithValue("@nAME", mng.NAME);
                    cmd.Parameters.AddWithValue("@gENDER", mng.GENDER);
                    cmd.Parameters.AddWithValue("@bIRTHDAY", mng.BIRTHDAY);
                    cmd.Parameters.AddWithValue("@aDDRESS", mng.ADDRESS);
                    cmd.Parameters.AddWithValue("@phoneNUMBER", mng.PhoneNUMBER);
                    cmd.Parameters.AddWithValue("@eMAIL", mng.EMAIL);
                    cmd.Parameters.AddWithValue("@identifyCARD", mng.IdentifyCARD);


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
        public bool delete(ManagerDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM Manager WHERE [iDM] = @iDM"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDM", pt.IDM);
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
        public bool edit(ManagerDTO mng)
        {
            string query = string.Empty;
            query += "UPDATE Manager SET [nAME] = @nAME, [gENDER] = @gENDER, [bIRTHDAY] = @bIRTHDAY, [aDDRESS] = @aDDRESS, [phoneNUMBER] = @phoneNUMBER, [eMAIL] = @eMAIL, [identifyCARD] = @identifyCARD  WHERE [iDC] = @iDC";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDM", mng.IDM);
                    //cmd.Parameters.AddWithValue("@iDU", mng.IDU);
                    cmd.Parameters.AddWithValue("@nAME", mng.NAME);
                    cmd.Parameters.AddWithValue("@gENDER", mng.GENDER);
                    cmd.Parameters.AddWithValue("@bIRTHDAY", mng.BIRTHDAY);
                    cmd.Parameters.AddWithValue("@aDDRESS", mng.ADDRESS);
                    cmd.Parameters.AddWithValue("@phoneNUMBER", mng.PhoneNUMBER);
                    cmd.Parameters.AddWithValue("@eMAIL", mng.EMAIL);
                    cmd.Parameters.AddWithValue("@identifyCARD", mng.IdentifyCARD);
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
        public List<ManagerDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [iDC], [nAME], [gENDER], [phoneNUMBER], [eMAIL], [identifyCARD]";
            query += "FROM [Manager]";

            List<ManagerDTO> IsNameManager = new List<ManagerDTO>();

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
                                ManagerDTO ctm = new ManagerDTO();
                                ctm.IDM = int.Parse(reader["iDM"].ToString());
                                ctm.NAME = reader["nAME"].ToString();
                                ctm.GENDER = reader["gENDER"].ToString();
                                ctm.PhoneNUMBER = reader["phoneNUMBER"].ToString();
                                ctm.EMAIL = reader["eMAIL"].ToString();
                                ctm.IdentifyCARD = reader["identifyCARD"].ToString();
                                IsNameManager.Add(ctm);
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
            return IsNameManager;
        }
        public List<ManagerDTO> selectNameManager()
        {
            string query = string.Empty;
            query += "SELECT [nAME]";
            query += "FROM [Manager]";

            List<ManagerDTO> lsNameManager = new List<ManagerDTO>();

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
                                ManagerDTO kr = new ManagerDTO();
                                kr.NAME = reader["nAME"].ToString();
                                lsNameManager.Add(kr);
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
            return lsNameManager;
        }
        public List<ManagerDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [iDM], [nAME], [gENDER], [phoneNUMBER], [eMAIL], [identifyCARD]";
            query += "FROM [Manager]";
            query += " WHERE ([nAME] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDM] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([gENDER] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([phoneNUMBER] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([eMAIL] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([identifyCARD] LIKE CONCAT('%',@Keyword,'%'))";

            List<ManagerDTO> lsTimKiem = new List<ManagerDTO>();

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
                                ManagerDTO mng = new ManagerDTO();
                                mng.IDM = int.Parse(reader["iDC"].ToString());
                                mng.NAME = reader["nAME"].ToString();
                                mng.GENDER = reader["gENDER"].ToString();
                                mng.PhoneNUMBER = reader["phoneNUMBER"].ToString();
                                mng.EMAIL = reader["eMAIL"].ToString();
                                mng.IdentifyCARD = reader["identifyCARD"].ToString();
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
    }
}
