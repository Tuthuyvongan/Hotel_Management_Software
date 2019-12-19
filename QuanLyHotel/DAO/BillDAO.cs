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
            query += "INSERT INTO [bill] (idb,idr,idc,cost,checkin,checkout) ";
            query += "VALUES (@idb,@idr,@idc,@cost,@checkin,@checkout)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idb", bll.IDB);
                    cmd.Parameters.AddWithValue("@idr", bll.IDR);
                    cmd.Parameters.AddWithValue("@idc", bll.IDC);
                    cmd.Parameters.AddWithValue("@cost", bll.COST);
                    cmd.Parameters.AddWithValue("@checkin", bll.CheckIn);
                    cmd.Parameters.AddWithValue("@checkout", bll.CheckOut);
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

        public List<BillDTO> selectNameBill()
        {
            throw new NotImplementedException();
        }

        public bool delete(BillDTO bll)
        {
            string query = string.Empty;
            query += "DELETE FROM bill WHERE [idb] = @idb"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idb", bll.IDB);
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
            query += "UPDATE bill SET [idr] = @idr, [idc] = @idc, [cost] = @cost, [checkin] = @checkin, [checkout] = @checkout  WHERE [idb] = @idb";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idb", bll.IDB);
                    cmd.Parameters.AddWithValue("@idr", bll.IDR);
                    cmd.Parameters.AddWithValue("@idc", bll.IDC);
                    cmd.Parameters.AddWithValue("@cost", bll.COST);
                    cmd.Parameters.AddWithValue("@checkin", bll.CheckIn);
                    cmd.Parameters.AddWithValue("@checkout", bll.CheckOut);
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
            query += "SELECT [idb], [idr], [idc], [cost], [checkin], [checkout]";
            query += "FROM [bill]";

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
                                bll.IDB = reader["idb"].ToString();
                                bll.IDR = reader["idr"].ToString();
                                bll.IDC = reader["idc"].ToString();
                                bll.COST = Decimal.Parse(reader["cost"].ToString());
                                bll.CheckIn = DateTime.Parse(reader["checkin"].ToString());
                                bll.CheckOut = DateTime.Parse(reader["checkout"].ToString());
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
            query += "SELECT [checkin]";
            query += "FROM [bill]";

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
                                bll.CheckIn = DateTime.Parse(reader["checkin"].ToString());
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
            query += "SELECT [idb], [idr], [idc], [cost], [checkin], [checkout]";
            query += "FROM [bill]";
            query += " WHERE ([checkin] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([checkout] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([idb] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([idr] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([idc] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cost] LIKE CONCAT('%',@Keyword,'%'))";

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
                                bll.IDB = reader["idb"].ToString();
                                bll.IDR = reader["idr"].ToString();
                                bll.IDC = reader["idc"].ToString();

                                bll.COST = Decimal.Parse(reader["cost"].ToString());
                                bll.CheckIn = DateTime.Parse(reader["checkin"].ToString());
                                bll.CheckOut = DateTime.Parse(reader["checkout"].ToString());
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
