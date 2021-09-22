using System;
using System.Media;
//need to install nuget package System.Windows.Extensions
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

        private SoundPlayer CanOpen = new SoundPlayer(@"..\..\..\..\Sounds\can_open.wav");
        private SoundPlayer Squeak = new SoundPlayer(@"..\..\..\..\Sounds\squeak.wav");
        private SoundPlayer Beep = new SoundPlayer(@"..\..\..\..\Sounds\beep.wav");

        public Pet()
        {
        }
        public Pet(string name, string species)
		{
			this.Name = name;
			this.Species = species;
           
		}


		public int GetHealth()
        {
            return this.Health;
        }

        public int GetBoredom()
        {
            return this.Boredom;
        }

        public int GetHunger()
        {
            return this.Hunger;
        }

        public void Tick()
        {
            this.Health -= 5;
            this.Boredom += 5;
            this.Hunger += 5;
   
        }
      
        public void SetName(String name)
		{
            this.Name = name;
		}

        public string GetName()
        {
            return this.Name;
        }

        public void SetSpecies(String species)
        {
            this.Species = species;

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
            Squeak.Play();
        }
        // adding ability to feed the pet. use petname.play() in program.cs to call funcion
        public void Feed()
        {
            //feed decrease hunger by 40
            this.Hunger -= 40;
            this.Boredom += 10;
            CanOpen.Play();
        }
        //take pet to doctor. use petname.SeeDoctor() in program.cs to call function
        public void SeeDoctor()
        {
            //vet increase health by 40
            this.Health += 40;
            this.Boredom -= 20;
            Beep.Play();
        }
    }
}
