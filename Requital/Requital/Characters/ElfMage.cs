using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Character_Classes
{
    class ElfMage : Characters
    {
        public void elfMage()
        {
            base.CharacterClass = "Monster";
            base.characterName = "Elf Mage";
            base.Experience = 150;
            base.Health = 30;
            base.MaxHealth = 30;
            base.AttackPower = 4;
            base.SpellPower = 10;
            base.Speed = 40;
            base.MagicDefense = 5;
            base.PhysicalDefense = 1;
            base.Mana = 100;
            string[] spells = { "FireBall" };
            base.Spells = spells;
            base.IsDead = false;
            base.HasDefended = false;

        }
    }
}
