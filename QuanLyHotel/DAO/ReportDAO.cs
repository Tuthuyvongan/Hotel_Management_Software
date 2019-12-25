using reportDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reportDAO
{
    public class ReportDAO
    {
        private static ReportDAO instance;
        public static ReportDAO Instance
        {
            get { if (instance == null) instance = new ReportDAO(); return ReportDAO.instance; }
            private set { ReportDAO.instance = value; }
        }
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public ReportDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //
        //Add Edit Delete
        //
        #region Add Edit Delete
        public bool add(ReportDTO rm)
        {
            string query = string.Empty;

            query += "INSERT INTO [report] (idrp,month,year,roomsum,servicesum,costsum) ";
            query += "VALUES (@idrp,@month,@year,@roomsum,@servicesum,@costsum)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idrp", rm.IDRP);
                    cmd.Parameters.AddWithValue("@month", rm.MONTH);
                    cmd.Parameters.AddWithValue("@year", rm.YEAR);
                    cmd.Parameters.AddWithValue("@roomsum", rm.ROOMSUM);
                    cmd.Parameters.AddWithValue("@servicesum", rm.SERVICESUM);
                    cmd.Parameters.AddWithValue("@costsum", rm.COSTSUM);

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
        public bool delete(ReportDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM report WHERE [idrp] = @idrp"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idrp", pt.IDRP);
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
        public bool edit(ReportDTO rm)
        {
            string query = string.Empty;
            query += "UPDATE report SET [month] = @month, [year] = @year, [roomsum] = @roomsum, [servicesum] = @servicesum, [costsum] = @costsum  WHERE [idrp] = @idrp";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idrp", rm.IDRP);
                    cmd.Parameters.AddWithValue("@month", rm.MONTH);
                    cmd.Parameters.AddWithValue("@year", rm.YEAR);
                    cmd.Parameters.AddWithValue("@roomsum", rm.ROOMSUM);
                    cmd.Parameters.AddWithValue("@servicesum", rm.SERVICESUM);
                    cmd.Parameters.AddWithValue("@costsum", rm.COSTSUM);
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
        //public List<ReportDTO> select()
        //{
        //    string query = string.Empty;
        //    query += "SELECT [name], [kind], [cost], [ids] ";
        //    query += "FROM [service]";

        //    List<ReportDTO> IsNameService = new List<ReportDTO>();

        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;

        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        ReportDTO srv = new ReportDTO();
        //                        srv.IDS = reader["ids"].ToString();
        //                        srv.NAME = reader["name"].ToString();
        //                        srv.KIND = reader["kind"].ToString();
        //                        srv.COST = Decimal.Parse(reader["cost"].ToString());
        //                        IsNameService.Add(srv);
        //                    }
        //                }

        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                Console.WriteLine(ex);
        //                throw;
        //            }
        //        }
        //    }
        //    return IsNameService;
        //}
        //public List<ReportDTO> selectNameService()
        //{
        //    string query = string.Empty;
        //    query += "SELECT [name]";
        //    query += "FROM [service]";

        //    List<ReportDTO> lsNameService = new List<ReportDTO>();

        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;

        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        ReportDTO pt = new ReportDTO();
        //                        pt.NAME = reader["name"].ToString();
        //                        lsNameService.Add(pt);
        //                    }
        //                }

        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                Console.WriteLine(ex);
        //                throw;
        //            }
        //        }
        //    }
        //    return lsNameService;
        //}
        //public List<ReportDTO> search(string Keyword)
        //{
        //    string query = string.Empty;
        //    query += "SELECT [name], [kind], [cost], [idr]";
        //    query += "FROM [service]";
        //    query += " WHERE ([name] LIKE CONCAT('%',@Keyword,'%'))";
        //    query += " OR ([kind] LIKE CONCAT('%',@Keyword,'%'))";
        //    query += " OR ([cost] LIKE CONCAT('%',@Keyword,'%'))";
        //    query += " OR ([idr] LIKE CONCAT('%',@Keyword,'%'))";

        //    List<ReportDTO> lsTimKiem = new List<ReportDTO>();

        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;
        //            cmd.Parameters.AddWithValue("@Keyword", Keyword);
        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        ReportDTO srv = new ReportDTO();
        //                        srv.IDS = reader["ids"].ToString();
        //                        srv.NAME = reader["name"].ToString();
        //                        srv.KIND = reader["kind"].ToString();
        //                        srv.COST = Decimal.Parse(reader["cost"].ToString());
        //                        lsTimKiem.Add(srv);
        //                    }
        //                }

        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                Console.WriteLine(ex);
        //                throw;
        //            }
        //        }
        //    }
        //    return lsTimKiem;
        //}
        //public List<ReportDTO> selectCost(string sKeyword)
        //{
        //    string query = string.Empty;
        //    query += "SELECT [cost]";
        //    query += "FROM [service]";
        //    query += " WHERE ([name] LIKE CONCAT('%',@sKeyword,'%'))";

        //    List<ReportDTO> lsCost = new List<ReportDTO>();

        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;
        //            cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        ReportDTO pt = new ReportDTO();
        //                        pt.COST = Decimal.Parse(reader["cost"].ToString());
        //                        lsCost.Add(pt);
        //                    }
        //                }

        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                Console.WriteLine(ex);
        //                throw;
        //            }
        //        }
        //    }
        //    return lsCost;
        //}
        #endregion

        //
        //Sum
        //

        #region Sum
        //public int GetSumService()
        //{
        //    string query = string.Empty;
        //    query += "SELECT [name]";
        //    query += "FROM [service]";

        //    int Sum = 0;

        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;

        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        ServiceDTO pt = new ServiceDTO();
        //                        pt.NAME = reader["name"].ToString();
        //                        Sum++;
        //                    }
        //                }

        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                Console.WriteLine(ex);
        //                throw;
        //            }
        //        }
        //    }
        //    return Sum;
        //}

        #endregion
    }
}

