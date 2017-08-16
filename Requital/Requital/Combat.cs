using Requital.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Combat
    {
        
        Characters c2 = new Characters();
        Characters c1 = new Characters();
        LevelUp lvl = new LevelUp();
        //TODO- once we set up the buttons we will have to change what is being passed in to what they actually are
        //Since the child classes have the same parameters I'm pretty sure Characters works no matter who is passed in

        public void physicalAttack(Characters attacker, Characters defender)
        {
            int damage = attacker.AttackPower;
            if (defender.HasDefended == true)
            {
                damage = damage / 2;
                defender.HasDefended = false;
            }
            int finalDamage = damage - defender.PhysicalDefense;
            if (finalDamage <= 0)
            {
                finalDamage = 0;
            }
            defender.Health -= finalDamage;
            if(defender.Health <= 0 || defender.Health == 0)
            {
                defender.Health = 0;
                kill(attacker, defender);
            }
        }
        public int fireBall(Characters attacker, Characters defender)
        {
            FireBall f = new FireBall();
            if (attacker.Mana >= f.ManaCost)
            {
                attacker.Mana -= f.ManaCost;
                int damage = attacker.SpellPower + f.Damage;
                if (defender.HasDefended == true)
                {
                    damage = damage / 2;
                    defender.HasDefended = false;
                }
                int finalDamage = attacker.SpellPower - defender.MagicDefense;
                if (finalDamage <= 0)
                {
                    finalDamage = 0;
                }

                if (defender.Health == 0 || defender.Health <= 0)
                {
                    defender.Health = 0;
                    kill(attacker, defender);
                }
                return finalDamage;
            }
            else
            {
                return 0;
            }
        }
        public void heal(Characters healer, Characters afflicted)
        {
            afflicted.Health += healer.SpellPower;
            if(afflicted.Health >= afflicted.MaxHealth)
            {
                afflicted.Health = afflicted.MaxHealth;
            }
        }
        public void defend(Characters defender)
        {
            defender.HasDefended = true;
        }
        public void flee(Characters chicken)
        {
            Random r = new Random();
            int fleeDifficulty = r.Next(1, 125);
            if(chicken.Speed >= fleeDifficulty)
            {
                //TODO get them out of the combat screen
                //Run flee animation
            }
        }
        public void kill(Characters attacker, Characters defender)
        {
            int expGain = defender.Experience;
            attacker.Experience += expGain;
            //TODO Death animation and get rid of the clickable enemy
            int expCap = attacker.Level * 100;
            if(attacker.Experience >= expCap)
            {
                lvl.pickClass(attacker);
            }
        }

        public string loadDialogue(string dialogue)
        {
            //TODO
            //We will actually have this go to the combat dialogue GUI Element in the future
            return dialogue;
        }
        public void death()
        {

        }
        
    }
}
