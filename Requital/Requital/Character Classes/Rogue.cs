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
        public void rogue(string name)
        {

            base.CharacterClass = "Rogue";
            base.characterName = name;
            base.Level = 1;
            base.Experience = 0;
            base.Health = 20;
            base.MaxHealth = 20;
            base.AttackPower = 8;
            base.SpellPower = 0;
            base.Speed = 75;
            base.MagicDefense = 0;
            base.PhysicalDefense = 2;
            base.Mana = 0;
            base.HasDefended = false;
            base.IsDead = false;
        }
    }
}
