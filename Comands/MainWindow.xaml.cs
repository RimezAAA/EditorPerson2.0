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
            List<Character> listCharacter = (List<Character>)listCharacters.ItemsSource;
            var list = listCharacter.OrderBy(x => x.LVL).ToArray();
            var listComandsOne = new List<Character>();
            var listComandsTwo = new List<Character>();
            if (list.Length % 2 == 0)
            {
                for (int i = list.Length - 1; i >= 0; --i)
                {
                    if (i % 2 == 0)
                        listComandsOne.Add(list[i]);
                    else 
                        listComandsTwo.Add(list[i]);
                }
            }
            else
            {
                for (int i = list.Length - 1; i > 0; --i)
                {
                    if (i % 2 == 0)
                        listComandsOne.Add(list[i]);
                    else
                        listComandsTwo.Add(list[i]);
                }
            }
            ComandsOne.ItemsSource = listComandsOne;
            ComandsTwo.ItemsSource = listComandsTwo;
            
            
            
        }
    }
}
