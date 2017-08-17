using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    class SkeletonArcher: Characters
    {
        public void skeletonArcher()
        {
            base.CharacterClass = "Monster";
            base.characterName = "Skeleton Archer";
            base.Experience = 20;
            base.Health = 10;
            base.MaxHealth = 10;
            base.AttackPower = 3;
            base.SpellPower = 0;
            base.Speed = 60;
            base.MagicDefense = 0;
            base.PhysicalDefense = 0;
            base.Mana = 0;
            base.IsDead = false;
        }
    }
}
