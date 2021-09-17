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

        public string Name;
        public string Species;
      
        public void SetName()
		{
			Console.WriteLine("Enter your pet's name:");
            this.Name = Console.ReadLine();
		}

        public void SetSpecies()
        {
            Console.WriteLine("Enter your pet's species:");
            this.Species = Console.ReadLine();
        }
    }
}
