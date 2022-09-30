using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorPerson
{
    class Rogue : Character
    {
        public static Characteristics characteristics = new Characteristics(15, 55, 2, 1, 30, 250, 4, 1.5, 20, 80, 6, 0, 15, 70, 1.5, 2);

        public Rogue() : base((characteristics.MinStrenght * characteristics.OnePointStrenghtHP) + (characteristics.MinConstitution * characteristics.OnePointConstitutionHP),
                                (characteristics.MinIntellisence * characteristics.OnePointIntellisenceMannaPoint),
                                (characteristics.MinDexterity * characteristics.OnePointDexterityPhysicalDef) + (characteristics.MinConstitution * characteristics.OnePointConstitutionPhysicalDef),
                                (characteristics.MinIntellisence * characteristics.OnePointIntellisenceMagicalAttack),
                                (characteristics.MinStrenght),
                                (characteristics.MinDexterity),
                                (characteristics.MinConstitution),
                                (characteristics.MinIntellisence),
                                (characteristics.MinStrenght * characteristics.OnePointStrenghtDamage) + (characteristics.MinDexterity * characteristics.OnePointDexterityDamage))
        {
            this.type = "Rogue";
        }

        public Rogue(Character rogue) : base((rogue.strength * characteristics.OnePointStrenghtHP) + (rogue.constitution * characteristics.OnePointConstitutionHP),
                                               rogue.intellisence * characteristics.OnePointIntellisenceMannaPoint,
                                               (rogue.dexterity * characteristics.OnePointDexterityPhysicalDef) + (rogue.constitution * characteristics.OnePointConstitutionPhysicalDef),
                                               rogue.intellisence * characteristics.OnePointIntellisenceMagicalAttack,
                                               rogue.strength, rogue.dexterity, rogue.constitution, rogue.intellisence,
                                               (rogue.strength * characteristics.OnePointStrenghtDamage) + (rogue.dexterity * characteristics.OnePointDexterityDamage))
        {
            this.type = "Rogue";
            this.name = rogue.name;
            this._id = rogue._id;
        }
    }
}
