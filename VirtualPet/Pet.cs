using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public int Health;
        public int Boredom;
        public int Hunger;

        public void GetHealth()
        {
            Console.WriteLine(this.Health);
        }

        public void GetBoredom()
        {
            Console.WriteLine(this.Boredom);
        }

        public void GetHunger()
        {
            Console.WriteLine(this.Hunger);
        }

    }
}
