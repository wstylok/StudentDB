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
using System.Windows.Shapes;

namespace StudentDB
{
    /// <summary>
    /// Logika interakcji dla klasy EditStudentWindow.xaml
    /// </summary>
    public partial class EditStudentWindow : Window
    {
        Student editStudent = new Student();

        public EditStudentWindow()
        {
            InitializeComponent();

            StudentNameText.Content += DataAccess.GetStudentFullName(MainWindow.SelectedStudentIndex());

            ChangeFirstNameText.Text = null;
            ChangeLastNameText.Text = null;
            ChangeDayOfBirthText.Text = null;
            ChangeIndexNumberText.Text = null;
        }

        private void CancelEditBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.EditStudent(MainWindow.SelectedStudentIndex(), editStudent);
            this.Close();
        }

        private void ChangeFirstName_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeFirstNameText.Text != null)
                editStudent.FirstName = ChangeFirstNameText.Text;
            ChangeFirstNameText.Text = null;
        }

        private void ChangeLastName_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeLastNameText.Text != null)
                editStudent.LastName = ChangeLastNameText.Text;
            ChangeLastNameText.Text = null;
        }

        private void ChangeDayOfBirth_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeDayOfBirthText.Text != null)
                editStudent.DateOfBirth = ChangeDayOfBirthText.Text;
            ChangeDayOfBirthText.Text = null;
        }

        private void ChangeIndexNumber_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeIndexNumberText.Text != null)
                editStudent.IndexNumber = ChangeIndexNumberText.Text;
            ChangeIndexNumberText.Text = null;
        }
    }
}
