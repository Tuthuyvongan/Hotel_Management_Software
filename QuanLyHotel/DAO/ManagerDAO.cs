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
        private static ManagerDAO instance;

        public static ManagerDAO Instance
        {
            get { if (instance == null) instance = new ManagerDAO(); return ManagerDAO.instance; }
            private set { ManagerDAO.instance = value; }
        }
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
        //
        //Add Edit Delete
        //
        #region Add Edit Delete
        public bool add(ManagerDTO mng)
        {
            string query = string.Empty;
            query += "INSERT INTO [Manager] (iDM,iDU,nAME,phoneNUMBER,eMAIL) ";
            query += "VALUES (@iDC,@iDU,@nAME,@phoneNUMBER,@eMAIL)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDC", mng.IDM);
                    cmd.Parameters.AddWithValue("@iDU", mng.IDU);
                    cmd.Parameters.AddWithValue("@nAME", mng.NAME);
                    cmd.Parameters.AddWithValue("@phoneNUMBER", mng.PhoneNUMBER);
                    cmd.Parameters.AddWithValue("@eMAIL", mng.EMAIL);

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
            query += "UPDATE Manager SET [nAME] = @nAME, [phoneNUMBER] = @phoneNUMBER, [eMAIL] = @eMAIL WHERE [iDC] = @iDC";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDM", mng.IDM);
                    cmd.Parameters.AddWithValue("@iDU", mng.IDU);
                    cmd.Parameters.AddWithValue("@nAME", mng.NAME);
                    cmd.Parameters.AddWithValue("@phoneNUMBER", mng.PhoneNUMBER);
                    cmd.Parameters.AddWithValue("@eMAIL", mng.EMAIL);
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
        //List/Search
        //
        #region List/Search
        public List<ManagerDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [iDC], [iDU], [nAME], [phoneNUMBER], [eMAIL]";
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
                                ManagerDTO mng = new ManagerDTO();
                                mng.IDM = reader["iDM"].ToString();
                                mng.IDU = reader["iDU"].ToString();
                                mng.NAME = reader["nAME"].ToString();
                                mng.PhoneNUMBER = reader["phoneNUMBER"].ToString();
                                mng.EMAIL = reader["eMAIL"].ToString();                              
                                IsNameManager.Add(mng);
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
            query += "SELECT [iDM], [iDU], [nAME], [phoneNUMBER], [eMAIL]";
            query += "FROM [Manager]";
            query += " WHERE ([nAME] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDM] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDU] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([phoneNUMBER] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([eMAIL] LIKE CONCAT('%',@Keyword,'%'))";

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
                                mng.IDM = reader["iDM"].ToString();
                                mng.IDU = reader["iDU"].ToString();
                                mng.NAME = reader["nAME"].ToString();
                                mng.PhoneNUMBER = reader["phoneNUMBER"].ToString();
                                mng.EMAIL = reader["eMAIL"].ToString();
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

        #endregion
    }
}
