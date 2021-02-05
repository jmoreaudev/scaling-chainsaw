using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Sample.Ui.Common
{
    // this is a form that serves as the container for all the screens

    public partial class ApplicationContainer : Form, IControlParent
    {
        public ApplicationContainer()
        {
            InitializeComponent();

            // create the sqlite database if it doesn't already exist
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (var sqlite2 = new SqliteConnection($@"Data Source={path}\university_data.sqlite")) {
                sqlite2.Open();
                //string sql = "create table highscores (name varchar(20), score int)";
                //SqliteCommand command = new SqliteCommand(sql, sqlite2);
                //command.ExecuteNonQuery();
            }
        }

        private UserControl currentControl;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // load the login control when the app starts up (is loaded)
            var login = new LoginControl(this);
            currentControl = login;
            Controls.Add(login);
        }

        // this method is part of icontrolparent. it's used so that child controls (the actual app screens)
        // can request that the parent (this class) switch out which control is displayed on the screen.
        // this gives the appearance of an app contained in a single window where the screen contents change.
        // look at the code in the logincontrol class to see how this is used. if you need to navigate from 
        // a control, you'll need a reference to the control parent (this class). use the class' constructor 
        // to inject this reference (again, see logincontrol for an example of how to do this).
        public void SetVisibleControl(UserControl control)
        {
            if (currentControl != null)
                Controls.Remove(currentControl);
            
            currentControl = control;
            Controls.Add(control);
        }
    }
}