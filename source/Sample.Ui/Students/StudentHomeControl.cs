using Sample.Data.Models;
using Sample.Data.Stores;
using Sample.Data.Stores.Mock;
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
            student = studentStore.GetStudentByUserId(id);

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
        private DataTable courseEnrollmentsDataTable = new DataTable();

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

            // add columns to the data table--for non-editable columns, 
            // get a ref to the new column and set it to read-only
            var idColumn = courseEnrollmentsDataTable.Columns.Add("Id");
            idColumn.ReadOnly = true;
            var courseColumn = courseEnrollmentsDataTable.Columns.Add("Course");
            courseColumn.ReadOnly = true;
            courseEnrollmentsDataTable.Columns.Add("Grade");

            // iterate over the data you got and add it, making sure to match the number of columns
            foreach (var courseEnrollment in courseEnrollments) {
                courseEnrollmentsDataTable.Rows.Add(
                    courseEnrollment.Id, 
                    courseEnrollment.Course.Name, 
                    courseEnrollment.Grade);
            }

            // set the data grid view's data source to your table to display the data            
            CourseEnrollments.DataSource = courseEnrollmentsDataTable;
            courseEnrollmentsDataTable.AcceptChanges();     // this sets all the rows to "unmodified" state so you can detect the changed ones later
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var changedRows = courseEnrollmentsDataTable.GetChanges(DataRowState.Modified)?.Rows;

            if (changedRows?.Count == 0) {
                return;
            }

            // to update the database, you'll want to add a method to the store that accepts course enrollments
            // todo: add a method to the interface and then call it here
        }
    }
}