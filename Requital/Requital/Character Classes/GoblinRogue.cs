using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Character_Classes
{
    class GoblinRogue : Characters
    {
        public void goblinRogue()
        {
            base.CharacterClass = "Monster";
            base.characterName = "Goblin Rogue";
            base.Experience = 200;
            base.Health = 70;
            base.MaxHealth = 70;
            base.AttackPower = 10;
            base.SpellPower = 0;
            base.Speed = 100;
            base.MagicDefense = 0;
            base.PhysicalDefense = 5;
            base.Mana = 0;
            string[] spells = { };
            base.Spells = spells;
            base.HasDefended = false;
            base.IsDead = false;


        }
    }
}
