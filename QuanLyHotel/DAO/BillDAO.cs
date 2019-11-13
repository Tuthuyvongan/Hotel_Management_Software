using billDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billDAO
{
    public class BillDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public BillDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool add(BillDTO bll)
        {
            string query = string.Empty;
            query += "INSERT INTO [Bill] (iDB,iDR,iDC,iDM,cOST,checkIN,checkOUT) ";
            query += "VALUES (@iDB,@iDR,@iDC,@iDM,@cOST,@checkIN,@checkOUT)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDB", bll.IDB);
                    //cmd.Parameters.AddWithValue("@iDR", bll.IDR);
                    //cmd.Parameters.AddWithValue("@iDC", bll.IDC);
                    //cmd.Parameters.AddWithValue("@iDM", bll.IDM);
                    cmd.Parameters.AddWithValue("@cOST", bll.COST);
                    cmd.Parameters.AddWithValue("@checkIN", bll.CheckIn);
                    cmd.Parameters.AddWithValue("@checkOUT", bll.CheckOut);
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
        public bool delete(BillDTO bll)
        {
            string query = string.Empty;
            query += "DELETE FROM Bill WHERE [iDB] = @iDB"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDB", bll.IDB);
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
        public bool edit(BillDTO bll)
        {
            string query = string.Empty;
            query += "UPDATE Bill SET [iDR] = @iDR, [iDC] = @iDC, [iDM] = @iDM, [cOST] = @cOST, [checkIN] = @checkIN, [checkOUT] = @checkOUT  WHERE [iDB] = @iDB";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@iDB", bll.IDB);
                    //cmd.Parameters.AddWithValue("@iDR", bll.IDR);
                    //cmd.Parameters.AddWithValue("@iDC", bll.IDC);
                    //cmd.Parameters.AddWithValue("@iDM", bll.IDM);
                    cmd.Parameters.AddWithValue("@cOST", bll.COST);
                    cmd.Parameters.AddWithValue("@checkIN", bll.CheckIn);
                    cmd.Parameters.AddWithValue("@checkOUT", bll.CheckOut);
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
        public List<BillDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [iDB], [iDR], [iDC], [iDM], [cOST], [checkIN], [checkOUT]";
            query += "FROM [Bill]";

            List<BillDTO> IsDateBill = new List<BillDTO>();

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
                                BillDTO bll = new BillDTO();
                                bll.IDB = int.Parse(reader["iDC"].ToString());
                                //bll.IDR = int.Parse(reader["iDC"].ToString());
                                //bll.IDC = int.Parse(reader["iDC"].ToString());
                                //bll.IDM = int.Parse(reader["iDC"].ToString());
                                bll.COST = Decimal.Parse(reader["cOST"].ToString());
                                bll.CheckIn = reader["checkIN"].ToString();
                                bll.CheckOut = reader["checkOUT"].ToString();
                                IsDateBill.Add(bll);
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
            return IsDateBill;
        }
        public List<BillDTO> selectDateBill()
        {
            string query = string.Empty;
            query += "SELECT [checkIN]";
            query += "FROM [Bill]";

            List<BillDTO> lsDateBill = new List<BillDTO>();

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
                                BillDTO bll = new BillDTO();
                                bll.CheckIn = reader["checkIN"].ToString();
                                lsDateBill.Add(bll);
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
            return lsDateBill;
        }
        public List<BillDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [iDB], [iDR], [iDC], [iDM], [cOST], [checkIN], [checkOUT]";
            query += "FROM [Bill]";
            query += " WHERE ([checkIN] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([checkOUT] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDB] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDR] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDC] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([iDM] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cOST] LIKE CONCAT('%',@Keyword,'%'))";

            List<BillDTO> lsTimKiem = new List<BillDTO>();

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
                                BillDTO bll = new BillDTO();
                                bll.IDB = int.Parse(reader["iDC"].ToString());
                                //bll.IDR = int.Parse(reader["iDC"].ToString());
                                //bll.IDC = int.Parse(reader["iDC"].ToString());
                                //bll.IDM = int.Parse(reader["iDC"].ToString());
                                bll.COST = Decimal.Parse(reader["cOST"].ToString());
                                bll.CheckIn = reader["checkIN"].ToString();
                                bll.CheckOut = reader["checkOUT"].ToString();
                                lsTimKiem.Add(bll);
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
