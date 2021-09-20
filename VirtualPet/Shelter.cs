using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
	class Shelter
	{
		//tbd
		//public List <Pet> PetList { get; set; }
		public List<Pet> PetList = new List<Pet>();


		public Shelter()
		{
			
		}

		public void GetStatusAll()
		{
			string divider = new string('-', 60);
			Console.Clear();
			Console.WriteLine("Name\t\tHunger\t\tBoredom\t\tHealth");
			Console.WriteLine(divider);
			foreach (var pet in PetList)
			{
				Console.WriteLine(pet.Name + "\t\t" + pet.Hunger + "\t\t" + pet.Boredom + "\t\t" + pet.Health);
			}
		}
	}
}
