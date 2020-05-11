using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterUserLab.Models
{
    public class Database
    {
        public SQLiteConnection Connection;

        public Database()
        {
            Connection = new SQLiteConnection("DataSource=database.sqlite3");
            if(!File.Exists("./database.sqlite3"))
            SQLiteConnection.CreateFile("database.sqlite3");
        }

        public void OpenConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
