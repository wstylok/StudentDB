using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentDB
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            LoadStudents();
        }

        private void LoadStudents()
        {
            Results.DataContext = "";
            //TODO podłączenie bazy
            //students.Add(new Student { FirstName = "Adam", LastName = "Kowalski", IndexNumber = "392K3E", DateOfBirth = new DateTime(2000, 1, 3).ToShortDateString(), Grades = "3, 5, 4.5" });
            //students.Add(new Student { FirstName = "Wojciech", LastName = "Stylok", IndexNumber = "194AC4", DateOfBirth = new DateTime(1994, 11, 6).ToShortDateString(), Grades = "" });
            foreach(Student s in DataAccess.LoadFromDb())
            {
                students.Add(s);
            }

            DisplayStudents();
        }

        private void DisplayStudents()
        {
            Results.ItemsSource = null;
            Results.ItemsSource = students;
            Results.DisplayMemberPath = "StudentInfo";
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameText.Text;
            string lastName = LastNameText.Text;
            string indexNumber = IndexNumberText.Text;
            
            students.Clear();
            foreach(Student s in DataAccess.SearchStudent(firstName, lastName, indexNumber))
            {
                students.Add(s);
            }
            DisplayStudents();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameText.Text;
            string lastName = LastNameText.Text;
            string indexNumber = IndexNumberText.Text;

            Student student = new Student { FirstName = firstName, LastName = lastName, IndexNumber = indexNumber };
            DataAccess.AddStudent(student);
            FirstNameText.Text = null;
            LastNameText.Text = null;
            IndexNumberText.Text = null;

            LoadStudents();
        }
    }
}
