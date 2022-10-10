using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorPerson
{
    public struct Characteristics
    {
        public int MinStrenght { get; }
        public int MaxStrenght { get; }
        public int OnePointStrenghtDamage { get; }
        public int OnePointStrenghtHP { get; }

        public int MinDexterity { get; }
        public int MaxDexterity { get; }
        public int OnePointDexterityDamage { get; }
        public double OnePointDexterityPhysicalDef { get; }

        public int MinConstitution { get; }
        public int MaxConstitution { get; }
        public int OnePointConstitutionHP { get; }
        public double OnePointConstitutionPhysicalDef { get; }

        public int MinIntellisence { get; }
        public int MaxIntellisence { get; }
        public double OnePointIntellisenceMannaPoint { get; }
        public int OnePointIntellisenceMagicalAttack { get; }

        public Characteristics(int MinStrenght, int MaxStrenght, int OnePointStrenghtDamage, int OnePointStrenghtHP, int MinDexterity, int MaxDexterity, int OnePointDexterityDamage, double OnePointDexterityPhysicalDef, int MinConstitution, int MaxConstitution, int OnePointConstitutionHP, double OnePointConstitutionPhysicalDef, int MinIntellisence, int MaxIntellisence, double OnePointIntellisenceMannaPoint, int OnePointIntellisenceMagicalAttack)
        {
            this.MinStrenght = MinStrenght;
            this.MaxStrenght = MaxStrenght;
            this.OnePointStrenghtDamage = OnePointStrenghtDamage;
            this.OnePointStrenghtHP = OnePointStrenghtHP;

            this.MinDexterity = MinDexterity;
            this.MaxDexterity = MaxDexterity;
            this.OnePointDexterityDamage = OnePointDexterityDamage;
            this.OnePointDexterityPhysicalDef = OnePointDexterityPhysicalDef;

            this.MinConstitution = MinConstitution;
            this.MaxConstitution = MaxConstitution;
            this.OnePointConstitutionHP = OnePointConstitutionHP;
            this.OnePointConstitutionPhysicalDef = OnePointConstitutionPhysicalDef;

            this.MinIntellisence = MinIntellisence;
            this.MaxIntellisence = MaxIntellisence;
            this.OnePointIntellisenceMannaPoint = OnePointIntellisenceMannaPoint;
            this.OnePointIntellisenceMagicalAttack = OnePointIntellisenceMagicalAttack;
        }
    }
    [BsonKnownTypes(typeof(Wizard), typeof(Warrior), typeof(Rogue))]
    public class Character
    {
        [BsonId]
        public ObjectId _id;
        public int hp { get; set; }
        public double mannaPoint { get; set; }
        public double physicalDef { get; set; }
        public int magicalAttack { get; set; }
        public int damage { get; set; }
        public string name { get; set; }

        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intellisence { get; set; }
        public string type { get; set; }
        public int LVL { get; set; } = 1;
        public int Exp { get; set; }
        public int Points { get; set; }
        [BsonIgnoreIfNull]
        public List<Ability> Abilities { get; set; }
        public int MaxExp { get; set; }
        public List<Item> Items { get; set; }

        public Character(int hp, double mannaPoint, double physicalDef, int magicalAttack, int strength, int dexterity, int constitution, int intellisence, int damage)
        {
            this.hp = hp;
            this.mannaPoint = mannaPoint;
            this.physicalDef = physicalDef;
            this.magicalAttack = magicalAttack;
            this.damage = damage;

            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intellisence = intellisence;
            Items = new List<Item>();
            Abilities = new List<Ability>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
