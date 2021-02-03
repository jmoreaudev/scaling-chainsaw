using Sample.Data.Models;
using System.Collections.Generic;

namespace Sample.Data.Stores
{
    public interface IStudentStore
    {
        List<Student> GetStudents();

        Student GetStudentById(int id);
    }

    public class StudentStore : IStudentStore
    {
        // implement methods to get student data from the database

        public Student GetStudentById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new System.NotImplementedException();
        }
    }
}