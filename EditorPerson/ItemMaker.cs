using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorPerson
{
    class ItemMaker
    {
        public static List<Item> items = new List<Item>();
        //Wizard items
        public static Item magicHelmetFirstLVL = new Item("Magic helmet 1 LVL", 100, new Conditioin(0, 20, 0, 35));
        public static Item magicHelmetSecondLVL = new Item("Magic helmet 2 LVL", 300, new Conditioin(0, 40, 0, 50));
        public static Item magicHelmetThirdLVL = new Item("Magic helmet 3 LVL", 600, new Conditioin(0, 50, 0, 100));

        public static Item magicArmorFirstLVL = new Item("Magic Armor 1 LVL", 100, new Conditioin(0, 15, 0, 35));
        public static Item magicArmorSecondLVL = new Item("Magic Armor 2 LVL", 300, new Conditioin(0, 30, 0, 80));
        public static Item magicArmorThirdLVL = new Item("Magic Armor 3 LVL", 600, new Conditioin(0, 45, 0, 200));

        public static Item magicWandFirstLVL = new Item("Magic Wand 1 LVL", 100, new Conditioin(0, 20, 0, 35));
        public static Item magicWandSecondLVL = new Item("Magic Wand 2 LVL", 300, new Conditioin(0, 40, 0, 99));
        public static Item magicWandThirdLVL = new Item("Magic Wand 3 LVL", 600, new Conditioin(0, 60, 0, 149));
        //Warrior items
        public static Item warriorHelmetFirstLVL = new Item("Warrior helmet 1 LVL", 100, new Conditioin(30, 0, 0, 0));
        public static Item warriorHelmetSecondLVL = new Item("Warrior helmet 2 LVL", 300, new Conditioin(50, 0, 0, 0));
        public static Item warriorHelmetThirdLVL = new Item("Warrior helmet 3 LVL", 600, new Conditioin(190, 0, 0, 0));

        public static Item warriorArmorFirstLVL = new Item("Warrior Armor 1 LVL", 100, new Conditioin(40, 0, 0, 0));
        public static Item warriorArmorSecondLVL = new Item("Warrior Armor 2 LVL", 300, new Conditioin(70, 0, 0, 0));
        public static Item warriorArmorThirdLVL = new Item("Warrior Armor 3 LVL", 600, new Conditioin(200, 0, 0, 0));

        public static Item warriorSwordFirstLVL = new Item("Warrior Sword 1 LVL", 100, new Conditioin(90, 0, 0, 0));
        public static Item warriorSwordSecondLVL = new Item("Warrior Sword 2 LVL", 300, new Conditioin(180, 0, 0, 0));
        public static Item warriorSwordThirdLVL = new Item("Warrior Sword 3 LVL", 600, new Conditioin(220, 0, 0, 0));
        //Rogue items
        public static Item rogueHelmetFirstLVL = new Item("Rogue helmet 1 LVL", 100, new Conditioin(0, 30, 0, 0));
        public static Item rogueHelmetSecondLVL = new Item("Rogue helmet 2 LVL", 300, new Conditioin(0, 50, 0, 0));
        public static Item rogueHelmetThirdLVL = new Item("Rogue helmet 3 LVL", 600, new Conditioin(0, 190, 0, 0));

        public static Item rogueArmorFirstLVL = new Item("Rogue Armor 1 LVL", 100, new Conditioin(0, 40, 0, 0));
        public static Item rogueArmorSecondLVL = new Item("Rogue Armor 2 LVL", 300, new Conditioin(0, 70, 0, 0));
        public static Item rogueArmorThirdLVL = new Item("Rogue Armor 3 LVL", 600, new Conditioin(0, 200, 0, 0));

        public static Item rogueSpearFirstLVL = new Item("Rogue Spear 1 LVL", 100, new Conditioin(0, 90, 0, 0));
        public static Item rogueSpearSecondLVL = new Item("Rogue Spear 2 LVL", 300, new Conditioin(0, 180, 0, 0));
        public static Item rogueSpearThirdLVL = new Item("Rogue Spear 3 LVL", 600, new Conditioin(0, 220, 0, 0));
    }
}
