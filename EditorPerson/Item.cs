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

    class Buf
    {
        int Strength;
        int Dexterity;
        int Constitution;
        int Intellisence;

        public Buf(int strength, int dexterity, int constitution, int intellisence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intellisence = intellisence;
        }

        public Character BufCharacter(Character character)
        {
            character.strength += Strength;
            character.dexterity += Dexterity;
            character.constitution += Constitution;
            character.intellisence += Intellisence;
            switch (character.type)
            {
                case "Rogue":
                    character = new Rogue(character);
                    break;
                case "Warrior":
                    character = new Warrior(character);
                    break;
                case "Wizard":
                    character = new Wizard(character);
                    break;
            }
            return character;
        }
        public Character UnBufCharacter(Character character)
        {
            character.strength -= Strength;
            character.dexterity -= Dexterity;
            character.constitution -= Constitution;
            character.intellisence -= Intellisence;
            switch (character.type)
            {
                case "Rogue":
                    character = new Rogue(character);
                    break;
                case "Warrior":
                    character = new Warrior(character);
                    break;
                case "Wizard":
                    character = new Wizard(character);
                    break;
            }
            return character;
        }
    }
    class Item
    {
        public string ItemName { get; set; }
        public int Cost { get; set; }
        public Conditioin Conditioin { get; set; }
        public Buf Buf { get; set; }

        public Item(string itemName, int cost, Conditioin conditioin, Buf buf)
        {
            ItemName = itemName;
            Cost = cost;
            Conditioin = conditioin;
            ItemMaker.items.Add(this);
            Buf = buf;
        }
    }
}
