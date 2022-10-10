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

namespace EditorPerson.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowCreateCharacter.xaml
    /// </summary>
    public partial class WindowCreateCharacter : Window
    {
        Character character;
        MainWindow mainWindow;
        const int LvlOneExp = 1000;
        public WindowCreateCharacter(MainWindow win)
        {
            InitializeComponent();
            mainWindow = win;
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
            mainWindow.txtBoxName.Text = "";
            Initialize();
            Change();
            CalcExp();
            ProgressBarExp.Value = character.Exp;
            listViewItems.ItemsSource = ItemMaker.items;
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
            ProgressBarHP.Maximum = character.hp;
            ProgressBarHP.Value = character.hp;
            ProgressBarMP.Maximum = character.mannaPoint;
            ProgressBarMP.Value = character.mannaPoint;
            labelDamage.Content = character.damage;
            labelMA.Content = character.magicalAttack;
            labelPhysDef.Content = character.physicalDef;
            labelLVL.Content = character.LVL;
            labelPoits.Content = character.Points;
        }
        public void CalcExp()
        {
            ProgressBarExp.Maximum += character.LVL * LvlOneExp;
            character.MaxExp = (int)ProgressBarExp.Maximum;
        }

        public void CalcLVL()
        {
            while (ProgressBarExp.Maximum <= character.Exp)
            {
                ++character.LVL;
                if (character.LVL % 3 == 0)
                {
                    //AddAbility addAbility = new AddAbility(character);
                    //addAbility.Owner = this;
                    //addAbility.Show();
                }
                character.Points += 5;
                labelPoits.Content = character.Points;
                labelLVL.Content = character.LVL;
                character.Exp -= Convert.ToInt32(ProgressBarExp.Maximum);
                CalcExp();
            }
            ProgressBarExp.Value = character.Exp;
        }
        private void btnPlusExp100_Click(object sender, RoutedEventArgs e)
        {
            character.Exp += 1000;
            CalcLVL();
        }

        private void btnPlusExp10000_Click(object sender, RoutedEventArgs e)
        {
            character.Exp += 10000;
            CalcLVL();
        }

        private void btnPlusExp100000_Click(object sender, RoutedEventArgs e)
        {
            character.Exp += 100000;
            CalcLVL();
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
                            Change();
                        }
                        break;
                    case "Warrior":
                        if (int.Parse(txtBoxStrength.Text) + 1 <= Warrior.characteristics.MaxStrenght)
                        {
                            txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) + 1).ToString();
                            --character.Points;
                            character.strength = int.Parse(txtBoxStrength.Text);
                            character = new Warrior(character);
                            Change();
                        }
                        break;
                    case "Wizard":
                        if (int.Parse(txtBoxStrength.Text) + 1 <= Wizard.characteristics.MaxStrenght)
                        {
                            txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) + 1).ToString();
                            --character.Points;
                            character.strength = int.Parse(txtBoxStrength.Text);
                            character = new Wizard(character);
                            Change();
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
                        Change();
                    }
                    break;
                case "Warrior":
                    if (int.Parse(txtBoxStrength.Text) - 1 >= Warrior.characteristics.MinStrenght)
                    {
                        txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) - 1).ToString();
                        ++character.Points;
                        character.strength = int.Parse(txtBoxStrength.Text);
                        character = new Warrior(character);
                        Change();
                    }
                    break;
                case "Wizard":
                    if (int.Parse(txtBoxStrength.Text) - 1 >= Wizard.characteristics.MinStrenght)
                    {
                        txtBoxStrength.Text = (int.Parse(txtBoxStrength.Text) - 1).ToString();
                        ++character.Points;
                        character.strength = int.Parse(txtBoxStrength.Text);
                        character = new Wizard(character);
                        Change();
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
                            Change();
                        }
                        break;
                    case "Warrior":
                        if (int.Parse(txtBoxDexterity.Text) + 1 <= Warrior.characteristics.MaxDexterity)
                        {
                            txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) + 1).ToString();
                            --character.Points;
                            character.dexterity = int.Parse(txtBoxDexterity.Text);
                            character = new Warrior(character);
                            Change();
                        }
                        break;
                    case "Wizard":
                        if (int.Parse(txtBoxDexterity.Text) + 1 <= Wizard.characteristics.MaxDexterity)
                        {
                            txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) + 1).ToString();
                            --character.Points;
                            character.dexterity = int.Parse(txtBoxDexterity.Text);
                            character = new Wizard(character);
                            Change();
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
                        Change();
                    }
                    break;
                case "Warrior":
                    if (int.Parse(txtBoxDexterity.Text) - 1 >= Warrior.characteristics.MinDexterity)
                    {
                        txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) - 1).ToString();
                        ++character.Points;
                        character.dexterity = int.Parse(txtBoxDexterity.Text);
                        character = new Warrior(character);
                        Change();
                    }
                    break;
                case "Wizard":
                    if (int.Parse(txtBoxDexterity.Text) - 1 >= Wizard.characteristics.MinDexterity)
                    {
                        txtBoxDexterity.Text = (int.Parse(txtBoxDexterity.Text) - 1).ToString();
                        ++character.Points;
                        character.dexterity = int.Parse(txtBoxDexterity.Text);
                        character = new Wizard(character);
                        Change();
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
                            Change();
                        }
                        break;
                    case "Warrior":
                        if (int.Parse(txtBoxConstitution.Text) + 1 <= Warrior.characteristics.MaxConstitution)
                        {
                            txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) + 1).ToString();
                            --character.Points;
                            character.constitution = int.Parse(txtBoxConstitution.Text);
                            character = new Warrior(character);
                            Change();
                        }
                        break;
                    case "Wizard":
                        if (int.Parse(txtBoxConstitution.Text) + 1 <= Wizard.characteristics.MaxConstitution)
                        {
                            txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) + 1).ToString();
                            --character.Points;
                            character.constitution = int.Parse(txtBoxConstitution.Text);
                            character = new Wizard(character);
                            Change();
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
                        Change();
                    }
                    break;
                case "Warrior":
                    if (int.Parse(txtBoxConstitution.Text) - 1 >= Warrior.characteristics.MinConstitution)
                    {
                        txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) - 1).ToString();
                        ++character.Points;
                        character.constitution = int.Parse(txtBoxConstitution.Text);
                        character = new Warrior(character);
                        Change();
                    }
                    break;
                case "Wizard":
                    if (int.Parse(txtBoxConstitution.Text) - 1 >= Wizard.characteristics.MinConstitution)
                    {
                        txtBoxConstitution.Text = (int.Parse(txtBoxConstitution.Text) - 1).ToString();
                        ++character.Points;
                        character.constitution = int.Parse(txtBoxConstitution.Text);
                        character = new Wizard(character);
                        Change();
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
                            Change();
                        }
                        break;
                    case "Warrior":
                        if (int.Parse(txtBoxIntellisense.Text) + 1 <= Warrior.characteristics.MaxIntellisence)
                        {
                            txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) + 1).ToString();
                            --character.Points;
                            character.intellisence = int.Parse(txtBoxIntellisense.Text);
                            character = new Warrior(character);
                            Change();
                        }
                        break;
                    case "Wizard":
                        if (int.Parse(txtBoxIntellisense.Text) + 1 <= Wizard.characteristics.MaxIntellisence)
                        {
                            txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) + 1).ToString();
                            --character.Points;
                            character.intellisence = int.Parse(txtBoxIntellisense.Text);
                            character = new Wizard(character);
                            Change();
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
                        Change();
                    }
                    break;
                case "Warrior":
                    if (int.Parse(txtBoxIntellisense.Text) - 1 >= Warrior.characteristics.MinIntellisence)
                    {
                        txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) - 1).ToString();
                        ++character.Points;
                        character.intellisence = int.Parse(txtBoxIntellisense.Text);
                        character = new Warrior(character);
                        Change();
                    }
                    break;
                case "Wizard":
                    if (int.Parse(txtBoxIntellisense.Text) - 1 >= Wizard.characteristics.MinIntellisence)
                    {
                        txtBoxIntellisense.Text = (int.Parse(txtBoxIntellisense.Text) - 1).ToString();
                        ++character.Points;
                        character.intellisence = int.Parse(txtBoxIntellisense.Text);
                        character = new Wizard(character);
                        Change();
                    }
                    break;
            }
            labelPoits.Content = character.Points;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            MongoExamples.AddToDB(character);
            MongoExamples.FindAll(mainWindow.listViewCharacters);
            this.Close();
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            var tmpItem = listViewItems.SelectedItem;
            if (tmpItem != null)
            {
                if (((Item)tmpItem).Conditioin.ConditionCheck(character))
                {
                    var a = character.Items.Find(x => x.ItemName == ((Item)tmpItem).ItemName);
                    if (a == null)
                        character = ((Item)tmpItem).Buf.BufCharacter(character);
                    character.AddItem((Item)tmpItem);
                    listViewInventar.ItemsSource = null;
                    listViewInventar.ItemsSource = character.Items;
                    Initialize();
                    Change();
                }
                else
                {
                    MessageBox.Show("Не хватило характеристик");
                }
            }
        }

        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            var tmpItem = listViewInventar.SelectedItem;
            if (tmpItem != null)
            {
                character = ((Item)tmpItem).Buf.UnBufCharacter(character);
                character.Items.Remove((Item)tmpItem);
                listViewInventar.ItemsSource = null;
                listViewInventar.ItemsSource = character.Items;
                Initialize();
                Change();
            }
        }
    }
}
