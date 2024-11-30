using System.Configuration;
using System.Data.SqlClient;


namespace HastanYonetim_RandevuSistem.Models
{
    internal class SqlConnecteur
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["HastanYonetim_RandevuSistem.Properties.Settings.HastaneYonetimDbConnectionString"].ConnectionString;
        public SqlConnection SqlConnection { get; set; }

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;  
        }
    }
}
