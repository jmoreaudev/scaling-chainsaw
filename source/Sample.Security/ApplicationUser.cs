using System;

namespace Sample.Security
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public UserType UserType { get; set; } = UserType.Unknown;      // set initial value to unknown
        public string Name { get; set; }
    }
}