using EditorPerson.Windows;
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

namespace EditorPerson
{
    /// <summary>
    /// Логика взаимодействия для AddAbility.xaml
    /// </summary>
    public partial class AddAbility : Window
    {
        Character character;
        public AddAbility(Character Character)
        {
            InitializeComponent();
            this.character = Character;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ability speed = new Ability("Speed x2");
            character.Abilities.Add(speed);
            MessageBox.Show("Completed");
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ability jump = new Ability("Jump x2");
            character.Abilities.Add(jump);
            MessageBox.Show("Completed");
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Ability invis = new Ability("Invisible +10%");
            character.Abilities.Add(invis);
            MessageBox.Show("Completed");
            this.Close();
        }
    }
}
