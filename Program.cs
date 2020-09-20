using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace dz_4
{
    class Program
    {
        static string connectionString = @"Server = (localdb)\\mssqllocaldb;Database = OnlineShop;Trusted_Connection=True;";
        static SqlConnection sqlConnection = null;
        static SqlCommand sqlCommand = null;
        static SqlDataReader reader = null;
        static void Main(string[] args)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand = new SqlCommand
            ("create table gruppa (Id int primary key identity, Name nvarchar(50) not null)", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Console.ReadKey();
        }
    }
}
