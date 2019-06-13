using System;

namespace Model
{
    public class User
    {
        public int id;
        public string username;
        public string firstname;
        public string lastname;
        public string password;
        public string email;

        public User(int id, string username, string firstname, string lastname, string password)
        {
            this.id = id;
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
        }

        public User()
        {

        }
    }
}
