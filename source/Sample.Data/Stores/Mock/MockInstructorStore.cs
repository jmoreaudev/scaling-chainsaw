using Sample.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data.Stores.Mock
{
    public class MockInstructorStore : IInstructorStore
    {
        public Instructor GetInstructorById(int id)
        {
            var instructor = new Instructor()
            {
                Id = id,
                Name = "Mock Instructor",
                Email = "instructor@university.edu",
                Telephone = "(123) 234-5678"
            };

            return instructor;
        }

        public List<Instructor> GetInstructors()
        {
            var instructors = new List<Instructor>();
            for (int counter = 1; counter <= 10; counter++) {
                var instructor = new Instructor()
                {
                    Id = counter,
                    Name = $"Mock Instructor {counter}",
                    Email = $"instructor{counter}@university.edu",
                    Telephone = "(123) 234-5678"
                };

                instructors.Add(instructor);
            }

            return instructors;
        }
    }
}
