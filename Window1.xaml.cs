﻿using System;
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
//using MySql.Data.MySqlClient;

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

        private void TabelaDuża_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
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

