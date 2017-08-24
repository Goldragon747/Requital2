using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Cleric : Characters
    {
        public string ClericName { get; set; }
        public Cleric()
        {
            CharacterClass = "Cleric";
            characterName = ClericName;
            Level = 1;
            Experience = 0;
            Health = 15;
            MaxHealth = 15;
            AttackPower = 1;
            SpellPower = 10;
            Speed = 40;
            MagicDefense = 3;
            PhysicalDefense = 1;
            Mana = 10;
            string[] spells = { "Cure" };
            Spells = spells;
            HasDefended = false;
            IsDead = false;
        }
        public Cleric(string name)
        {

            CharacterClass = "Cleric";
            characterName = name;
            Level = 1;
            Experience = 0;
            Health = 15;
            MaxHealth = 15;
            AttackPower = 1;
            SpellPower = 10;
            Speed = 40;
            MagicDefense = 3;
            PhysicalDefense = 1;
            Mana = 10;
            string[] spells = {"Cure"};
            Spells = spells;
            HasDefended = false;
            IsDead = false;


        }
    }
}
