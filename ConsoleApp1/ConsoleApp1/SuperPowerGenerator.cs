using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SuperPowerGenerator
    {
        public string SuperPower()
        {
            Random random = new Random();
            var power = random.Next(1, 6);
            if (power == 1)
            {
                return "Fire";
            }
            else if (power == 2)
            {
                return "Earth";
            }
            else if (power == 3)
            {
                return "Water";
            }
            else if (power == 4)
            {
                return "Wind";
            }
            else
            {
                return "Ukrainian";
            }
        }
    }
}
