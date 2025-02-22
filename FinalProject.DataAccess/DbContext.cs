using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace Shopify.DataAccess
{
    public class DbContext
    {
        SqlConnection con;
        
        public DbContext(string connectionString) {
            con = new SqlConnection(connectionString);
        }
        // select
        public DataTable ExecuteQuery(string commandText)
        {
            SqlCommand cmd = new SqlCommand(commandText, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //SqlDataReader sqldr;
            //try
            //{
            //    con.Open();
            //    sqldr = cmd.ExecuteReader();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    con.Close();
            //}
            return dt;
        }

        //insert, update, delete
        public int ExecuteNonQuery(string commandText)
        {
            SqlCommand cmd = new SqlCommand(commandText, con);
            int affectedRows = 0;
            try
            {
                con.Open();
                affectedRows = cmd.ExecuteNonQuery();

            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                con.Close(); 
            }
            return affectedRows; 
        }
    }
}
