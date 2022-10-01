using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorPerson
{
    class Warrior : Character
    {
        public static Characteristics characteristics = new Characteristics(30, 250, 5, 2, 15, 70, 1, 1, 20, 100, 10, 2, 10, 50, 1, 1);

        public Warrior() : base((characteristics.MinStrenght * characteristics.OnePointStrenghtHP) + (characteristics.MinConstitution * characteristics.OnePointConstitutionHP),
                                (characteristics.MinIntellisence * characteristics.OnePointIntellisenceMannaPoint),
                                (characteristics.MinDexterity * characteristics.OnePointDexterityPhysicalDef) + (characteristics.MinConstitution * characteristics.OnePointConstitutionPhysicalDef),
                                (characteristics.MinIntellisence * characteristics.OnePointIntellisenceMagicalAttack),
                                (characteristics.MinStrenght),
                                (characteristics.MinDexterity),
                                (characteristics.MinConstitution),
                                (characteristics.MinIntellisence),
                                (characteristics.MinStrenght * characteristics.OnePointStrenghtDamage) + (characteristics.MinDexterity * characteristics.OnePointDexterityDamage))
        {
            this.type = "Warrior";
        }

        public Warrior(Character warrior) : base((warrior.strength * characteristics.OnePointStrenghtHP) + (warrior.constitution * characteristics.OnePointConstitutionHP),
                                               warrior.intellisence * characteristics.OnePointIntellisenceMannaPoint,
                                               (warrior.dexterity * characteristics.OnePointDexterityPhysicalDef) + (warrior.constitution * characteristics.OnePointConstitutionPhysicalDef),
                                               warrior.intellisence * characteristics.OnePointIntellisenceMagicalAttack,
                                               warrior.strength, warrior.dexterity, warrior.constitution, warrior.intellisence,
                                               (warrior.strength * characteristics.OnePointStrenghtDamage) + (warrior.dexterity * characteristics.OnePointDexterityDamage))
        {
            this.type = "Warrior";
            this.Exp = warrior.Exp;
            this.LVL = warrior.LVL;
            this.Points = warrior.Points;
            this.name = warrior.name;
            this._id = warrior._id;
        }
    }
}
