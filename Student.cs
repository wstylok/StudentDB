using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StudentDB
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Grades { get; set; }

        public string StudentInfo
        {
            get
            {
                return $"{FirstName} {LastName}, indeks: {IndexNumber}, data ur: {DateOfBirth}, oceny: {Grades}\n";
            }
        }
    }
}
