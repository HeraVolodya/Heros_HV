using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Warrior
    {
        public string raceWarior; // race hiro
        public string nameWarior;  // name hiro
        public double armorWarior; // armor
        public double healthWarior; //life
        public double impactforceWarior; //power
        public double powercoefficients = 1.0;


        public string warriorSuperPower()
        {
            var sPower = new SuperPowerGenerator();
            return sPower.SuperPower();
        }
    }
}
