using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Spells
{
    public class Heal: Spells
    {
        public void healSpell()
        {
            base.Damage = 0;
            base.Healing = 5;
            base.ManaCost = 5;
            base.Name = "Heal";
            base.description = "Fills your target with vitality, healing their wounds.";
        }
    }
}
