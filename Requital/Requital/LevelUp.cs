using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
   
    public class LevelUp
    {
        Combat c = new Combat();
        public void pickClass(Characters Leveler)
        {
            if(Leveler.CharacterClass == "Mage")
            {
                level(Leveler, 5, 1, 3, 2, 0, 1, 3);
                Leveler.Experience = 0;
                Leveler.Level += 1;
            }
            else if(Leveler.CharacterClass == "Cleric")
            {
                level(Leveler, 5, 1, 4, 1, 0, 2, 4);
                Leveler.Experience = 0;
                Leveler.Level += 1;
            }
            else if(Leveler.CharacterClass == "Warrior")
            {
                level(Leveler, 10, 2, 0, 1, 1, 1, 0);
                Leveler.Experience = 0;
                Leveler.Level += 1;
            }
            else if (Leveler.CharacterClass == "Rogue")
            {
                level(Leveler, 5, 4, 0, 5, 1, 0, 0);
                Leveler.Experience = 0;
                Leveler.Level += 1;
            }
            else
            {
                c.loadDialogue("Doom is upon you, your enemy has leveled up!");
            }
            
        }
        public void level(Characters Leveler, int hlthGain, int atkGain, int spellPwrGain, int speedGain, int pDefenseGain, int mDefenseGain, int manaGain)
        {
            Leveler.Health += hlthGain;
            Leveler.AttackPower += atkGain;
            Leveler.SpellPower += spellPwrGain;
            Leveler.Speed += speedGain;
            Leveler.PhysicalDefense += pDefenseGain;
            Leveler.MagicDefense += mDefenseGain;
            Leveler.Mana += manaGain;
            c.loadDialogue(Leveler.Name + " has leveled up!");
        } 
    }
}
