using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gnome : Warrior 
    {
        public Gnome() 
        {
            raceWarior = "Gnome";
            nameWarior = "Gimly";
            armorWarior = 85.0 * (0.5 * powercoefficients); 
            healthWarior = 100.0;
            impactforceWarior = 75.0 * powercoefficients;
        }
    }
}
