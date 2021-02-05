
namespace Sample.Ui.Instructors
{
    partial class InstructorHomeControl
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
            this.InstructorTelephone = new System.Windows.Forms.Label();
            this.InstructorNameLabel = new System.Windows.Forms.Label();
            this.InstructorTelephoneLabel = new System.Windows.Forms.Label();
            this.InstructorName = new System.Windows.Forms.Label();
            this.InstructorEmail = new System.Windows.Forms.Label();
            this.InstructorEmailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstructorTelephone
            // 
            this.InstructorTelephone.AutoSize = true;
            this.InstructorTelephone.Location = new System.Drawing.Point(117, 50);
            this.InstructorTelephone.Name = "InstructorTelephone";
            this.InstructorTelephone.Size = new System.Drawing.Size(73, 13);
            this.InstructorTelephone.TabIndex = 11;
            this.InstructorTelephone.Text = "111-222-3333";
            // 
            // InstructorNameLabel
            // 
            this.InstructorNameLabel.AutoSize = true;
            this.InstructorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorNameLabel.Location = new System.Drawing.Point(8, 8);
            this.InstructorNameLabel.Name = "InstructorNameLabel";
            this.InstructorNameLabel.Size = new System.Drawing.Size(101, 13);
            this.InstructorNameLabel.TabIndex = 6;
            this.InstructorNameLabel.Text = "Instructor Name:";
            // 
            // InstructorTelephoneLabel
            // 
            this.InstructorTelephoneLabel.AutoSize = true;
            this.InstructorTelephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorTelephoneLabel.Location = new System.Drawing.Point(8, 50);
            this.InstructorTelephoneLabel.Name = "InstructorTelephoneLabel";
            this.InstructorTelephoneLabel.Size = new System.Drawing.Size(71, 13);
            this.InstructorTelephoneLabel.TabIndex = 10;
            this.InstructorTelephoneLabel.Text = "Telephone:";
            // 
            // InstructorName
            // 
            this.InstructorName.AutoSize = true;
            this.InstructorName.Location = new System.Drawing.Point(117, 8);
            this.InstructorName.Name = "InstructorName";
            this.InstructorName.Size = new System.Drawing.Size(112, 13);
            this.InstructorName.TabIndex = 7;
            this.InstructorName.Text = "INSTRUCTOR NAME";
            // 
            // InstructorEmail
            // 
            this.InstructorEmail.AutoSize = true;
            this.InstructorEmail.Location = new System.Drawing.Point(117, 29);
            this.InstructorEmail.Name = "InstructorEmail";
            this.InstructorEmail.Size = new System.Drawing.Size(116, 13);
            this.InstructorEmail.TabIndex = 9;
            this.InstructorEmail.Text = "INSTRUCTOR E-MAIL";
            // 
            // InstructorEmailLabel
            // 
            this.InstructorEmailLabel.AutoSize = true;
            this.InstructorEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorEmailLabel.Location = new System.Drawing.Point(8, 29);
            this.InstructorEmailLabel.Name = "InstructorEmailLabel";
            this.InstructorEmailLabel.Size = new System.Drawing.Size(45, 13);
            this.InstructorEmailLabel.TabIndex = 8;
            this.InstructorEmailLabel.Text = "E-mail:";
            // 
            // InstructorHomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InstructorTelephone);
            this.Controls.Add(this.InstructorNameLabel);
            this.Controls.Add(this.InstructorTelephoneLabel);
            this.Controls.Add(this.InstructorName);
            this.Controls.Add(this.InstructorEmail);
            this.Controls.Add(this.InstructorEmailLabel);
            this.Name = "InstructorHomeControl";
            this.Size = new System.Drawing.Size(643, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructorTelephone;
        private System.Windows.Forms.Label InstructorNameLabel;
        private System.Windows.Forms.Label InstructorTelephoneLabel;
        private System.Windows.Forms.Label InstructorName;
        private System.Windows.Forms.Label InstructorEmail;
        private System.Windows.Forms.Label InstructorEmailLabel;
    }
}
