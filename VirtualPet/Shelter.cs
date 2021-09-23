using System;
using System.Threading;
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
		public List<Pet> ShelterList = new List<Pet>();

		private SoundPlayer DoorOpen = new SoundPlayer(@"..\..\..\..\Sounds\door_open.wav");
		private SoundPlayer DoorClose = new SoundPlayer(@"..\..\..\..\Sounds\door_close.wav");
		private object shelterList;

		public Shelter()
		{
			
		}

		public void GetStatusAll()
		{
			string divider = new string('-', 81);
			Console.Clear();
			Console.WriteLine(divider);
			foreach (var pet in ShelterList)
			{
				if (pet.isRobot == false)
				{
					Console.WriteLine(pet.Name + "\t\t Hunger: "+ pet.Hunger + "\t\t Boredom: " + pet.Boredom + "\t\t Health: " + pet.Health);
				}
				else 
				{
					Console.WriteLine(pet.Name + "\t\t Battery: " + (100-pet.Hunger)+"%" + "\t\t Boredom: " + pet.Boredom + "\t\t Maintenance: " + pet.Health);
				}
			}
			Console.WriteLine(divider);
		}
		
		public Pet ChoosePet()
        {
			for (int i = 0; i < ShelterList.Count; i++)
            {
                Console.WriteLine(i+1 + "." + ShelterList[i].Name);
            }
			int index = Convert.ToInt32(Console.ReadLine())-1;
			Console.Clear();
			//Need to find compatible sound.
			//DoorOpen.Play();

			return ShelterList[index];
		}

		public void InteractWithOnePet(Pet chosenPet)
        {
			if (chosenPet.isRobot == false) 
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

				Thread.Sleep(1000);
				Console.Clear();
			}
			else
			{
				Console.WriteLine("1. Charge the pet");
				Console.WriteLine("2. Take pet for maintenance");
				Console.WriteLine("3. Play with the pet");				
				int index = Convert.ToInt32(Console.ReadLine());
				switch (index)
                {
					case 1:
						chosenPet.Feed();
						Console.WriteLine("Charge the pet.");
						break;
					case 2:
						chosenPet.SeeDoctor();
						Console.WriteLine("Take pet for maintenance.");
						break;
					case 3:
						chosenPet.Play();
						Console.WriteLine("Playing with robotic pet.");
						break;
					default:
						break;
				}
				Thread.Sleep(1000);
				Console.Clear();
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
					foreach (var pet in ShelterList)
					{
						pet.Play();
					}
					Console.WriteLine("Playing with all pets.");
					break;
				case 2:
					foreach (var pet in ShelterList)
					{
						pet.Feed();
					}
					Console.WriteLine("Feeding all the pets.");
					break;
				case 3:
					foreach (var pet in ShelterList)
					{
						pet.SeeDoctor();
					}
					Console.WriteLine("Taking all pets to the doctor.");
					break;
				default:
					break;
			}
			Thread.Sleep(1000);
			Console.Clear();
		}
		
		public void Adopt()
		{
			Console.WriteLine("Which pet would you like to adopt?");
			Pet toRemove = ChoosePet();
			ShelterList.Remove(toRemove);
		}

		public void AddToShelter(Pet newPet)
		{
			ShelterList.Add(newPet);
		}

	

	}
}
