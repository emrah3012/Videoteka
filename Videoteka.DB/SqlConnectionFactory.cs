using MySqlConnector;
using System;
using System.Configuration;

namespace Videoteka.DB
{
    public class SqlConnectionFactory
    {
        public static string SqlConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Baza"].ConnectionString;
            }
        }
        //public static string SqlConnectionString => ConfigurationManager.ConnectionStrings["Baza"].ConnectionString;

        public MySqlConnection GetNewConnection()
        {
            try
            {
                var connection = new MySqlConnection(SqlConnectionString);
                connection.Open();

                return connection;
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public void CloseConnection(MySqlConnection connection)
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex) 
            { 
                throw; 
            }
        }

    }
}
