using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProjektWlasny
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private MainWindow mainWindow = null;
        public Window1()
        {
            InitializeComponent();
        }

        public Window1(MainWindow mainWin)
        {
            InitializeComponent();
            mainWindow = mainWin;
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            bool wrong = false;
            string name = nameInput.Text;
            string lastname = lastnameInput.Text;
            string pesel = peselInput.Text;

            if(name.Length < 3 )
            {
                MessageBox.Show("Imie musi mieć conajmniej 3 znaki");
                wrong = true;
            }

            if (lastname.Length < 3)
            {
                MessageBox.Show("Nazwisko musi mieć conajmniej 3 znaki");
                wrong = true;
            }

            foreach (char c in pesel)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Pesel musi mieć tylko liczby");
                    wrong = true;
                    break;
                }
            }

            if (pesel.Length!=11)
            {
                MessageBox.Show("Pesel musi mieć 11 liczb");
                wrong = true;
            }


            if (!wrong)
            {
                mainWindow.editList(name, lastname, pesel);
                this.DialogResult = true;
            }
        }

        private void checkName(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Length < 3)
            {
                MessageBox.Show("Imie musi mieć conajmniej 3 znaki");
            }
        }
    }

}

