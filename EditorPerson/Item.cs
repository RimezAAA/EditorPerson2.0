using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorPerson
{
    class Item
    {
        public static Item sword = new Item("Sword");
        public static Item MagicWand = new Item("Magic Wand");
        public static Item Spear = new Item("Spear");
        public string ItemName { get; set; }

        public Item(string itemName)
        {
            ItemName = itemName;
        }
    }
}
