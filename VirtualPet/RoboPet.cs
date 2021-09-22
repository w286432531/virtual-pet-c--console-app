using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
	public class RoboPet : Pet
	{
		public bool isRobot = true;

		public override void GetStatus()
		{
			//base.GetStatus();
			Console.WriteLine("Charge Level:\t" + this.Hunger);
			Console.WriteLine("Boredom Level:\t" + this.Boredom);
			Console.WriteLine("Maintenance Level:\t" + this.Health);
		}

		
	}
}
