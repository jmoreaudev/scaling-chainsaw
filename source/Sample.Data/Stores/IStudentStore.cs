using Sample.Data.Models;
using System.Collections.Generic;

namespace Sample.Data.Stores
{
    public interface IStudentStore
    {
        List<Student> GetStudents();

        Student GetStudentById(int id);

        Student GetStudentByUserId(int id);

        List<CourseEnrollment> GetCourseEnrollmentsByStudentId(int id);
    }
}
