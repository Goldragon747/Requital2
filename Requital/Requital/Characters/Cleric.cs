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
        public void cleric(string name)
        {

            base.CharacterClass = "Cleric";
            base.characterName = name;
            base.Level = 1;
            base.Experience = 0;
            base.Health = 15;
            base.MaxHealth = 15;
            base.AttackPower = 1;
            base.SpellPower = 10;
            base.Speed = 40;
            base.MagicDefense = 3;
            base.PhysicalDefense = 1;
            base.Mana = 10;
            string[] spells = {"Cure"};
            base.Spells = spells;
            base.HasDefended = false;
            base.IsDead = false;


        }
    }
}
