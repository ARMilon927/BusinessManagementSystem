using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemApp.Model
{
    class DatabaseConnection
    {
        string connectionString = @"Server=.\SILENTREVENGER;Database=BusinessManagementSystemDb;Integrated Security=true";
        public static SqlConnection sqlConnection = null;
        public void ConnectionDatabase()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
    }
}
