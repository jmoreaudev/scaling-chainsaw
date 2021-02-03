using Sample.Security;
using Sample.Security.Mock;
using Sample.Ui.Students;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sample.Ui.Common
{
    public partial class LoginControl : UserControl
    {
        public LoginControl(IControlParent controlParent)
        {
            InitializeComponent();

            // keep a reference to the parent form, which is how we request a new control be shown
            this.controlParent = controlParent;

            // create the login manager, which handles all the login requests
            this.loginManager = new MockLoginManager();
        }

        private readonly IControlParent controlParent;
        private readonly ILoginManager loginManager;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Dock = DockStyle.Fill;

            // fill the drop-down list with the user types (except for unknown)
            this.UserTypes.DataSource = Enum.GetValues(typeof(UserType))
                .Cast<UserType>()
                .Where(item => item != UserType.Unknown)
                .ToList();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // hide the error label if it was visible
            ErrorMessage.Visible = false;

            // get the username, password, and user type from the screen
            var username = this.Username.Text;
            var password = this.Password.Text;

            UserType userType = UserType.Unknown;
            Enum.TryParse<UserType>(UserTypes.SelectedValue.ToString(), out userType);

            // send the data to the login manager
            var loginResult = loginManager.Login(username, password, userType);

            // if the result wasn't successful, show the error message and stop (return)
            if (!loginResult.Successful) {
                ErrorMessage.Text = loginResult.ErrorMessage;
                ErrorMessage.Visible = true;
                return;
            }

            // set the current application user to the user we got in the login result
            ApplicationState.CurrentUser = loginResult.User;

            // select the home form based on the user type
            UserControl control = null;
            switch (loginResult.User.UserType) {
                case UserType.Administrator:
                    //home = new AdminHome(loginResult.User.Id);
                    break;
                case UserType.Advisor:
                    //home = new AdvisorHome(loginResult.User.Id);
                    break;
                case UserType.Instructor:
                    //home = new InstructorHome(loginResult.User.Id);
                    break;
                case UserType.Student:
                    control = new StudentHomeControl(controlParent, loginResult.User.Id);
                    break;
                default:                    
                    break;
            }

            // if we didn't set a control above, something is wrong...show an error
            if (control == null) {
                ErrorMessage.Text = "An error occurred when logging in!";
                ErrorMessage.Visible = true;
                return;
            }

            // otherwise, go to the new control
            controlParent.SetVisibleControl(control);
        }
    }
}