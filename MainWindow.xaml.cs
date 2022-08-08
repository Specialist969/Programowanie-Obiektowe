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

namespace ProgramowanieObiektowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object hs;

        public MainWindow()
        {
            InitializeComponent();
        }
        // Przycisk umożliwienie rejestracji nowego użytkownika
        private void Rejestracja_Click(object sender, RoutedEventArgs e)
        {
            Rejestracja rej = new Rejestracja();
            rej.Show();
        }

        // Pole do wprowadzenia loginu
        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            string log = Console.ReadLine();



        }

        // Pole do wprowadzeniu hasła
        private void Hasło_TextChanged(object sender, TextChangedEventArgs e)
        {
            string hs = Console.ReadLine();


        }

        // Przycisk umożliwienie zalogowaniu się po uzupełnieniu pół Login oraz Hasło
        private void Logowanie_Click(object sender, RoutedEventArgs e)
        {
            string login = this.Login.Text;

            string haslo = this.Hasło.Text;

            if (SprawdzLoginiHaslo(login, haslo))
            {
                Window1 rej = new Window1();
                rej.Show();

            }
            else
            {
                MessageBox.Show("Niepoprawny Login albo Hasło");
            }

            //if (Login_TextChanged == null && Hasło_TextChanged == null)
            //{
            //    MessageBox.Show("Niepoprawny Login albo Hasło");
            //}
            //else if (hs == "1234")
            //{
            //    Window1 rej = new Window1();
            //    rej.Show();
            //}
        }
        public bool SprawdzLoginiHaslo(string login, string haslo)
        {
            if (login == "Paweł" & haslo == "1234")
                return true;
            else
                return false;

        }
    }
}
