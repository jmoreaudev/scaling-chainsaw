using Sample.Data.Models;
using Sample.Data.Stores;
using Sample.Ui.Common;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sample.Ui.Students
{
    // the screen is set up here as a usercontrol, which makes it a bit easier to have the app work as a 
    // single window, where user controls are swapped out as the user navigates through the application

    public partial class StudentHomeControl : UserControl
    {
        // notice that the parent (as an interface called icontrolparent) is passed into the constructor.
        // we'll use this later so that we can navigate to other controls.
        public StudentHomeControl(IControlParent controlParent, int id)
        {
            InitializeComponent();

            // create the store (the place where we get student data from)
            studentStore = StoreFactory.BuildStudentStore();

            // load data for the student whose id was passed into the constructor--
            // we only want to do this once when the screen loads so that we don't 
            // have to call the database many times
            student = studentStore.GetStudentById(id);

            // show the student's basic info at the top of the screen--
            // this really just takes the student info we've already loaded and updates the screen;
            // it's often easier to wrap simple code like this into methods because it makes the 
            // code much easier to read--your intent is clear from how you named the method
            ShowStudentBasicInfo();

            // load the student's current course enrollments
            GetCurrentCourseEnrollments();
        }

        private readonly IStudentStore studentStore;
        private readonly Student student;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Dock = DockStyle.Fill;
        }

        private void ShowStudentBasicInfo()
        {
            StudentName.Text = student.Name;
            StudentEmail.Text = student.Email;
            StudentEnrollmentDate.Text = student.EnrollmentDate.ToString("D");  // this can be formatted as desired--see https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
        }

        private void GetCurrentCourseEnrollments()
        {
            // load the data from the store (the database)
            var courseEnrollments = studentStore.GetCourseEnrollmentsByStudentId(student.Id);

            // now make a data table to hold the data, and add columns
            var dataTable = new DataTable();
            dataTable.Columns.Add("Course");
            dataTable.Columns.Add("Grade");

            // iterate over the data you got and add it, making sure to match the number of columns
            foreach (var courseEnrollment in courseEnrollments) {
                dataTable.Rows.Add(courseEnrollment.Course.Name, courseEnrollment.Grade);
            }

            // set the data grid view's data source to your table to display the data
            CourseEnrollments.DataSource = dataTable;
        }
    }
}