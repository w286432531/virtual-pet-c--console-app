using System;
using System.Media;
//need to install nuget package System.Windows.Extensions
using System.Collections.Generic;
using System.Text;


namespace VirtualPet
{
    public class Pet
    {
        

        public int health;
        public int boredom;
        public int hunger;

        public string Name;
        public string Species;
        public bool isRobot;

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 100)
                {
                    health = 100;
                }
                else if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }
        public int Boredom
        {
            get
            {
                return boredom;
            }
            set
            {
                if (value > 100)
                {
                    boredom = 100;
                }
                else if (value < 0)
                {
                    boredom = 0;
                }
                else
                {
                    boredom = value;
                }
            }
        }
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                if (value > 100)
                {
                    hunger = 100;
                }
                else if (value < 0)
                {
                    hunger = 0;
                }
                else
                {
                    hunger = value;
                }
            }
        }
        public Pet()
        {
            this.Health = 30;
            this.Hunger = 50;
            this.Boredom = 60;
        }
        public Pet(string name, string species)
		{
			this.Name = name;
			this.Species = species;
            this.isRobot = false;
            this.Health = 30;
            this.Hunger = 50;
            this.Boredom = 60;
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

      // adding ability to play with pet. use petname.play() in program.cs to call function
      public void Play()
        {

            this.Hunger += 10;
 
            this.Boredom -= 20;
     
            this.Health += 10;
        }
        // adding ability to feed the pet. use petname.play() in program.cs to call funcion
        public void Feed()
        {
 
            this.Hunger -= 40;
            this.Boredom += 10;
        }
        //take pet to doctor. use petname.SeeDoctor() in program.cs to call function
        public void SeeDoctor()
        {

            this.Health += 30;
            this.Boredom -= 20;
        }
    }
}
