using System;
using System.Data.SqlClient;

namespace ADO.NET_Beispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add connection String
            string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            
            //Step 1: Create and configure a SQLConnection object.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //Step 2: Create and configure a SQLCommand object.
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Categories";

                    //Step 3: Retrieve data using a SQLDataReader object.
                    //SQLDataReader returns a collection of objects.
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string categoryName = dr["CategoryName"].ToString();
                        string description = dr["Description"].ToString();

                        Console.WriteLine("Category: {0} Description: {1}",categoryName, description);
                    }
                    dr.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
