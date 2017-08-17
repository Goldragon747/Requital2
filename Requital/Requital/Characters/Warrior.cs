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
        public void warrior(string name)
        {
            
            base.CharacterClass = "Warrior";
            base.characterName = name;
            base.Level = 1;
            base.Experience = 0;
            base.Health = 30;
            base.MaxHealth = 30;
            base.AttackPower = 10;
            base.SpellPower = 0;
            base.Speed = 20;
            base.MagicDefense = 0;
            base.PhysicalDefense = 3;
            base.Mana = 0;
            base.HasDefended = false;
            base.IsDead = false;
            
        }
    }
}
