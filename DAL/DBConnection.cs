using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DBConnection
    {
        private readonly MySqlConnection _connection;

        public DBConnection()
        {
            _connection = new MySqlConnection();
            _connection.ConnectionString = "server=localhost;database=8383;uid=root;password=qhwr68tb2";
        }

        public void Open()
        {
            _connection.Open();
        }

        public void Close()
        {
            _connection.Close();
        }

        public MySqlDataAdapter DataAdapter(string query)
        {
            return new MySqlDataAdapter(query, _connection);
        }

        public MySqlCommand Command(string query)
        {
            return new MySqlCommand(query, _connection);
        }
    }
}
