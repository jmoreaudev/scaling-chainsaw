using System;
using System.Windows.Forms;

namespace Sample.Ui.Common
{
    public partial class ApplicationContainer : Form, IControlParent
    {
        public ApplicationContainer()
        {
            InitializeComponent();
        }

        private UserControl currentControl;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var login = new LoginControl(this);
            currentControl = login;
            Controls.Add(login);
        }

        public void SetVisibleControl(UserControl control)
        {
            if (currentControl != null)
                Controls.Remove(currentControl);
            
            currentControl = control;
            Controls.Add(control);
        }
    }
}