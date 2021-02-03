
namespace Sample.Ui.Common
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.UserTypes = new System.Windows.Forms.ComboBox();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(5, 7);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(81, 4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(159, 20);
            this.Username.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(5, 33);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(81, 30);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(159, 20);
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(79, 132);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(89, 13);
            this.ErrorMessage.TabIndex = 4;
            this.ErrorMessage.Text = "An error occurred";
            this.ErrorMessage.Visible = false;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(81, 94);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // UserTypes
            // 
            this.UserTypes.FormattingEnabled = true;
            this.UserTypes.Location = new System.Drawing.Point(81, 57);
            this.UserTypes.Name = "UserTypes";
            this.UserTypes.Size = new System.Drawing.Size(159, 21);
            this.UserTypes.TabIndex = 3;
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Location = new System.Drawing.Point(5, 60);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.UserTypeLabel.TabIndex = 7;
            this.UserTypeLabel.Text = "User Type";
            // 
            // Panel
            // 
            this.Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel.Controls.Add(this.Login);
            this.Panel.Controls.Add(this.UserTypeLabel);
            this.Panel.Controls.Add(this.Password);
            this.Panel.Controls.Add(this.UsernameLabel);
            this.Panel.Controls.Add(this.ErrorMessage);
            this.Panel.Controls.Add(this.UserTypes);
            this.Panel.Controls.Add(this.PasswordLabel);
            this.Panel.Controls.Add(this.Username);
            this.Panel.Location = new System.Drawing.Point(51, 37);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(300, 151);
            this.Panel.TabIndex = 8;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(408, 232);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.ComboBox UserTypes;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.Panel Panel;
    }
}
