using System;

namespace Sample.Security.Mock
{
    public class MockLoginManager : ILoginManager
    {
        public LoginResult Login(string username, string password, UserType userType)
        {
            if (userType == UserType.Unknown) {
                return new LoginResult(errorMessage: "User type cannot be unknown");
            }

            if (String.IsNullOrEmpty(username)) {
                return new LoginResult(errorMessage: "The username cannot be empty");
            }

            if (String.IsNullOrEmpty(password)) {
                return new LoginResult(errorMessage: "The password cannot be empty");
            }

            var user = new ApplicationUser()
            {
                Id = 1,
                Username = username,
                Name = "Application User",
                UserType = userType
            };

            return new LoginResult(user);
        }
    }
}