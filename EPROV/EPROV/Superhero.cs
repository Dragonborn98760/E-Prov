using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPROV
{
    class Superhero
    {
        protected static Random generator = new Random();

        public string name;

        protected int hp = 0;

        protected int strength = 0;

        protected int intelligence = 0;

        protected int agility = 0;

        public int Attack()
        {
            int result = generator.Next(0, 10) + strength;

            if (result > 25)
            {
                return 25;
            }
            else
            {
                return result;
            }
        }

        public int UseAbility()
        {
            int result = generator.Next(0, 10) + intelligence;

            if (result > 25)
            {
                return 25;
            }
            else
            {
                return result;
            }
        }

        public int Shooting()
        {
            int result = generator.Next(0, 10) + agility;

            if (result > 25)
            {
                return 25;
            }
            else
            {
                return result;
            }
        }

    }
}
