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

       
        public static List<Student> LoadFromDb()
        {
            List<Student> students = new List<Student>();

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

        public static List<Student> SearchStudent(string firstName, string lastName, string indexNumber)
        {
            List<Student> searchedStudents = new List<Student>();
            var db = new SQLiteConnection(path);
            db.CreateTable<Student>();
            var query = db.Table<Student>()
                .Where(s => s.FirstName.Contains(firstName) && s.LastName.Contains(lastName) && s.IndexNumber.Contains(indexNumber));

            foreach(var s in query)
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
    }
}
