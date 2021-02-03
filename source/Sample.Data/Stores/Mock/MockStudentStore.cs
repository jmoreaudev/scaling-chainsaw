using Sample.Data.Models;
using System;
using System.Collections.Generic;

namespace Sample.Data.Stores.Mock
{
    public class MockStudentStore : IStudentStore
    {
        public Student GetStudentById(int id)
        {
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
            var students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Mock Student 1",
                    Email = "student1@university.edu",
                    EnrollmentDate = new DateTime(2021, 1, 1)
                },
                new Student()
                {
                    Id = 2,
                    Name = "Mock Student 2",
                    Email = "student2@university.edu",
                    EnrollmentDate = new DateTime(2021, 1, 1)
                },
                new Student()
                {
                    Id = 3,
                    Name = "Mock Student 3",
                    Email = "student3@university.edu",
                    EnrollmentDate = new DateTime(2021, 1, 1)
                }
            };

            return students;
        }
    }
}