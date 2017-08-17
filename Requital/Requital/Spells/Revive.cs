using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Spells
{
    public class Revive : Spells
    {
        public void revival()
        {
            base.Healing = 1;
            base.ManaCost = 100;
            base.Name = "Revive";
            base.Damage = 0;
            base.description = "Revives your fallen brethren from chilling grasp of death.";
        }
    }
}
