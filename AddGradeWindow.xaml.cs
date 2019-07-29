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
    /// Logika interakcji dla klasy AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        public AddGradeWindow()
        {
            InitializeComponent();

            StudentNameText.Content += DataAccess.GetStudentFullName(MainWindow.SelectedStudentIndex());
        }

        private void AddGradeBtn_Click(object sender, RoutedEventArgs e)
        {
            string grade = GradeToAddText.Text;
            
            DataAccess.AddGrade(MainWindow.SelectedStudentIndex(), grade);
        
            this.Close();
        }

        private void CancelAddGradeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
