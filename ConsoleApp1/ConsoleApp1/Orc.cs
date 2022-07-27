using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Orc : Warrior 
    {
        public Orc() 
        {
            raceWarior = "Orc";
            nameWarior = "Grasimov";
            armorWarior = 10.0 * (0.5 * powercoefficients);
            healthWarior = 100.0;
            impactforceWarior = 30.0 * powercoefficients;
        }
    }
}

