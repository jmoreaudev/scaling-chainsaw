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

        // the student class has a list of enrollments associated with it.
        // depending on how you set up your code, you may populate this or leave it empty.
        // the current example code fetches course enrollments on the screen a different way.
        // this is mostly just here to show that you can include related properties in a class
        // like this. additionally, this style of creating a readonly list and initializing it
        // ensures that you will never get a null reference exception when accessing the 
        // public property, as it's impossible for the list to ever be null.
        private readonly List<CourseEnrollment> enrollments = new List<CourseEnrollment>();
        public List<CourseEnrollment> Enrollments => enrollments;
    }
}