using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    class Skeleton : Characters
    {
        public void skeleton()
        {
            base.CharacterClass = "Monster";
            base.characterName = "Skeleton";
            base.Experience = 20;
            base.Health = 20;
            base.MaxHealth = 20;
            base.AttackPower = 3;
            base.SpellPower = 0;
            base.Speed = 50;
            base.MagicDefense = 2;
            base.PhysicalDefense = 2;
            base.Mana = 0;
            base.IsDead = false;
        }
    }
}
