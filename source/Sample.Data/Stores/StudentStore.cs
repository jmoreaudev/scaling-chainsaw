using Microsoft.Data.Sqlite;
using Sample.Data.Models;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Dapper;
using System.Linq;

namespace Sample.Data.Stores
{
    public class StudentStore : IStudentStore
    {
        private readonly string databasePath;

        public Student GetStudentById(int id)
        {
            Student student = null;

            using (var connection = new SqliteConnection(DataHelper.GetDatabaseFilePath())) {
                connection.Open();
                student = connection.QueryFirst<Student>($"SELECT * FROM Students WHERE Id = {id} LIMIT 1");
            }

            return student;
        }

        public Student GetStudentByUserId(int id)
        {
            Student student = null;

            using (var connection = new SqliteConnection(DataHelper.GetDatabaseFilePath())) {
                connection.Open();
                student = connection.QueryFirst<Student>($"SELECT * FROM Students WHERE UserId = {id} LIMIT 1");
            }

            return student;
        }

        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            using (var connection = new SqliteConnection(databasePath)) {
                connection.Open();
                students.AddRange(connection.Query<Student>($"SELECT * FROM Students"));
            }

            return students;
        }

        public List<CourseEnrollment> GetCourseEnrollmentsByStudentId(int id)
        {
            return new List<CourseEnrollment>();
        }
    }
}