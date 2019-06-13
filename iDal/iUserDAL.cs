using Model;
using System;

namespace iDal
{
    public interface iUserDAL
    {
        User GetUser(string name, string password);
    }
}
