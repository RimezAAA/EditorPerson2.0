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
    /// Логика взаимодействия для WindowCreateRogue.xaml
    /// </summary>
    public partial class WindowCreateRogue : Window
    {
        Character character;
        
        public WindowCreateRogue()
        {
            character = new Rogue();
            InitializeComponent();
            Initialize();
            Change();
            CreateCharacters.CalcExp(this, character);
            ProgressBarExp.Value = character.Exp;
        }

        public void Initialize()
        {
            sliderStrength.Minimum = Rogue.characteristics.MinStrenght;
            sliderStrength.Maximum = Rogue.characteristics.MaxStrenght;
            sliderDexterity.Minimum = Rogue.characteristics.MinDexterity;
            sliderDexterity.Maximum = Rogue.characteristics.MaxDexterity;
            sliderConstitution.Minimum = Rogue.characteristics.MinConstitution;
            sliderConstitution.Maximum = Rogue.characteristics.MaxConstitution;
            sliderIntellisence.Minimum = Rogue.characteristics.MinIntellisence;
            sliderIntellisence.Maximum = Rogue.characteristics.MaxIntellisence;
        }
        
        public void Change()
        {
            CreateCharacters.Change(this, character);
        }

        private void btnPlusExp100_Click(object sender, RoutedEventArgs e)
        {
            character.Exp += 1000;
            CreateCharacters.CalcLVL(this, character);
        }

        private void btnPlusExp10000_Click(object sender, RoutedEventArgs e)
        {
            character.Exp += 10000;
            CreateCharacters.CalcLVL(this, character);
        }

        private void btnPlusExp100000_Click(object sender, RoutedEventArgs e)
        {
            character.Exp += 100000;
            CreateCharacters.CalcLVL(this, character);
        }

        private void sliderStrength_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (character.Points > 0)
            {
                
            }
        }
    }
}
