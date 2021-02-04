using Sample.Data.Models;
using System;
using System.Collections.Generic;

namespace Sample.Data.Stores.Mock
{
    // the "mock" store is a temporary class that implements the store interface.
    // this allows you to write test code to provide data to fill the screen without 
    // having to fetch the data from the real database. this is useful during development
    // because you can work on the ui separately from the database and data fetching 
    // code. it also allows you to focus on the classes that contain the data, so that 
    // you can iterate on the design more easily (without having to also update the 
    // database schema). when you are done using the mock store, update the relevant code
    // in the storefactory class so that the factory returns the real store (that talks 
    // to the database).

    public class MockStudentStore : IStudentStore
    {
        public Student GetStudentById(int id)
        {
            // "var" is a compiler shortcut that interpolates the type at compile time--
            // it's still stronly typed, it just saves a bit of space and typing
            var student = new Student()
            {
                Id = id,
                Name = "Mock Student",
                Email = "student@university.edu",
                EnrollmentDate = new DateTime(2021, 1, 1)
            };

            return student;
        }

        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            for (int counter = 1; counter <= 10; counter++) {
                var student = new Student()
                {
                    Id = counter,
                    Name = $"Mock Student {counter}",
                    Email = $"student{counter}@university.edu",
                    EnrollmentDate = new DateTime(2021, 1, 1)
                };

                students.Add(student);
            }

            return students;
        }

        public List<CourseEnrollment> GetCourseEnrollmentsByStudentId(int id)
        {
            // create a student
            var student = new Student()
            {
                Id = id,
                Name = "Mock Student",
                Email = "student@university.edu",
                EnrollmentDate = new DateTime(2021, 1, 1)
            };

            // create a set of courses
            var courses = new List<Course>();
            for (int counter = 1; counter <= 10; counter++) {
                var course = new Course()
                {
                    Id = counter,
                    Name = $"Course {counter}"
                };

                courses.Add(course);
            }

            // create a course enrollment for each course for student--
            // we do this by iterating over the list of courses and creating
            // a course enrollment for each one
            var courseEnrollments = new List<CourseEnrollment>();
            foreach (var course in courses) {
                var courseEnrollment = new CourseEnrollment()
                {
                    Id = course.Id + 100,
                    Course = course,
                    Student = student,
                    Grade = 0.0M    // the "M" means to interpret the number as a decimal
                };

                courseEnrollments.Add(courseEnrollment);
            }

            return courseEnrollments;
        }
    }
}