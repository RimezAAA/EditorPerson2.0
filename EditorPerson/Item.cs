using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorPerson
{
    
    class Conditioin
    {
        int Strength;
        int Dexterity;
        int Constitution;
        int Intellisence;

        public Conditioin(int strength, int dexterity, int constitution, int intellisence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intellisence = intellisence;
        }

        public bool ConditionCheck(Character character)
        {
            if (character.strength > Strength && character.dexterity > Dexterity && character.constitution > Constitution && character.intellisence > Intellisence)
                return true;
            return false;
        }
    }
    class Item
    {
        public string ItemName { get; set; }
        public int Cost { get; set; }
        public Conditioin Conditioin { get; set; }

        public Item(string itemName, int cost, Conditioin conditioin)
        {
            ItemName = itemName;
            Cost = cost;
            Conditioin = conditioin;
            ItemMaker.items.Add(this);
        }
    }
}
