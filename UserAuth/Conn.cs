using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace UserAuth
{
    public class Conn
    {
        String connectionString;
        SqlConnection conn;

        public Conn()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public SqlConnection GetConn()
        {
            return conn;
        }

        // method to open connection string
        public void OpenConn()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        // method to close connection string
        public void CloseConn()
        {
            conn.Close();
        }

        // method to execute sql queries
        public void ExecQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        // method for sql data reader
        public SqlDataReader DataReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}