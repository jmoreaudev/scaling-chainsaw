using System;

namespace Sample.Security
{
    public class LoginManager : ILoginManager
    {
        public LoginResult Login(string username, string password, UserType userType)
        {
            throw new NotImplementedException();

            // todo: update this class to call the database and return a login result--
            // you can adapt the existing database code in Form1, if you like
        }
    }
}