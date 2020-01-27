using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPROV
{
    class RangeHero :Superhero
    {
        public RangeHero()
        {
            hp = 150;
            strength = generator.Next(5 - 10);
            intelligence = generator.Next(1 - 5);
            agility = generator.Next(10 - 15);

            Console.WriteLine("Your hero has: " + hp + " hp, " + strength + " strength, " + intelligence + " intelligence and " + agility + " agility.");
        }
    }
}
