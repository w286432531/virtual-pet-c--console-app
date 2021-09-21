using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
//need to install nuget package System.Windows.Extensions

namespace VirtualPet
{
	class Shelter
	{
		//tbd
		//public List <Pet> PetList { get; set; }
		public List<Pet> PetList = new List<Pet>();

		SoundPlayer DoorOpen = new SoundPlayer(@"..\..\..\..\Sounds\door_open.wav");
		SoundPlayer DoorClose = new SoundPlayer(@"..\..\..\..\Sounds\door_close.wav");


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
		//use myShelter.Interact(); in program.cs to call this method.
		public void Interact()
        {
            Console.WriteLine("1. Interact with one pet.");
			Console.WriteLine("2. Interact with all pets.");
			int index = Convert.ToInt32(Console.ReadLine());
			if (index == 1)
            {
				InteractWithOnePet(ChoosePet());
            }
			else if (index == 2)
            {
				InteractWithAllPets();
            }
		}
		
		public Pet ChoosePet()
        {
			for (int i = 0; i < PetList.Count; i++)
            {
                Console.WriteLine(i+1 + "." + PetList[i].Name);
            }
			int index = Convert.ToInt32(Console.ReadLine())-1;
			DoorOpen.Play();
			return PetList[index];
		}

		public void InteractWithOnePet(Pet chosenPet)
        {
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. See vet");
			int index = Convert.ToInt32(Console.ReadLine());
            switch (index)
            {
				case 1:
					chosenPet.Play();
                    Console.WriteLine("Playing with the pet.");
					break;
				case 2:
					chosenPet.Feed();
                    Console.WriteLine("Feeding the pet.");
					break;
				case 3:
					chosenPet.SeeDoctor();
                    Console.WriteLine("Taking pet to the doctor.");
					break;
				default:
                    break;
            }
        }

		public void InteractWithAllPets()
        {
			Console.WriteLine("1. Play");
			Console.WriteLine("2. Feed");
			Console.WriteLine("3. See vet");
			int index = Convert.ToInt32(Console.ReadLine());
			switch (index)
			{
				case 1:
                    foreach (var pet in PetList)
                    {
						pet.Play();                       
					}
					Console.WriteLine("Playing with all pets.");
					break;
				case 2:
					foreach (var pet in PetList)
                    {
						pet.Feed();
					}
					Console.WriteLine("Feeding all the pets.");
					break;
				case 3:
					foreach (var pet in PetList)
					{
						pet.SeeDoctor();
					}
					Console.WriteLine("Taking all pets to the doctor.");
					break;
				default:
					break;
			}
		}
	}
}
