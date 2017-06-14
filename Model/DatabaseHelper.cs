using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            string connStr = "Data Source=.\\;Initial Catalog=DEMO;Persist Security Info=True;User ID=sa;Password=ddm@TT";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        public static void AddOrder(string firstname, string lastname, string phoneno, string email, string address)
        {
            string insStmt = "INSERT INTO Orders (FirstName, LastName, Phone, Email, Address ) VALUES(@firstname,@lastname,@phoneno,@email,@address) ";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);

            insCmd.Parameters.AddWithValue("@firstname", firstname);
            insCmd.Parameters.AddWithValue("@lastname", lastname);
            insCmd.Parameters.AddWithValue("@phoneno", phoneno);
            insCmd.Parameters.AddWithValue("@email", email);
            insCmd.Parameters.AddWithValue("@address", address);

            try
            {
                conn.Open();
                insCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
