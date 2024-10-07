using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ProjektWlasny
{
    public partial class MainWindow : Window
    {
        IEnumerable<int> grades = new List<int>() {1,2,3,4,5,6 };
        string name;
        string lastname;
        string pesel;
        public int idCounter = 1;
        int gradeCount = 0;
        private ObservableCollection<Student>? StudentList = null;

        public MainWindow()
        {
            InitializeComponent();
            Bind();
            
        }
        private void Bind()
        {

            StudentList = new ObservableCollection<Student>
            { };
            StudentList.Add(new Student(idCounter++, "Jan", "Czajka", "12345678901"));
            StudentList.Add(new Student(idCounter++, "Kacper", "Dąbrowski", "32345678901"));
            StudentList.Add(new Student(idCounter++, "Mateusz", "Cechowski", "32342678901"));
            StudentList.Add(new Student(idCounter++, "Adrian", "Nowak", "32345671201"));
            students.ItemsSource = StudentList;
            
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            Window1 okno1 = new Window1(this);
            okno1.ShowDialog();
        }

        private void removeStudent_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = students.SelectedItem as Student;
            if (selectedStudent != null)
            {
                StudentList.Remove(selectedStudent);
            }
            else MessageBox.Show("Nie wybrano żadnego ucznia");
        }

        private void infoStudent_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = students.SelectedItem as Student;
            if(selectedStudent != null)
            {
                Window2 okno2 = new Window2(this);
                okno2.ShowDialog();
            }
            else MessageBox.Show("Nie wybrano żadnego ucznia");

        }

        public void editList(string name, string lastname, string pesel)
        {
            StudentList.Add(new Student(idCounter++, name, lastname, pesel));
        }

        private void addGrade_Click(object sender, RoutedEventArgs e)
        {
            gradeCount++;
            for (int i = 0; i < StudentList.Count; i++)
            {
                Student student = StudentList[i];
                student.Grades.Add(null);
            }
            students.Columns.Add(new DataGridTextColumn
            {
                Binding = new Binding("Grades["+(gradeCount-1)+"]"),
                Header = gradeCount,


            }); ;
            
            

        }

        private void validate()
        {
            bool valid = true;
            for (int x = 0; x < StudentList.Count; x++)
            {
                for (int i = 0; i < gradeCount; i++)
                {
                    if (StudentList[x].Grades[i] < 1 || StudentList[x].Grades[i] > 6)
                    {
                        StudentList[x].Grades[i] = null;
                        valid = false;
                    }
                }

            }
            if (!valid)
            {
                MessageBox.Show("Oceny muszą należeć do zbioru od 1 do 6.");
            }

        }

        private void CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            validate();
        }

        private void MouseClick(object sender, MouseButtonEventArgs e)
        {
            validate();

        }

        private void BeginEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            validate();
        }

        private void SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            validate();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(gradeCount!=0)
            {
                for (int i = 0; i < gradeCount; i++)
                {
                    students.Columns.RemoveAt(3);
                    foreach (Student student in StudentList)
                    {
                        student.Grades.RemoveAt(i);
                    }
                }
            }
            
            gradeCount = 0;
            idCounter = 1;
            Bind();
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(students.SelectedItem != null)
            {
                int columnIndex = students.CurrentCell.Column.DisplayIndex;
                if (columnIndex > 2)
                {

                    students.Columns.RemoveAt(columnIndex);
                    foreach (Student student in StudentList)
                    {
                        student.Grades.RemoveAt(columnIndex-3);
                    }
                    for(int i = 0;i<gradeCount-1;i++)
                    {
                        students.Columns[i + 3].Header = i+1;
                    }
                }
                gradeCount--;
            }
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("W celu dodania oceny najpierw trzeba kliknąć przycisk 'Dodaj ocenę', a potem dwukrotnie kliknąć w wybrane pole.");
        }
    }
}
