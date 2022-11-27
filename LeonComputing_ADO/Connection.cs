using System;
using System.Data.SqlClient;
using dotenv.net.Utilities;

namespace LeonComputing_ADO
{
    class Connection
    {
        public static SqlConnection connMaster;
        public static SqlConnection DataSource()
        {
            string connectionString;

            // connectionString = EnvReader.GetStringValue("SQL_SERVER_CONNECTION");
            connectionString = "Data Source=127.0.0.1;TrustServerCertificate=True;Initial Catalog=leon_computing;User ID=sa;Password=@#SaiShu2";

            connMaster = new SqlConnection(connectionString);
            return connMaster;
        }

        public void connOpen()
        {
            DataSource();
            connMaster.Open();
        }

        public void connClose()
        {
            DataSource();
            connMaster.Close();
        }
    }
}