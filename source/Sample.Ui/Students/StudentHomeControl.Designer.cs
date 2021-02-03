﻿
namespace Sample.Ui.Students
{
    partial class StudentHomeControl
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
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentEmailLabel = new System.Windows.Forms.Label();
            this.StudentEmail = new System.Windows.Forms.Label();
            this.StudentEnrollmentDateLabel = new System.Windows.Forms.Label();
            this.StudentEnrollmentDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.Location = new System.Drawing.Point(8, 8);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(91, 13);
            this.StudentNameLabel.TabIndex = 0;
            this.StudentNameLabel.Text = "Student Name:";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(105, 8);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(93, 13);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "STUDENT NAME";
            // 
            // StudentEmailLabel
            // 
            this.StudentEmailLabel.AutoSize = true;
            this.StudentEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEmailLabel.Location = new System.Drawing.Point(8, 29);
            this.StudentEmailLabel.Name = "StudentEmailLabel";
            this.StudentEmailLabel.Size = new System.Drawing.Size(45, 13);
            this.StudentEmailLabel.TabIndex = 2;
            this.StudentEmailLabel.Text = "E-mail:";
            // 
            // StudentEmail
            // 
            this.StudentEmail.AutoSize = true;
            this.StudentEmail.Location = new System.Drawing.Point(105, 29);
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Size = new System.Drawing.Size(97, 13);
            this.StudentEmail.TabIndex = 3;
            this.StudentEmail.Text = "STUDENT E-MAIL";
            // 
            // StudentEnrollmentDateLabel
            // 
            this.StudentEnrollmentDateLabel.AutoSize = true;
            this.StudentEnrollmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEnrollmentDateLabel.Location = new System.Drawing.Point(8, 50);
            this.StudentEnrollmentDateLabel.Name = "StudentEnrollmentDateLabel";
            this.StudentEnrollmentDateLabel.Size = new System.Drawing.Size(57, 13);
            this.StudentEnrollmentDateLabel.TabIndex = 4;
            this.StudentEnrollmentDateLabel.Text = "Enrolled:";
            // 
            // StudentEnrollmentDate
            // 
            this.StudentEnrollmentDate.AutoSize = true;
            this.StudentEnrollmentDate.Location = new System.Drawing.Point(105, 50);
            this.StudentEnrollmentDate.Name = "StudentEnrollmentDate";
            this.StudentEnrollmentDate.Size = new System.Drawing.Size(113, 13);
            this.StudentEnrollmentDate.TabIndex = 5;
            this.StudentEnrollmentDate.Text = "ENROLLMENT DATE";
            // 
            // StudentHomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentEnrollmentDate);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.StudentEnrollmentDateLabel);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.StudentEmail);
            this.Controls.Add(this.StudentEmailLabel);
            this.Name = "StudentHomeControl";
            this.Size = new System.Drawing.Size(670, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label StudentEmailLabel;
        private System.Windows.Forms.Label StudentEmail;
        private System.Windows.Forms.Label StudentEnrollmentDateLabel;
        private System.Windows.Forms.Label StudentEnrollmentDate;
    }
}