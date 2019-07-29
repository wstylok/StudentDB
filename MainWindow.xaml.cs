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
            students.Clear();
            foreach (Student s in DataAccess.LoadFromDb())
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
            string dateOfBirth = DayOfBirthText.SelectedDate.ToString();

            students.Clear();
            foreach (Student s in DataAccess.SearchStudent(firstName, lastName, indexNumber, dateOfBirth))
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
            string dateOfBirth = DayOfBirthText.SelectedDate.ToString();

            Student student = new Student();
            if (firstName != "" && lastName != "" && indexNumber != "" && dateOfBirth != "")
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.IndexNumber = indexNumber;
                student.DateOfBirth = dateOfBirth;
                DataAccess.AddStudent(student);
            }
            FirstNameText.Text = null;
            LastNameText.Text = null;
            IndexNumberText.Text = null;
            DayOfBirthText.SelectedDate = null;

            LoadStudents();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = Results.SelectedIndex;
            DataAccess.DeleteStudent(index);

            students.Clear();
            LoadStudents();
        }

        private void Results_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddGradeBtn.Visibility = Visibility;
        }

        private void AddGradeBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = Results.SelectedIndex;
            string grade = "4.5";
            DataAccess.AddGrade(index, grade);

            students.Clear();
            LoadStudents();
        }
    }
}
