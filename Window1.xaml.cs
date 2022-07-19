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
using System.Windows.Navigation;
using MySqlConnector;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProgramowanieObiektowe
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        string sql = "SELECT * FROM Filmy";
        private void TabelaDuża_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {// Wykonaj polecenie języka SQL na danych połączeniu
           using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql))
            {
                DataTable dt = new DataTable();
                // Pobierz dane i zapisz w strukturze DataTable
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //wpisz dane do kontrolki DATAGRID
                _ = dt.DefaultView;


            }
        }

        private void TabelaMała_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        public void PobierzDane()
        {
            string slq = "SELECT * FROM Pracownicy";
        }
    }
}

