using System;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        static Shelter myShelter = new Shelter();
        static void Main(string[] args)
        {
            CatPicture.PrintCatPicture();
            Timer _timer = new Timer(Tick, null, 0, 15000);
            // Kevin and Jay 9/20----------
            // testing the shelter list view pets and interact function
            
            Pet myPet1 = new Pet("spot", "dog");
            Pet myPet2 = new Pet("muffy", "dog");
            //Pet myPet3 = new Pet("charlie", "dog");
            //Console.ReadLine();
            myShelter.ShelterList.Add(myPet1);
            myShelter.ShelterList.Add(myPet2);
            //myShelter.PetList.Add(myPet3);
            //myShelter.Interact();
            //myShelter.GetStatusAll();
            //-----------------------------

            bool playing = true;


            while (playing)
            {
                Console.WriteLine("Hello! Welcome to Virtual Pets");


                Console.WriteLine("Make a Selection");
                Console.WriteLine("1. Add new pet to the shelter.");
                Console.WriteLine("2. Interact with a pet or all pets.");
                Console.WriteLine("3. View Status of all pets");
                Console.WriteLine("4. Adopt a pet.");
                
                Console.WriteLine("enter Q to quit");



                string menuinput = Console.ReadLine().ToLower();

                switch (menuinput)

                {
                    case "1":
                        // insert making your own pet here
                        CreatePet();
                        break;

                    case "2":

                        // insert feed pet here
                        myShelter.Interact();
                        break;

                    case "3":
                        // insert checking status of ALL pets
                        myShelter.GetStatusAll();
                        break;

                        break;

                    case "4":

                        // Remove the pet in the shelter
                        myShelter.RemovefromShelter();
                        break;

                    case "5":

                        // insert go to the shelter here

                        break;

                    case "6":



                    case "7":


                    case "q":
                        playing = false;
                        break;



                }

            }
        }
        public static void Tick(object o) 
        {
            //testPet.Tick();
        }
        public static void CreatePet()
        {
            Console.WriteLine("Enter a name for this pet:");
            string petName = Console.ReadLine();
            Console.WriteLine("Enter the pet's species:");
            string petSpecies = Console.ReadLine();

            Pet newPet = new Pet(petName, petSpecies);
            myShelter.addtoShelter(newPet);
        }
    }
}
