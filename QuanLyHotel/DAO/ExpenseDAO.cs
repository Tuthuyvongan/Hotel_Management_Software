using expenseDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenseDAO
{
    public class ExpenseDAO
    {
        private static ExpenseDAO instance;

        public static ExpenseDAO Instance
        {
            get { if (instance == null) instance = new ExpenseDAO(); return ExpenseDAO.instance; }
            private set { ExpenseDAO.instance = value; }
        }
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public ExpenseDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        #region Test
        public bool add(ExpenseDTO rm)
        {
            string query = string.Empty;

            query += "INSERT INTO [expense] (ide,name,kind,date,cost) ";
            query += "VALUES (@ide,@name,@kind,@date,@cost)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ide", rm.IDE);
                    cmd.Parameters.AddWithValue("@name", rm.NAME);
                    cmd.Parameters.AddWithValue("@kind", rm.KIND);
                    cmd.Parameters.AddWithValue("@date", rm.DATE);
                    cmd.Parameters.AddWithValue("@cost", rm.COST);

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
        public bool delete(ExpenseDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM expense WHERE [ide] = @ide"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ide", pt.IDE);
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
        public bool edit(ExpenseDTO rm)
        {
            string query = string.Empty;
            query += "UPDATE expense SET [name] = @name, [kind] = @kind, [cost] = @cost, [date] = @date  WHERE [ide] = @ide";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ide", rm.IDE);
                    cmd.Parameters.AddWithValue("@name", rm.NAME);
                    cmd.Parameters.AddWithValue("@kind", rm.KIND);
                    cmd.Parameters.AddWithValue("@date", rm.DATE);
                    cmd.Parameters.AddWithValue("@cost", rm.COST);
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
        public List<ExpenseDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [name], [kind], [cost], [date], [ide] ";
            query += "FROM [expense]";

            List<ExpenseDTO> IsNameService = new List<ExpenseDTO>();

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
                                ExpenseDTO srv = new ExpenseDTO();
                                srv.IDE = reader["ide"].ToString();
                                srv.NAME = reader["name"].ToString();
                                srv.KIND = reader["kind"].ToString();
                                srv.DATE = DateTime.Parse(reader["date"].ToString());
                                srv.COST = Decimal.Parse(reader["cost"].ToString());
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
        public List<ExpenseDTO> selectNameService()
        {
            string query = string.Empty;
            query += "SELECT [name]";
            query += "FROM [expense]";

            List<ExpenseDTO> lsNameService = new List<ExpenseDTO>();

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
                                ExpenseDTO pt = new ExpenseDTO();
                                pt.NAME = reader["name"].ToString();
                                lsNameService.Add(pt);
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
            return lsNameService;
        }
        public List<ExpenseDTO> search(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [name], [kind], [cost], [ide], [date]";
            query += "FROM [expense]";
            query += " WHERE ([name] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([kind] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([cost] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([date] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([ide] LIKE CONCAT('%',@Keyword,'%'))";

            List<ExpenseDTO> lsTimKiem = new List<ExpenseDTO>();

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
                                ExpenseDTO srv = new ExpenseDTO();
                                srv.IDE = reader["ids"].ToString();
                                srv.NAME = reader["name"].ToString();
                                srv.KIND = reader["kind"].ToString();
                                srv.DATE = DateTime.Parse(reader["date"].ToString());
                                srv.COST = Decimal.Parse(reader["cost"].ToString());
                                lsTimKiem.Add(srv);
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
        public List<ExpenseDTO> selectCost(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT [cost]";
            query += "FROM [expense]";
            query += " WHERE ([name] LIKE CONCAT('%',@sKeyword,'%'))";

            List<ExpenseDTO> lsCost = new List<ExpenseDTO>();

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
                                ExpenseDTO pt = new ExpenseDTO();
                                pt.COST = Decimal.Parse(reader["cost"].ToString());
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
        #endregion
    }
}
