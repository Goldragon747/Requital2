using Requital.Character_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Encounters
    {
        Random r = new Random();
        public void pickEncounter()
        {
            
            int ranEncounter = r.Next(100);
            if (ranEncounter >= 0 && ranEncounter < 11)
            {
                caveEncounter1();
            }
            else if (ranEncounter >= 11 && ranEncounter < 21)
            {
                caveEncounter2();
            }
            else if (ranEncounter >= 21 && ranEncounter < 31)
            {
                forestEncounter1();
            }
            else if (ranEncounter >= 31 && ranEncounter < 41)
            {
                forestEncounter2();
            }
            else if (ranEncounter >= 41 && ranEncounter < 51)
            {
                forestEncounter3();
            }
            else if (ranEncounter >= 51 && ranEncounter < 61)
            {
                caveEncounter3();
            }
            else if (ranEncounter >= 61 && ranEncounter < 71)
            {
                wimpyEncounter();
            }
            else if (ranEncounter >= 71 && ranEncounter < 81)
            {
                powerOverwhelming();
            }
            else if (ranEncounter >= 81 && ranEncounter < 91)
            {
                Mirror();
            }
            else
            {
                encounter10();
            }
        }

        private List<Characters> caveEncounter1()
        {
            List<Characters> caveEncounter1 = new List<Characters>();
            Goblin g1 = new Goblin();
            GoblinRogue gR = new GoblinRogue();
            Goblin g2 = new Goblin();
            caveEncounter1.Add(g1);
            caveEncounter1.Add(g2);
            caveEncounter1.Add(gR);
            return caveEncounter1;
        }

        private List<Characters> caveEncounter2()
        {
            List<Characters> caveEncounter2 = new List<Characters>();
            Skeleton s1 = new Skeleton();
            Skeleton s2 = new Skeleton();
            Skeleton s3 = new Skeleton();
            caveEncounter2.Add(s1);
            caveEncounter2.Add(s2);
            caveEncounter2.Add(s3);
            return caveEncounter2;
        }

        private List<Characters> forestEncounter1()
        {
            List<Characters> forestEncounter1 = new List<Characters>();
            ElfWarrior eW1 = new ElfWarrior();
            ElfWarrior eW2 = new ElfWarrior();
            ElfWarrior eW3 = new ElfWarrior();
            forestEncounter1.Add(eW1);
            forestEncounter1.Add(eW2);
            forestEncounter1.Add(eW3);
            return forestEncounter1;
        }

        private List<Characters> forestEncounter2()
        {
            List<Characters> forestEncounter2 = new List<Characters>();
            ElfCleric eC = new ElfCleric();
            ElfRogue eR = new ElfRogue();
            ElfWarrior eW = new ElfWarrior();
            ElfMage eM = new ElfMage();
            forestEncounter2.Add(eC);
            forestEncounter2.Add(eR);
            forestEncounter2.Add(eW);
            forestEncounter2.Add(eM);
            return forestEncounter2;

        }

        private List<Characters> forestEncounter3()
        {
            List<Characters> forestEncounter3 = new List<Characters>();
            ElfCleric eC = new ElfCleric();
            ElfCleric eC2 = new ElfCleric();
            ElfCleric eC3 = new ElfCleric();
            ElfRogue eR = new ElfRogue();
            ElfRogue eR2 = new ElfRogue();
            ElfWarrior eW = new ElfWarrior();
            ElfWarrior eW2 = new ElfWarrior();
            ElfMage eM = new ElfMage();
            ElfMage eM2 = new ElfMage();
            forestEncounter3.Add(eC);
            forestEncounter3.Add(eR);
            forestEncounter3.Add(eW);
            forestEncounter3.Add(eM);
            forestEncounter3.Add(eM2);
            forestEncounter3.Add(eW2);
            forestEncounter3.Add(eR2);
            forestEncounter3.Add(eC2);
            forestEncounter3.Add(eC3);
            return forestEncounter3;
        }

        private List<Characters> caveEncounter3()
        {
            List<Characters> caveEncounter3 = new List<Characters>();
            Knight k = new Knight();
            Knight k2 = new Knight();
            caveEncounter3.Add(k);
            caveEncounter3.Add(k2);
            return caveEncounter3;
        }

        private List<Characters> wimpyEncounter()
        {
            List<Characters> wimpyEncounter = new List<Characters>();
            Goblin g = new Goblin();
            wimpyEncounter.Add(g);
            return wimpyEncounter;
        }

        private List<Characters> powerOverwhelming()
        {
            List<Characters> powerOverwhelming = new List<Characters>();
            Knight k = new Knight();
            Knight k2 = new Knight();
            Knight k3 = new Knight();
            Knight k4 = new Knight();
            Knight k5 = new Knight();
            Knight k6 = new Knight();
            Knight k7 = new Knight();
            Knight k8 = new Knight();
            Knight k9 = new Knight();
            powerOverwhelming.Add(k);
            powerOverwhelming.Add(k2);
            powerOverwhelming.Add(k3);
            powerOverwhelming.Add(k4);
            powerOverwhelming.Add(k5);
            powerOverwhelming.Add(k6);
            powerOverwhelming.Add(k7);
            powerOverwhelming.Add(k8);
            powerOverwhelming.Add(k9);
            return powerOverwhelming;
        }

        private List<Characters> Mirror()
        {
            List<Characters> mirror = new List<Characters>();
            Rogue r = new Rogue();
            Warrior w = new Warrior();
            Cleric c = new Cleric();
            Mage m = new Mage();
            mirror.Add(r);
            mirror.Add(w);
            mirror.Add(c);
            mirror.Add(m);
            return mirror;
        }

        private void encounter10()
        {
            throw new NotImplementedException();
        }
        public List<Characters> initialTianEncounter()
        {
            Tian tian = new Tian();
            List<Characters> initialTianEncounter = new List<Characters>();
            initialTianEncounter.Add(tian);
            return initialTianEncounter;
        }
        public List<Characters> endTianEncounter()
        {
            Tian tian = new Tian();
            Goblin g = new Goblin();
            GoblinRogue gr = new GoblinRogue();
            ElfCleric ec = new ElfCleric();
            ElfMage em = new ElfMage();
            ElfRogue er = new ElfRogue();
            ElfWarrior ew = new ElfWarrior();
            Knight k = new Knight();
            Skeleton s = new Skeleton();
            List<Characters> endTianEncounter = new List<Characters>();
            endTianEncounter.Add(tian);
            endTianEncounter.Add(g);
            endTianEncounter.Add(gr);
            endTianEncounter.Add(ec);
            endTianEncounter.Add(em);
            endTianEncounter.Add(er);
            endTianEncounter.Add(ew);
            endTianEncounter.Add(k);
            endTianEncounter.Add(s);
            return endTianEncounter;
        }
    }
}
