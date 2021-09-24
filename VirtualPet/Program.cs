using System;
using System.Threading;
using System.Media;

namespace VirtualPet
{
    class Program
    {
        static Shelter myShelter = new Shelter();
        static SoundPlayer Bark = new SoundPlayer(@"..\..\..\..\Sounds\bark.wav");
        static SoundPlayer Alert = new SoundPlayer(@"..\..\..\..\Sounds\alert.wav");
        static void Main(string[] args)
        {   
            CatPicture.PrintCatPicture();
            Timer _timer = new Timer(Tick, null, 0, 20000);
            // warns player when pet status is very low
            Timer _warningtimer = new Timer(WarnMe, null, 0, 20000);

            Pet myPet1 = new Pet("Spot", "dog");
            Pet myPet2 = new Pet("Muffy", "dog");
            Pet myPet3 = new Pet("Charlie", "cat");

            myShelter.ShelterList.Add(myPet1);
            myShelter.ShelterList.Add(myPet2);
            myShelter.ShelterList.Add(myPet3);

            RoboPet Tobor = new RoboPet("Tobor", "robot");
            //Tobor.GetStatus();
            Tobor.Name = "Tobor";
            myShelter.ShelterList.Add(Tobor);


            bool playing = true;
            
     

            while (playing)
            {
                Console.WriteLine();
                string divider = new string('=', 83);
                Console.WriteLine(divider);
                Title.PrintTitle();
                Console.WriteLine(divider);
                Console.WriteLine();
                Console.WriteLine("Make a Selection");
                Console.WriteLine("1. Add new pet to the shelter.");
                Console.WriteLine("2. Interact with one pet.");
                Console.WriteLine("3. Interact with all pets in the shelter.");
                Console.WriteLine("4. View Status of all pets");
                Console.WriteLine("5. Adopt a pet. (This will erase a pet from the shelter.)");
                
                Console.WriteLine("enter Q to quit");

                string menuinput = Console.ReadLine().ToLower();
                Console.Clear();
                switch (menuinput)

                {
                    
                    case "1":
                        CreatePet();
                        break;

                    case "2":
                        myShelter.InteractWithOnePet(myShelter.ChoosePet());
                        break;

                    case "3":
                        myShelter.InteractWithAllPets();
                        break;
                    case "4":
                        myShelter.GetStatusAll();
                        break;

                    case "5":

                        myShelter.Adopt();
                        break;

                    case "q":
                        playing = false;
                        break;



                }
                
            }
        }
        public static void Tick(object o)
        {
            for (int i = 0; i < myShelter.ShelterList.Count; i++)
            {
                Pet p = myShelter.ShelterList[i];
                p.Tick();
     
            }

        }

        public static void WarnMe(object o)
        {
            for(int i = 0; i < myShelter.ShelterList.Count; i++)
            {
                Pet p = myShelter.ShelterList[i];
                if (p.Hunger > 80 || p.Health < 20 || p.Boredom > 80)
                {
                    if (p.isRobot == true)
                    {
                        Alert.Play();
                        break;
                    }
                        
                    else
                    {
                        Bark.Play();
                        break;
                    }
                        
                }
            }

        }
        public static void CreatePet()
        {
            
            Console.WriteLine("Enter a name for this pet:");
            string petName = Console.ReadLine();
            Console.WriteLine("Enter the pet's species (enter robot to create a robopet):");
            string petSpecies = Console.ReadLine();

            if (petSpecies.ToLower() == "robot")
            {
				Console.WriteLine("Creating a Robot...");
                RoboPet newPet = new RoboPet(petName, petSpecies);
                myShelter.AddToShelter(newPet);
            } else
			{
				Console.WriteLine("Adding your pet...");
                Pet newPet = new Pet(petName, petSpecies);
                myShelter.ShelterList.Add(newPet);
				Console.WriteLine("Congratulations on your new pet!");
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
