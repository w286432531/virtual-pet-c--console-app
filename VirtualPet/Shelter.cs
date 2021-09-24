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
	public class Shelter
	{
		public List<Pet> ShelterList = new List<Pet>();
		protected SoundPlayer CanOpen = new SoundPlayer(@"..\..\..\..\Sounds\can_open.wav");
		protected SoundPlayer Squeak = new SoundPlayer(@"..\..\..\..\Sounds\squeak.wav");
		protected SoundPlayer Beep = new SoundPlayer(@"..\..\..\..\Sounds\beep.wav");
		protected SoundPlayer Charge = new SoundPlayer(@"..\..\..\..\Sounds\charge.wav");
		protected SoundPlayer Weld = new SoundPlayer(@"..\..\..\..\Sounds\weld.wav");

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
					Console.WriteLine(pet.Name + " ("+pet.Species+")"+"\t\t Hunger: "+ pet.Hunger + "\t\t Boredom: " + pet.Boredom + "\t\t Health: " + pet.Health);
				}
				else 
				{
					Console.WriteLine(pet.Name + " (" + pet.Species + ")" + "\t\t Battery: " + (100-pet.Hunger)+"%" + "\t\t Boredom: " + pet.Boredom + "\t\t Maintenance: " + pet.Health);
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
						Pics.BallPic();
						Console.WriteLine("Playing with the pet.");
						Squeak.Play();
						break;
					case 2:
						chosenPet.Feed();
						Pics.BowlPic();
						Console.WriteLine("Feeding the pet.");
						CanOpen.Play();
						break;
					case 3:
						chosenPet.SeeDoctor();
						Pics.DoctorPic();
						Console.WriteLine("Taking pet to the doctor.");
						Beep.Play();
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
						Pics.PowerPic();
						Console.WriteLine("Charging the pet.");
						Charge.Play();
						break;
					case 2:
						chosenPet.SeeDoctor();
						Pics.WrenchPic();
						Console.WriteLine("Taking pet in for maintenance.");
						Weld.Play();
						break;
					case 3:
						chosenPet.Play();
						Pics.BallPic();
						Console.WriteLine("Playing with robotic pet.");
						Squeak.Play();
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
					Pics.BallPic();
					Console.WriteLine("Playing with all pets.");
					Squeak.Play();
					break;
				case 2:
					foreach (var pet in ShelterList)
					{
						pet.Feed();
					}
					Pics.BowlPic();
					Console.WriteLine("Feeding/Charging all the pets.");
					CanOpen.Play();
					break;
				case 3:
					foreach (var pet in ShelterList)
					{
						pet.SeeDoctor();
					}
					Pics.DoctorPic();
					Console.WriteLine("Taking all pets to the doctor/mechanic.");
					Beep.Play();
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
			RemoveFromShelter(toRemove);
			Pics.AdoptPic();
			Console.Clear();
		}

		public void AddToShelter(Pet newPet)
		{
			ShelterList.Add(newPet);
		}
		public void RemoveFromShelter(Pet ChosenPet)
		{
			ShelterList.Remove(ChosenPet);
		}
	}
}
