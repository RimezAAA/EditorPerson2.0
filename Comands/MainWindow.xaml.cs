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
using EditorPerson;

namespace Comands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MongoExamples.FindAll(listCharacters);
        }

        private void btndDstribute_Click(object sender, RoutedEventArgs e)
        {
            Random rnd  = new Random();
            List<Character> listCharacter = (List<Character>)listCharacters.ItemsSource;
            var list = listCharacter.OrderBy(x => x.LVL).ToArray();
            var listComandsOne = new List<Character>();
            var listComandsTwo = new List<Character>();
            var check = rnd.Next(0, 2);
            var conditionI = list.Length % 2 == 0 ? 0 : 1;
            for (int i = list.Length - 2; i >= conditionI; i -= 2)
            {
                if (check == 0)
                {
                    listComandsOne.Add(list[i]);
                    listComandsTwo.Add(list[i+1]);
                    check = rnd.Next(0,2);
                }
                else if (check == 1)
                {
                    listComandsTwo.Add(list[i]);
                    listComandsOne.Add(list[i+1]);
                    check = rnd.Next(0, 2);
                }
            }

            ComandsOne.ItemsSource = listComandsOne;
            ComandsTwo.ItemsSource = listComandsTwo;
            LVLComandOne.Content = "0";
            LVLComandTwo.Content = "0";
            foreach (var item in listComandsOne)
                LVLComandOne.Content = Convert.ToInt32(LVLComandOne.Content) + item.LVL;
            foreach (var item in listComandsTwo)
                LVLComandTwo.Content = Convert.ToInt32(LVLComandTwo.Content) + item.LVL;


        }
    }
}
