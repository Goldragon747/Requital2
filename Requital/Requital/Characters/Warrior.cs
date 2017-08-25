using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Warrior : Characters
    {
        public string WarriorName { get; set; }
        public Warrior()
        {
            CharacterClass = "Warrior";
            characterName = WarriorName;
            Level = 1;
            Experience = 0;
            Health = 30;
            MaxHealth = 30;
            AttackPower = 10;
            SpellPower = 0;
            Speed = 20;
            MagicDefense = 0;
            PhysicalDefense = 3;
            Mana = 0;
            HasDefended = false;
            IsDead = false;
        }
        public Warrior(string name)
        {
            
            CharacterClass = "Warrior";
            characterName = name;
            Level = 1;
            Experience = 0;
            Health = 30;
            MaxHealth = 30;
            AttackPower = 10;
            SpellPower = 0;
            Speed = 20;
            MagicDefense = 0;
            PhysicalDefense = 3;
            Mana = 0;
            HasDefended = false;
            IsDead = false;
            
        }
    }
}
