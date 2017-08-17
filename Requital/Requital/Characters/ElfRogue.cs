using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Character_Classes
{
    class ElfRogue : Characters
    {
        public void elfRogue()
        {
            base.CharacterClass = "Monster";
            base.characterName = "Elf Rogue";
            base.Experience = 100;
            base.Health = 60;
            base.MaxHealth = 60;
            base.AttackPower = 7;
            base.SpellPower = 0;
            base.Speed = 100;
            base.MagicDefense = 0;
            base.PhysicalDefense = 3;
            base.Mana = 0;
            string[] spells = {};
            base.Spells = spells;
            base.HasDefended = false;
            base.IsDead = false;


        }
    }
}
