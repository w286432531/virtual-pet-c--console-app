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
      // adding ability to play with pet. use petname.play() in program.cs to call function
      public void play()
        {
            //play increase hunger by 10
            this.Hunger += 10;
            //play decrease boredom by 20
            this.Boredom -= 20;
            //play increase health by 10
            this.Health += 10;
        }
        // adding ability to feed the pet. use petname.play() in program.cs to call funcion
        public void feed()
        {
            //feed decrease hunger by 40
            this.Hunger -= 40;
        }

         //take pet to vet. use petname.vet() in program.cs to call function
        public void vet()
        {
            //vet increase health by 30
            this.Health += 40;
        }
    }
}
