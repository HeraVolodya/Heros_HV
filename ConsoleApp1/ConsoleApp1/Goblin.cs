using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Goblin : Warrior 
    {

        public Goblin() 
        {
            raceWarior = "Goblin";
            nameWarior = "Goy";
            armorWarior = 60.0 * (0.5 * powercoefficients);
            healthWarior = 100.0;
            impactforceWarior = 50.0 * powercoefficients;

        }
    }
}

