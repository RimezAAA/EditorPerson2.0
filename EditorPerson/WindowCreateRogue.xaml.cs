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
        
        public WindowCreateRogue(MainWindow win, bool saveOrCreate)
        {
            InitializeComponent();
            if (saveOrCreate)
            {
                switch (win.selectCharcter.Text)
                {
                    case "Rogue":
                        character = new Rogue();
                        character.type = "Rogue";
                        character.name = win.txtBoxName.Text;
                        break;
                    case "Warrior":
                        character = new Warrior();
                        character.type = "Warrior";
                        character.name = win.txtBoxName.Text;
                        break;
                    case "Wizard":
                        character = new Wizard();
                        character.type = "Wizard";
                        character.name = win.txtBoxName.Text;
                        break;
                }
                btnSave.Visibility = Visibility.Collapsed;
            }
            else
            {
                Character ch = (Character)win.listViewCharacters.SelectedItem;
                character = MongoExamples.Find(ch.name);
                SaveOrCreate.Visibility = Visibility.Collapsed;
                foreach (var item in character.Items)
                {
                    itemListViev.Items.Add(item.ItemName);
                }
            }
            win.txtBoxName.Text = "";
            
            Initialize();
            Change();
            CreateCharacters.CalcExp(this, character);
            ProgressBarExp.Value = character.Exp;
        }

        public void Initialize()
        {
            txtBoxStrength.Text = character.strength.ToString();
            txtBoxDexterity.Text = character.dexterity.ToString();
            txtBoxConstitution.Text = character.constitution.ToString();
            txtBoxIntellisense.Text = character.intellisence.ToString();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (character.Points > 0)
            {
                switch (character.type)
                {
                    case "Rogue":
                        if (int.Parse(txtBoxStrength.Text) + 1 <= Rogue.characteristics.MaxStrenght)
                        {
                            txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) + 1).ToString();
                            --character.Points;
                            character.strength = int.Parse(txtBoxStrength.Text);
                            character = new Rogue(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                    case "Warrior":
                        if (int.Parse(txtBoxStrength.Text) + 1 <= Warrior.characteristics.MaxStrenght)
                        {
                            txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) + 1).ToString();
                            --character.Points;
                            character.strength = int.Parse(txtBoxStrength.Text);
                            character = new Warrior(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                    case "Wizard":
                        if (int.Parse(txtBoxStrength.Text) + 1 <= Wizard.characteristics.MaxStrenght)
                        {
                            txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) + 1).ToString();
                            --character.Points;
                            character.strength = int.Parse(txtBoxStrength.Text);
                            character = new Wizard(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                }
                labelPoits.Content = character.Points;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            switch (character.type)
            {
                case "Rogue":
                    if (int.Parse(txtBoxStrength.Text) - 1 >= Rogue.characteristics.MinStrenght)
                    {
                        txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) - 1).ToString();
                        ++character.Points;
                        character.strength = int.Parse(txtBoxStrength.Text);
                        character = new Rogue(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
                case "Warrior":
                    if (int.Parse(txtBoxStrength.Text) - 1 >= Warrior.characteristics.MinStrenght)
                    {
                        txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) - 1).ToString();
                        ++character.Points;
                        character.strength = int.Parse(txtBoxStrength.Text);
                        character = new Warrior(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
                case "Wizard":
                    if (int.Parse(txtBoxStrength.Text) - 1 >= Wizard.characteristics.MinStrenght)
                    {
                        txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) - 1).ToString();
                        ++character.Points;
                        character.strength = int.Parse(txtBoxStrength.Text);
                        character = new Wizard(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
            }
            labelPoits.Content = character.Points;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (character.Points > 0)
            {
                switch (character.type)
                {
                    case "Rogue":
                        if (int.Parse(txtBoxDexterity.Text) + 1 <= Rogue.characteristics.MaxDexterity)
                        {
                            txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) + 1).ToString();
                            --character.Points;
                            character.dexterity = int.Parse(txtBoxDexterity.Text);
                            character = new Rogue(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                    case "Warrior":
                        if (int.Parse(txtBoxDexterity.Text) + 1 <= Warrior.characteristics.MaxDexterity)
                        {
                            txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) + 1).ToString();
                            --character.Points;
                            character.dexterity = int.Parse(txtBoxDexterity.Text);
                            character = new Warrior(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                    case "Wizard":
                        if (int.Parse(txtBoxDexterity.Text) + 1 <= Wizard.characteristics.MaxDexterity)
                        {
                            txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) + 1).ToString();
                            --character.Points;
                            character.dexterity = int.Parse(txtBoxDexterity.Text);
                            character = new Wizard(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                }
                labelPoits.Content = character.Points;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (character.type)
            {
                case "Rogue":
                    if (int.Parse(txtBoxDexterity.Text) - 1 >= Rogue.characteristics.MinDexterity)
                    {
                        txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) - 1).ToString();
                        ++character.Points;
                        character.dexterity = int.Parse(txtBoxDexterity.Text);
                        character = new Rogue(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
                case "Warrior":
                    if (int.Parse(txtBoxDexterity.Text) - 1 >= Warrior.characteristics.MinDexterity)
                    {
                        txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) - 1).ToString();
                        ++character.Points;
                        character.dexterity = int.Parse(txtBoxDexterity.Text);
                        character = new Warrior(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
                case "Wizard":
                    if (int.Parse(txtBoxDexterity.Text) - 1 >= Wizard.characteristics.MinDexterity)
                    {
                        txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) - 1).ToString();
                        ++character.Points;
                        character.dexterity = int.Parse(txtBoxDexterity.Text);
                        character = new Wizard(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
            }
            labelPoits.Content = character.Points;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (character.Points > 0)
            {
                switch (character.type)
                {
                    case "Rogue":
                        if (int.Parse(txtBoxConstitution.Text) + 1 <= Rogue.characteristics.MaxConstitution)
                        {
                            txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) + 1).ToString();
                            --character.Points;
                            character.constitution = int.Parse(txtBoxConstitution.Text);
                            character = new Rogue(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                    case "Warrior":
                        if (int.Parse(txtBoxConstitution.Text) + 1 <= Warrior.characteristics.MaxConstitution)
                        {
                            txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) + 1).ToString();
                            --character.Points;
                            character.constitution = int.Parse(txtBoxConstitution.Text);
                            character = new Warrior(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                    case "Wizard":
                        if (int.Parse(txtBoxConstitution.Text) + 1 <= Wizard.characteristics.MaxConstitution)
                        {
                            txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) + 1).ToString();
                            --character.Points;
                            character.constitution = int.Parse(txtBoxConstitution.Text);
                            character = new Wizard(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                }
                labelPoits.Content = character.Points;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            switch (character.type)
            {
                case "Rogue":
                    if (int.Parse(txtBoxConstitution.Text) - 1 >= Rogue.characteristics.MinConstitution)
                    {
                        txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) - 1).ToString();
                        ++character.Points;
                        character.constitution = int.Parse(txtBoxConstitution.Text);
                        character = new Rogue(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
                case "Warrior":
                    if (int.Parse(txtBoxConstitution.Text) - 1 >= Warrior.characteristics.MinConstitution)
                    {
                        txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) - 1).ToString();
                        ++character.Points;
                        character.constitution = int.Parse(txtBoxConstitution.Text);
                        character = new Warrior(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
                case "Wizard":
                    if (int.Parse(txtBoxConstitution.Text) - 1 >= Wizard.characteristics.MinConstitution)
                    {
                        txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) - 1).ToString();
                        ++character.Points;
                        character.constitution = int.Parse(txtBoxConstitution.Text);
                        character = new Wizard(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
            }
            labelPoits.Content = character.Points;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (character.Points > 0)
            {
                switch (character.type)
                {
                    case "Rogue":
                        if (int.Parse(txtBoxIntellisense.Text) + 1 <= Rogue.characteristics.MaxIntellisence)
                        {
                            txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) + 1).ToString();
                            --character.Points;
                            character.intellisence = int.Parse(txtBoxIntellisense.Text);
                            character = new Rogue(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                    case "Warrior":
                        if (int.Parse(txtBoxIntellisense.Text) + 1 <= Warrior.characteristics.MaxIntellisence)
                        {
                            txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) + 1).ToString();
                            --character.Points;
                            character.intellisence = int.Parse(txtBoxIntellisense.Text);
                            character = new Warrior(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                    case "Wizard":
                        if (int.Parse(txtBoxIntellisense.Text) + 1 <= Wizard.characteristics.MaxIntellisence)
                        {
                            txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) + 1).ToString();
                            --character.Points;
                            character.intellisence = int.Parse(txtBoxIntellisense.Text);
                            character = new Wizard(character);
                            CreateCharacters.Change(this, character);
                        }
                        break;
                }
                labelPoits.Content = character.Points;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            switch (character.type)
            {
                case "Rogue":
                    if (int.Parse(txtBoxIntellisense.Text) - 1 >= Rogue.characteristics.MinIntellisence)
                    {
                        txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) - 1).ToString();
                        ++character.Points;
                        character.intellisence = int.Parse(txtBoxIntellisense.Text);
                        character = new Rogue(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
                case "Warrior":
                    if (int.Parse(txtBoxIntellisense.Text) - 1 >= Warrior.characteristics.MinIntellisence)
                    {
                        txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) - 1).ToString();
                        ++character.Points;
                        character.intellisence = int.Parse(txtBoxIntellisense.Text);
                        character = new Warrior(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
                case "Wizard":
                    if (int.Parse(txtBoxIntellisense.Text) - 1 >= Wizard.characteristics.MinIntellisence)
                    {
                        txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) - 1).ToString();
                        ++character.Points;
                        character.intellisence = int.Parse(txtBoxIntellisense.Text);
                        character = new Wizard(character);
                        CreateCharacters.Change(this, character);
                    }
                    break;
            }
            labelPoits.Content = character.Points;
        }

        private void btnSword_Click(object sender, RoutedEventArgs e)
        {
            character.AddItem(Item.sword);
            itemListViev.Items.Clear();
            foreach (var item in character.Items)
            {
                itemListViev.Items.Add(item.ItemName);
            }
        }

        private void btnMagicWand_Click(object sender, RoutedEventArgs e)
        {
            character.AddItem(Item.MagicWand);
            itemListViev.Items.Clear();
            foreach (var item in character.Items)
            {
                itemListViev.Items.Add(item.ItemName);
            }
        }

        private void btnSpear_Click(object sender, RoutedEventArgs e)
        {
            character.AddItem(Item.Spear);
            itemListViev.Items.Clear();
            foreach (var item in character.Items)
            {
                itemListViev.Items.Add(item.ItemName);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            switch (itemListViev.SelectedItems[0].ToString())
            {
                case "Sword":
                    character.Items.Remove(Item.sword);
                    break;
                case "Magic Wand":
                    character.Items.Remove(Item.MagicWand);
                    break;
                case "Spear":
                    character.Items.Remove(Item.Spear);
                    break;
            }
            itemListViev.Items.Clear();
            foreach (var item in character.Items)
            {
                itemListViev.Items.Add(item.ItemName);
            }
        }

        private void SaveOrCreate_Click(object sender, RoutedEventArgs e)
        {
            MongoExamples.AddToDB(character);
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MongoExamples.ReplaceByName(character.name, character);
            this.Close();
        }
    }
}
