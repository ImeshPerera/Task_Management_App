using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_App
{
    public static class DatabaseConnector
    {
        private static MySqlConnection _connection;
        private static readonly string _connString = "server=localhost;uid=root;pwd=Dilshan@1234;database=taskmanagementsystem";

        public static MySqlConnection GetConnection()
        {
            if (_connection == null || _connection.State == ConnectionState.Closed || _connection.State == ConnectionState.Broken)
            {
                _connection = new MySqlConnection(_connString);
                _connection.Open();
            }
            return _connection;
        }

        public static void CloseConnection()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
