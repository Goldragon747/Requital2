using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Spells
{
    class Spells
    {
        private string name;
        private int manaCost;
        private int damage;
        private int healing;

        public int Healing
        {
            get { return healing; }
            set { healing = value; }
        }


        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }


        public int ManaCost
        {
            get { return manaCost; }
            set { manaCost = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
