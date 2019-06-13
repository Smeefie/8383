using DAL;
using iDal;
using Model;
using System;

namespace Logic
{
    public class UserLogic
    {
        iUserDAL context = new UserSQLContext();
        public User GetUser(string name, string password)
        {
            return context.GetUser(name, password);
        }
    }
}
