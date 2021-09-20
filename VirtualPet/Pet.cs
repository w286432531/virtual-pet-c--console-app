using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public int Health = 100;
        public int Boredom = 0;
        public int Hunger = 0;
        public string Name;
        public string Species;

		public Pet(string name, string species)
		{
			this.Name = name;
			this.Species = species;
		}


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

        public void Tick()
        {
            this.Health -= 5;
            this.Boredom += 5;
            this.Hunger += 5;
   
        }
      
        public void SetName()
		{
			Console.WriteLine("Enter your pet's name:");
            this.Name = Console.ReadLine();
		}

        public string GetName()
        {
            return this.Name;
        }

        public void SetSpecies()
        {
            Console.WriteLine("Enter your pet's species:");
            this.Species = Console.ReadLine();

        }

        public string GetSpecies()
		{
            return this.Species;
		}

        public void GetStatus()
		{
			Console.WriteLine("Hunger: " + this.Hunger);
			Console.WriteLine("Boredom: " + this.Boredom);
			Console.WriteLine("Health: " + this.Health);
		}


      // adding ability to play with pet. use petname.play() in program.cs to call function
      public void Play()
        {
            //play increase hunger by 10
            this.Hunger += 10;
            //play decrease boredom by 20
            this.Boredom -= 20;
            //play increase health by 10
            this.Health += 10;
        }
        // adding ability to feed the pet. use petname.play() in program.cs to call funcion
        public void Feed()
        {
            //feed decrease hunger by 40
            this.Hunger -= 40;
        }
        //take pet to doctor. use petname.SeeDoctor() in program.cs to call function
        public void SeeDoctor()
        {
            //vet increase health by 40
            this.Health += 40;
        }
    }
}
