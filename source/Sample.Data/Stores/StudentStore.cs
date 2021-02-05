using Sample.Data.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Sample.Data.Stores
{
    public class StudentStore : IStudentStore
    {
        // implement methods to get student data from the database

        public Student GetStudentById(int id)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =\\uem.walton.uark.edu\UEMProfiles_Lab$\les014\RedirectedFolders\Documents\loginadvisor.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT TOP(1) Id, FirstName, LastName, Email FROM Students WHERE Id = {id}", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            var student = new Student();
            student.Id = dt.Rows[0].Field<int>("Id");
            student.Name = $"{dt.Rows[0].Field<string>("FirstName")} {dt.Rows[0].Field<string>("LastName")}";
            student.Email = dt.Rows[0].Field<string>("Email");

            return student;
        }

        public List<Student> GetStudents()
        {
            throw new System.NotImplementedException();
        }

        public List<CourseEnrollment> GetCourseEnrollmentsByStudentId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}