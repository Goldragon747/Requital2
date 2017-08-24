using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Mage : Characters
    {
        public string MageName { get; set; }
        public Mage()
        {
            CharacterClass = "Mage";
            characterName = MageName;
            Level = 1;
            Experience = 0;
            Health = 10;
            MaxHealth = 10;
            AttackPower = 3;
            SpellPower = 10;
            Speed = 45;
            MagicDefense = 3;
            PhysicalDefense = 1;
            Mana = 10;
            string[] spells = { "Fireball" };
            Spells = spells;
            HasDefended = false;
            IsDead = false;
        }
        public Mage(string name)
        {

            CharacterClass = "Mage";
            characterName = name;
            Level = 1;
            Experience = 0;
            Health = 10;
            MaxHealth = 10;
            AttackPower = 3;
            SpellPower = 10;
            Speed = 45;
            MagicDefense = 3;
            PhysicalDefense = 1;
            Mana = 10;
            string[] spells = {"Fireball"};
            Spells = spells;
            HasDefended = false;
            IsDead = false;
        }
    }
}
