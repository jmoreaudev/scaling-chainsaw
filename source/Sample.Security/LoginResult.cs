using System;

namespace Sample.Security
{
    public class LoginResult
    {
        public LoginResult(ApplicationUser user)
        {
            this.successful = true;
            this.user = user;
            this.errorMessage = null;
        }

        public LoginResult(string errorMessage)
        {
            this.successful = false;
            this.errorMessage = errorMessage;
            this.user = null;
        }

        private readonly bool successful;
        private readonly ApplicationUser user;
        private readonly string errorMessage;

        public bool Successful => successful;
        public ApplicationUser User => user;
        public string ErrorMessage => errorMessage;
    }
}