
using iDal;
using Model;
using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class UserSQLContext : iUserDAL
    {
        DBConnection DBCon;
        public UserSQLContext()
        {
            DBCon = new DBConnection();
        }

        public User GetUser(string name, string password)
        {
            string query = "SELECT username, firstname, lastname FROM users WHERE username = @name AND password = @password";
            User tempUser = new User();

            DBCon.Open();
            MySqlCommand command = DBCon.Command(query);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("password", password);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tempUser.username = reader.GetString(0);
                    tempUser.firstname = reader.GetString(1);
                    tempUser.lastname = reader.GetString(2);
                }
            }
            DBCon.Close();

            return tempUser;
        }
    }
}
