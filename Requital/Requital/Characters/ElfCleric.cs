using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Character_Classes
{
    class ElfCleric : Characters
    {
        public ElfCleric()
        {
            base.CharacterClass = "Monster";
            base.characterName = "Elf Cleric";
            base.Experience = 125;
            base.Health = 40;
            base.MaxHealth = 40;
            base.AttackPower = 3;
            base.SpellPower = 10;
            base.Speed = 30;
            base.MagicDefense = 5;
            base.PhysicalDefense = 1;
            base.Mana = 100;
            string[] spells = { "Cure" };
            base.Spells = spells;
            base.HasDefended = false;
            base.IsDead = false;


        }
    }
}
