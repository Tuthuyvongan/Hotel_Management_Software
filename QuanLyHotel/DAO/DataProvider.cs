﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=.\\SQLEXPRESS01;Initial Catalog = Hotel_Management; Integrated Security = True";

        DataTable data = new DataTable();
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            using (SqlConnection con = new SqlConnection(connectionSTR))
            {
                DataTable data = new DataTable();
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                if ( parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach ( string item in listPara)
                    {
                        if ( item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                con.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(connectionSTR))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

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

                data = command.ExecuteNonQuery();

                con.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection con = new SqlConnection(connectionSTR))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

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

                data = command.ExecuteScalar();

                con.Close();
            }
            return data;
        }
    }
}
