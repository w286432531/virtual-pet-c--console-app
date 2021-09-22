using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
	public class RoboPet : Pet
	{

		public RoboPet(string name, string species)
		{
			this.Name = name;
			this.Species = species;
			this.isRobot = true;
		}


		public override void GetStatus()
		{
			//base.GetStatus();
			//Console.WriteLine("Charge Level:\t" + this.Hunger);
			//Console.WriteLine("Boredom Level:\t" + this.Boredom);
			//Console.WriteLine("Maintenance Level:\t" + this.Health);
			// to be written as Name: fluffy Charge Level: 100  Boredom Level: 0   Maintenance Level: 100
			// to utilize the health, boredom, and Hunger variables
		}

		public override void SeeDoctor()
		{
			//vet increase health by 40
			this.Health += 40;
			//this.Boredom -= 20; - removed for robopet
			Beep.Play();
		}




	}
}
