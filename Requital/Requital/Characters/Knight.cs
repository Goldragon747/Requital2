using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Character_Classes
{
    public class Knight : Characters
    {
        public void knight()
        {
            base.CharacterClass = "Monster";
            base.characterName = "Knight";
            base.Experience = 100;
            base.Health = 50;
            base.MaxHealth = 50;
            base.AttackPower = 5;
            base.SpellPower = 0;
            base.Speed = 40;
            base.MagicDefense = 4;
            base.PhysicalDefense = 4;
            base.Mana = 0;
            base.HasDefended = false;
            base.IsDead = false;

        }
    }
}
