using Sample.Data.Models;
using Sample.Data.Stores;
using Sample.Ui.Common;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sample.Ui.Students
{
    public partial class StudentHomeControl : UserControl
    {
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
            // this really just takes the student info we already loaded and updates the screen;
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
            StudentEnrollmentDate.Text = student.EnrollmentDate.ToString();  // this can be formatted as desired
        }

        private void GetCurrentCourseEnrollments()
        {
            var courseEnrollments = studentStore.GetCourseEnrollmentsByStudentId(student.Id);

            var dataTable = new DataTable();
            dataTable.Columns.Add("Course");
            dataTable.Columns.Add("Grade");

            foreach (var courseEnrollment in courseEnrollments) {
                //var row = dataTable.NewRow();
                dataTable.Rows.Add(courseEnrollment.Course.Name, courseEnrollment.Grade);
            }

            CourseEnrollments.DataSource = dataTable;
        }
    }
}
