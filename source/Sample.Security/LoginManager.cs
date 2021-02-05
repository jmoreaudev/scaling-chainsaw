using Dapper;
using Microsoft.Data.Sqlite;
using Sample.Data;
using Sample.Data.Models;
using System;
using System.Linq;

namespace Sample.Security
{
    public class LoginManager : ILoginManager
    {
        public LoginResult Login(string username, string password, UserType userType)
        {
            using (var connection = new SqliteConnection(DataHelper.GetDatabaseFilePath())) {
                connection.Open();
                var user = connection
                    .Query<User>($"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}' AND UserType = '{userType}' LIMIT 1")
                    .FirstOrDefault();

                if (user == null) {
                    return new LoginResult("The credentials were not valid");
                }

                var applicationUser = new ApplicationUser()
                {
                    Id = user.Id,
                    Username = user.Username,
                    UserType = userType
                };
                return new LoginResult(applicationUser);
            }            
        }
    }
}