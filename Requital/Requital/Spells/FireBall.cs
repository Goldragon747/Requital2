using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Spells
{
    class FireBall : Spells
    {
        public void FireBallSpell()
        {
            base.Damage = 5;
            base.Healing = 0;
            base.ManaCost = 10;
            base.Name = "FireBall";

        }
    }
}
