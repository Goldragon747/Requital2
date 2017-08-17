using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Spells
{
    public class FireBall : Spells
    {
        public void FireBallSpell()
        {
            base.Damage = 5;
            base.Healing = 0;
            base.ManaCost = 10;
            base.Name = "FireBall";
            base.description = "Hurls a flaming ball of magical fire at your opponent.";

        }
    }
}
