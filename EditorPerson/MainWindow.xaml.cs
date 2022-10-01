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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EditorPerson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MongoExamples.FindAll(listViewCharacters);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxName.Text != "")
            {
                WindowCreateRogue windowCreateRogue = new WindowCreateRogue(this, true);
                windowCreateRogue.Owner = this;
                windowCreateRogue.Show();
            }
            else
                MessageBox.Show("Заполните имя", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void listViewCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WindowCreateRogue windowCreateRogue = new WindowCreateRogue(this, false);
            windowCreateRogue.Owner = this;
            windowCreateRogue.Show();
        }
    }
}
