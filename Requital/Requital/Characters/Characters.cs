using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Requital
    {
    public class Characters : System.Windows.Controls.Button, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private int health;
        private int mana;
        private int magicD;
        private int physicalD;
        private int attackP;
        private int spellP;
        private int speed;
        private string characterClass;
        private int experience;
        private int level;
        private string[] spellsKnown;
        private bool hasDefended = false;
        private int maxHealth;
        private bool isDead;

        public bool IsDead { get { return isDead; } set { isDead = value; FieldChanged(); } }
            public int MaxHealth{ get { return maxHealth; } set { maxHealth = value; FieldChanged(); } }
            public bool HasDefended { get { return hasDefended; } set { hasDefended = value; FieldChanged(); } }
            public string[] Spells{ get { return spellsKnown; }set { spellsKnown = value; FieldChanged(); } }
            public int Level { get { return level; } set { level = value; FieldChanged(); } }
            public int Experience { get { return experience; } set { experience = value; FieldChanged(); } }
            public string characterName { get { return name; } set { name = value; FieldChanged(); } }
            public int Health { get { return health; } set { health = value; FieldChanged(); } }
            public int Mana { get { return mana; } set { mana = value; FieldChanged(); } }
            public int MagicDefense { get { return magicD; } set { magicD = value; FieldChanged(); } }
            public int PhysicalDefense { get { return physicalD; } set { physicalD = value; FieldChanged(); } }
            public int AttackPower { get { return attackP; } set { attackP = value; FieldChanged(); } }
            public int SpellPower { get { return spellP; } set { spellP = value; FieldChanged(); } }
            public int Speed { get { return speed; } set { speed = value; FieldChanged(); } }
            public string CharacterClass { get { return characterClass; } set { characterClass = value; FieldChanged(); } }
        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }

    }
    }



