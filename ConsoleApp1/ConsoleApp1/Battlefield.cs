using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Battlefield : Warrior
    {
        public string player1;
        public string player2;

        public Battlefield()
        {
            switch (warriorSuperPower())
            {
                case "Ukrainian":
                    powercoefficients = 1;
                break;
                case "Fire":
                    powercoefficients = 0.5;
                break;
                case "Earth":
                    powercoefficients = 0.4;
                break;
                case "Water":
                    powercoefficients = 0.3;
                break;
                case "Wind":
                    powercoefficients = 0.1;
                break;
            }

        }
    }
}
