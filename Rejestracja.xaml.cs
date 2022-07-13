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

namespace ProgramowanieObiektowe
{
    /// <summary>
    /// Logika interakcji dla klasy Rejestracja.xaml
    /// </summary>
    public partial class Rejestracja : Window
    {
        public Rejestracja()
        {
            


        }

        private string LoginRejestracja_TextChanged(object sender, TextChangedEventArgs e,)
        {
            string LogR = Console.ReadLine();
            LogR = new string(LogR);
            return LogR;
        }

        private string HasłoRejestracja_TextChanged(object sender, TextChangedEventArgs e)
        {
            string HasR = Console.ReadLine();
            HasR = new string(HasR);
            return HasR;
        }

        private void Zatwierdzenie_Click(object sender, RoutedEventArgs e)
        {
            if (LogR)
            {

            }
        }

        private string ImięRejestarcja_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ImieR = Console.ReadLine();
            ImieR = new string(ImieR);
            return ImieR;
        }
    }
}
