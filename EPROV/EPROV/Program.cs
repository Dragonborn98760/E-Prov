using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPROV
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            string heroClass;

            int heroClassNumber;

            Console.WriteLine("Name you hero: ");

            name = Console.ReadLine();

            Console.WriteLine("Hero " + name + " has been created what class do you want your hero to be? (1.CloseCombat, 2.Range, 3.MentalAtacks)" );

            heroClass = Console.ReadLine();
            while (!int.TryParse(heroClass, out heroClassNumber))
            {

                heroClass = Console.ReadLine();

                Console.WriteLine("Please type a valid number!");
                

            }
            if (heroClassNumber == 1)
            {
                Superhero CloseCombat = new CChero();

                CloseCombat.name = name;
            }
            else if (heroClassNumber == 2)
            {

                Superhero Ranger = new RangeHero();

                Ranger.name = name;
            }
            else if (heroClassNumber == 3)
            {
                Superhero Mental = new MentalAttacksHero();

                Mental.name = name;
            }

        }
    }
}
