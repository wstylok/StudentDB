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
            var query = db.Table<Student>().Where(v => v.FirstName.StartsWith("W"));

            foreach (var s in query)
            {
                students.Add(s);
            }

            return students;
        }

        public static void EditStudent(Student student)
        {

        }
    }
}
