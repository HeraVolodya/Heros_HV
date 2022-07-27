using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Вибір гравцем персонажу
            var power = new Battlefield();
            double powerHero1 = 0;
            double powerHero2 = 0;
            double healthHero1 = 0;
            double healthHero2 = 0;



            Console.WriteLine("Hello player ONE choose your persona, for this write | Elf | or | Gnome | or | Goblin | or | Orc |");
            string player1 = Console.ReadLine();
            if (player1 == "Elf")
            {
                var elf = new Elf();
                healthHero1 = elf.healthWarior;
                powerHero1 = elf.impactforceWarior * power.powercoefficients;
                Console.WriteLine($" your hero name si: - {elf.nameWarior} \n race hero: - {elf.raceWarior} \n health: - {elf.healthWarior} \n his armor: - {elf.armorWarior} \n impact force: - {elf.impactforceWarior} \n super power: - {elf.warriorSuperPower()} coficient power - {power.powercoefficients}");
            }
            else if (player1 == "Gnome")
            {
                var gnome = new Gnome();
                healthHero1 = gnome.healthWarior;
                powerHero1 = gnome.impactforceWarior * power.powercoefficients;
                Console.WriteLine($" your hero name si: - {gnome.nameWarior} \n race hero: - {gnome.raceWarior} \n health: - {gnome.healthWarior} \n his armor: - {gnome.armorWarior} \n impact force: - {gnome.impactforceWarior} \n super power: - {gnome.warriorSuperPower()} coficient power - {power.powercoefficients}");
            }
            else if (player1 == "Goblin")
            {
                var goblin = new Goblin();
                healthHero1 = goblin.healthWarior;
                powerHero1 = goblin.impactforceWarior * power.powercoefficients;
                Console.WriteLine($" your hero name si: - {goblin.nameWarior} \n race hero: - {goblin.raceWarior} \n health: - {goblin.healthWarior} \n his armor: - {goblin.armorWarior} \n impact force: - {goblin.impactforceWarior} \n super power: - {goblin.warriorSuperPower()} coficient power - {power.powercoefficients}");
            }
            else if(player1 == "Orc")
            {
                var orc = new Orc();
                healthHero1 = orc.healthWarior;
                powerHero1 = orc.impactforceWarior * power.powercoefficients;
                Console.WriteLine($" your hero name si: - {orc.nameWarior} \n race hero: - {orc.raceWarior} \n health: - {orc.healthWarior} \n his armor: - {orc.armorWarior} \n impact force: - {orc.impactforceWarior} \n super power: - {orc.warriorSuperPower()} coficient power - {power.powercoefficients}");
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
            Console.WriteLine();
            Console.WriteLine("Hello player TWO choose your persona, for this write | Elf | or | Gnome | or | Goblin | or | Orc |");
            string player2 = Console.ReadLine();

            if (player2 == "Elf")
            {
                var elf = new Elf();
                healthHero2 = elf.healthWarior;
                powerHero2 = elf.impactforceWarior * power.powercoefficients;
                Console.WriteLine($" your hero name si: - {elf.nameWarior} \n race hero: - {elf.raceWarior} \n health: - {elf.healthWarior} \n his armor: - {elf.armorWarior} \n impact force: - {elf.impactforceWarior} \n super power: - {elf.warriorSuperPower()} coficient power - {power.powercoefficients}");
            }
            else if (player2 == "Gnome")
            {
                var gnome = new Gnome();
                healthHero2 = gnome.healthWarior;
                powerHero2 = gnome.impactforceWarior * power.powercoefficients;
                Console.WriteLine($" your hero name si: - {gnome.nameWarior} \n race hero: - {gnome.raceWarior} \n health: - {gnome.healthWarior} \n his armor: - {gnome.armorWarior} \n impact force: - {gnome.impactforceWarior} \n super power: - {gnome.warriorSuperPower()} coficient power - {power.powercoefficients}");
            }
            else if (player2 == "Goblin")
            {
                var goblin = new Goblin();
                healthHero2 = goblin.healthWarior;
                powerHero2 = goblin.impactforceWarior * power.powercoefficients;
                Console.WriteLine($" your hero name si: - {goblin.nameWarior} \n race hero: - {goblin.raceWarior} \n health: - {goblin.healthWarior} \n his armor: - {goblin.armorWarior} \n impact force: - {goblin.impactforceWarior} \n super power: - {goblin.warriorSuperPower()} coficient power - {power.powercoefficients}");
            }
            else if (player2 == "Orc")
            {
                var orc = new Goblin();
                healthHero2 = orc.healthWarior;
                powerHero2 = orc.impactforceWarior * power.powercoefficients;
                Console.WriteLine($" your hero name si: - {orc.nameWarior} \n race hero: - {orc.raceWarior} \n health: - {orc.healthWarior} \n his armor: - {orc.armorWarior} \n impact force: - {orc.impactforceWarior} \n super power: - {orc.warriorSuperPower()} coficient power - {power.powercoefficients}");
            }
            else
            {
                Console.WriteLine("incorrect input");
            }

            void Fight()
            {
                int raund = 0;
                do
                {
                    raund++;
                    healthHero1 =  healthHero2 - powerHero1;
                    Console.WriteLine($"damage Hero1 {healthHero1}");
                    healthHero2 =  healthHero1 - powerHero2;
                    Console.WriteLine($"damage Hero2 {healthHero2}");
                    Console.WriteLine($"raund {raund}");
                    

                    if(healthHero1 <= 0)
                    {
                        Console.WriteLine("player ONE WINS !!!!");
                    }
                    else if(healthHero2 <= 0)
                    {
                        Console.WriteLine("player TWO WINS !!!!");
                    }
                } while (healthHero1 < 0 || healthHero2 < 0);

            }
            Console.WriteLine();
            Console.WriteLine("БІЙ !!!!!");
            Console.WriteLine();
            Fight();

        }
    }
}
