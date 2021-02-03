using System;

namespace Sample.Security
{
    public class LoginManager : ILoginManager
    {
        public LoginResult Login(string username, string password, UserType userType)
        {
            throw new NotImplementedException();

            // todo: update this class to call the database and return a login result
        }
    }
}