using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace TwotierArchitecture
{
    public class ConnectionClass
    {
        SqlConnection con;
        SqlCommand cmd;
        public ConnectionClass()
        {
            con = new SqlConnection(@"server=ANJU\SQLEXPRESS;database=DB_1;Integrated security=true");

        }
        public int Fun_ExecuteNonQuery(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd = new SqlCommand(query, con);
            
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fun_ExecuteScalar(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd = new SqlCommand(query, con);
            
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;
        }

        public SqlDataReader Fun_ExecuteReader(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            cmd = new SqlCommand(query, con);
            
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet Fun_ExeAdapter(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}