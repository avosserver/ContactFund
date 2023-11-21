using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace YourNamespace
{
    public static class dbcon
    {
        // A static field to store the connection string
        private static string connectionString;

        // A static constructor to initialize the connection string
        static dbcon()
        {
            // Get the path of the executable location
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // Combine the path with the name of the database file
            string oldconnectionstring = Path.Combine(executableLocation, "YourDB.db");
            // Create the connection string
            connectionString = "Data Source =" + oldconnectionstring.ToString();
        }

        // A static method to get a connection to the SQLite database
        public static SQLiteConnection GetConnection()
        {
            // Create a new connection object using the connection string
            var connection = new SQLiteConnection(connectionString);
            // Return the connection object
            return connection;
        }
    }
}
