using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connStr = "your_connection_string";

        using (SqlConnection con = new SqlConnection(connStr))
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Students VALUES (1,'A')", con);

            cmd.ExecuteNonQuery();
        }
    }
}