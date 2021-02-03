using System;

namespace Sample.Security
{
    public interface ILoginManager
    {
        LoginResult Login(string username, string password, UserType userType);
    }
}