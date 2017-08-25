using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Rogue : Characters
    {
        public string RogueName { get; set; }
        public Rogue()
        {
            CharacterClass = "Rogue";
            characterName = RogueName;
            Level = 1;
            Experience = 0;
            Health = 20;
            MaxHealth = 20;
            AttackPower = 8;
            SpellPower = 0;
            Speed = 75;
            MagicDefense = 0;
            PhysicalDefense = 2;
            Mana = 0;
            HasDefended = false;
            IsDead = false;
        }
        public Rogue(string name)
        {

            CharacterClass = "Rogue";
            characterName = name;
            Level = 1;
            Experience = 0;
            Health = 20;
            MaxHealth = 20;
            AttackPower = 8;
            SpellPower = 0;
            Speed = 75;
            MagicDefense = 0;
            PhysicalDefense = 2;
            Mana = 0;
            HasDefended = false;
            IsDead = false;
        }
    }
}
