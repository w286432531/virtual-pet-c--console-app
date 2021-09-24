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
			this.Health = 30;
			this.Boredom = 60;
			this.Hunger = 50;
		}
	}
}