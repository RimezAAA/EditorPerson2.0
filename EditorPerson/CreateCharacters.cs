using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EditorPerson
{
    static class CreateCharacters
    {
        const int LvlOneExp = 1000;

        static public void Change(WindowCreateRogue window, Character character)
        {
            window.ProgressBarHP.Maximum = character.hp;
            window.ProgressBarHP.Value = character.hp;
            window.ProgressBarMP.Maximum = character.mannaPoint;
            window.ProgressBarMP.Value = character.mannaPoint;
            window.labelDamage.Content = character.damage;
            window.labelMA.Content = character.magicalAttack;
            window.labelPhysDef.Content = character.physicalDef;
            window.labelLVL.Content = character.LVL;
            window.labelPoits.Content = character.Points;
        }

        static public void CalcExp(WindowCreateRogue window, Character character)
        {
            window.ProgressBarExp.Maximum += character.LVL * LvlOneExp;
        }

        static public void CalcLVL(WindowCreateRogue window, Character character)
        {
            while (window.ProgressBarExp.Maximum <= character.Exp)
            {
                ++character.LVL;
                character.Points += 5;
                window.labelPoits.Content = character.Points;
                window.labelLVL.Content = character.LVL;
                character.Exp -= Convert.ToInt32(window.ProgressBarExp.Maximum);
                CalcExp(window, character);
            }
            window.ProgressBarExp.Value = character.Exp;
        }
    }
}
