using Sample.Security;

namespace Sample.Ui
{
    public static class ApplicationState
    {        
        public static bool UserIsSignedIn => CurrentUser != null;
        public static ApplicationUser CurrentUser { get; set; }
        public static void SignOut()
        {
            CurrentUser = null;
        }
    }
}