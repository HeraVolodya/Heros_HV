using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Elf : Warrior 
    {

        public Elf() 
        {
            raceWarior = "Elf";
            nameWarior = "Greenleaf";
            armorWarior = 70.0 * (0.5 * powercoefficients);
            healthWarior = 100.0;
            impactforceWarior = 80.0 * powercoefficients;
        }
    }
}

