﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPROV
{
    class CChero : Superhero 
    {

        public CChero()
        {
            hp = 200;
            strength = generator.Next(10 - 15);
            intelligence = generator.Next(1 - 5);
            agility = generator.Next(5 - 10);

            Console.WriteLine("Your hero has: " + hp + " hp, " + strength + " strength, " + intelligence + " intelligence and " + agility + " agility.");

        }

    }
}
