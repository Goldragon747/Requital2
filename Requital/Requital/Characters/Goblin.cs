using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    class Goblin : Characters
    {
        public void goblin()
        {
            base.CharacterClass = "Monster";
            base.characterName = "Goblin";
            base.Experience = 10;
            base.Health = 10;
            base.MaxHealth = 10;
            base.AttackPower = 2;
            base.SpellPower = 0;
            base.Speed = 20;
            base.MagicDefense = 1;
            base.PhysicalDefense = 1;
            base.Mana = 0;
            base.HasDefended = false;
            base.IsDead = false;
            
            
        }
    }
}
