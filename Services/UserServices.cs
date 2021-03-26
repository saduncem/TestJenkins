using System;

namespace Services
{

    public  interface IUserServices
    {
        string GetUser(string username);
    }
    public class UserServices : IUserServices
    {
        public string GetUser(string username)
        {
            return username;
        }
    }
}
