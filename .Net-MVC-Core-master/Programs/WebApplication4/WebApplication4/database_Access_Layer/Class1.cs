using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4.database_Access_Layer
{
    public class Class1
    {
        private SqlConnection con;
        private void connection()
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\sem7\.net\Programs\WebApplication4\WebApplication4\App_Data\Demo.mdf;Integrated Security=True";
            con = new SqlConnection(connectionstring);
        }
        public DataSet getdata()
        {
           
                connection();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("showdata", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
            return ds;
        }
    }
}