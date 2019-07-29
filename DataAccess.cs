using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StudentDB
{
    public class DataAccess
    {
        private static string path = @".\StudentsDB.db";

        private static List<Student> students = new List<Student>();

        public static List<Student> LoadFromDb()
        {
            var db = new SQLiteConnection(path);
            db.CreateTable<Student>();
            var query = db.Table<Student>();

            foreach (var s in query)
            {
                students.Add(s);
            }

            return students;
        }

        public static void EditStudent(Student student)
        {
            var db = new SQLiteConnection(path);
            db.CreateTable<Student>();
            db.Close();
        }

        public static List<Student> SearchStudent(string firstName, string lastName, string indexNumber, string date)
        {
            List<Student> searchedStudents = new List<Student>();
            var db = new SQLiteConnection(path);
            db.CreateTable<Student>();
            var query = db.Table<Student>()
                .Where(s => s.FirstName.Contains(firstName) && s.LastName.Contains(lastName) && s.IndexNumber.Contains(indexNumber) && s.DateOfBirth.Contains(date));

            foreach (var s in query)
            {
                searchedStudents.Add(s);
            }
            db.Close();

            return searchedStudents;
        }

        public static void AddStudent(Student student)
        {
            var db = new SQLiteConnection(path);
            db.CreateTable<Student>();
            db.Insert(student);
            db.Close();
        }

        public static void DeleteStudent(int index)
        {
            int studentId = students[index].Id;
            var db = new SQLiteConnection(path);
            db.CreateTable<Student>();
            db.Execute($"delete from Student where Id = {studentId}");
            db.Close();
        }

        public static void AddGrade(int index, string grade)
        {
            int studentId = students[index].Id;
            var db = new SQLiteConnection(path);
            Student student = new Student();
            db.CreateTable<Student>();
            var query = db.Table<Student>().Where(s=>s.Id==studentId);
            foreach(var s in query)
            {
                student = s;
            }
            student.Grades += grade + "  ";
            db.Update(student);
            db.Close();
        }

        public static string GetStudentFullName(int id)
        {
            int studentId = students[id].Id;
            var db = new SQLiteConnection(path);
            Student student = new Student();
            db.CreateTable<Student>();
            var query = db.Table<Student>().Where(s => s.Id == studentId);
            foreach (var s in query)
            {
                student = s;
            }

            return $"{student.FirstName} {student.LastName}";
        }
    }
}
