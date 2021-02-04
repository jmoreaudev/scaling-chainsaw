using Sample.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data.Stores
{
    public interface IStudentStore
    {
        List<Student> GetStudents();

        Student GetStudentById(int id);

        List<CourseEnrollment> GetCourseEnrollmentsByStudentId(int id);
    }
}
