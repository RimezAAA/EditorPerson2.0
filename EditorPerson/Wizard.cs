using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorPerson
{
    class Wizard : Character
    {
        public static Characteristics characteristics = new Characteristics(10, 45, 3, 1, 20, 70, 0, 0.5, 15, 60, 3, 1, 35, 250, 2, 5);

        public Wizard() : base((characteristics.MinStrenght * characteristics.OnePointStrenghtHP) + (characteristics.MinConstitution * characteristics.OnePointConstitutionHP),
                                (characteristics.MinIntellisence * characteristics.OnePointIntellisenceMannaPoint),
                                (characteristics.MinDexterity * characteristics.OnePointDexterityPhysicalDef) + (characteristics.MinConstitution * characteristics.OnePointConstitutionPhysicalDef),
                                (characteristics.MinIntellisence * characteristics.OnePointIntellisenceMagicalAttack),
                                (characteristics.MinStrenght),
                                (characteristics.MinDexterity),
                                (characteristics.MinConstitution),
                                (characteristics.MinIntellisence),
                                (characteristics.MinStrenght * characteristics.OnePointStrenghtDamage) + (characteristics.MinDexterity * characteristics.OnePointDexterityDamage))
        {
            this.type = "Wizard";
        }

        public Wizard(Character wizard) : base((wizard.strength * characteristics.OnePointStrenghtHP) + (wizard.constitution * characteristics.OnePointConstitutionHP),
                                               wizard.intellisence * characteristics.OnePointIntellisenceMannaPoint,
                                               (wizard.dexterity * characteristics.OnePointDexterityPhysicalDef) + (wizard.constitution * characteristics.OnePointConstitutionPhysicalDef),
                                               wizard.intellisence * characteristics.OnePointIntellisenceMagicalAttack,
                                               wizard.strength, wizard.dexterity, wizard.constitution, wizard.intellisence,
                                               (wizard.strength * characteristics.OnePointStrenghtDamage) + (wizard.dexterity * characteristics.OnePointDexterityDamage))
        {
            this.type = "Wizard";
            this.name = wizard.name;
            this._id = wizard._id;
        }
    }
}
