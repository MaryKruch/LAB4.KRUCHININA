using Microsoft.VisualBasic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB4.KRUCHININA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student<String>> students = new List<Student<String>>();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ShowExcellentStudents()
        {
            
        }

        private void mmCreate_Click(object sender, RoutedEventArgs e)
        {
            ShowStudents();
        }
        private void ShowStudents()
        {
            AddStudent ass = new AddStudent();
            if (ass.ShowDialog() == true)
            {
                int[] marks = new int[5];
                marks[0] = ass.Grade1;
                marks[1] = ass.Grade2;
                marks[2] = ass.Grade3;
                marks[3] = ass.Grade4;
                marks[4] = ass.Grade5;
                Student<String> student = new Student<String> { Name = ass.StudName!, GroupNumber = ass.GroupNumber.ToString(), Grades = marks };
                student.CalculateAverageGrade();
                student.getString();
                students.Add(student);
                students.Sort();
                Update();
            }
        }
        private void Update()
        {
            
            listStudents.ItemsSource = null;
            listStudents.ItemsSource = students;
        }

        private void tbCreate_Click(object sender, RoutedEventArgs e)
        {
            ShowStudents();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (fourfive.IsChecked==true)
            {
                List<Student<string>> temp = students.Where(p => p.IsGood() == true).ToList();
                listStudents.ItemsSource = null;
                listStudents.ItemsSource = temp;
            }
            else
            {
                listStudents.ItemsSource = null;
                listStudents.ItemsSource = students;
            }
        }
    }
}