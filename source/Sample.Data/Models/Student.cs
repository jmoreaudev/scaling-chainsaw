using System;
using System.Collections.Generic;

namespace Sample.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }

        private readonly List<CourseEnrollment> enrollments = new List<CourseEnrollment>();
        public List<CourseEnrollment> Enrollments => enrollments;
    }
}