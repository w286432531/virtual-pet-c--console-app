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
        public void Tick()
        {
            this.Health -= 5;
            this.Boredom += 5;
            this.Hunger += 5;
        }
    }
}
