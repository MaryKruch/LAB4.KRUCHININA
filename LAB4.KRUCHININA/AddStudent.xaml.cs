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

namespace LAB4.KRUCHININA
{
    /// <summary>
    /// Логика взаимодействия для addstud.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        public int GroupNumber
        {
            get
            {
                return int.Parse(tbGroupNumber.Text);
            }
            set
            {
                tbGroupNumber.Text = value.ToString();
            }
        }
        public string? StudName
        {
            get
            {
                return tbStudName.Text;
            }
            set
            {
                tbStudName.Text = value;
            }
        }
        public int Grade1
        {
            get
            {
                return int.Parse(tbGrade1.Text);
            }
            set
            {
                tbGrade1.Text = value.ToString();
            }
        }
        public int Grade2
        {
            get
            {
                return int.Parse(tbGrade2.Text);
            }
            set
            {
                tbGrade2.Text = value.ToString();
            }
        }
        public int Grade3
        {
            get
            {
                return int.Parse(tbGrade3.Text);
            }
            set
            {
                tbGrade3.Text = value.ToString();
            }
        }
        public int Grade4
        {
            get
            {
                return int.Parse(tbGrade4.Text);
            }
            set
            {
                tbGrade4.Text = value.ToString();
            }
        }
        public int Grade5
        {
            get
            {
                return int.Parse(tbGrade5.Text);
            }
            set
            {
                tbGrade5.Text = value.ToString();
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}