using System;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        public static Pet testPet = new Pet("test", "test");
        static void Main(string[] args)
        {
            CatPicture.PrintCatPicture();
            Timer _timer = new Timer(Tick, null, 0, 15000);
            // Kevin and Jay 9/20----------
            // testing the shelter list view pets and interact function
            Shelter myShelter = new Shelter();
            Pet myPet1 = new Pet("spot", "dog");
            Pet myPet2 = new Pet("muffy", "dog");
            Pet myPet3 = new Pet("charlie", "dog");
            Console.ReadLine();
            myShelter.PetList.Add(myPet1);
            myShelter.PetList.Add(myPet2);
            myShelter.PetList.Add(myPet3);
            myShelter.Interact();
            myShelter.GetStatusAll();


            bool playing = true;


            while (playing)
            {
                Console.WriteLine("Hello! Welcome to Virtual Pets");


                Console.WriteLine("Make a Selection");
                Console.WriteLine("1. Check Status of your pet");
                Console.WriteLine("2. Feed your pet");
                Console.WriteLine("3. Play with your pet");
                Console.WriteLine("4. Take your pet to the doctor");
                Console.WriteLine("5. View pets in the shelter");
                Console.WriteLine("6. Make your own pet");
                Console.WriteLine("7. View Status of all pets");
                Console.WriteLine("8. Name Your Pet");
                Console.WriteLine("9. Change your Pet's species");
                Console.WriteLine("enter Q to quit");



                string menuinput = Console.ReadLine().ToLower();

                switch (menuinput)

                {
                    case "1":

                        // insert check status of pet here (If there is no pet, print "go to the shelter and get a pet")

                        break;

                    case "2":

                        // insert feed pet here

                        break;

                    case "3":

                        // insert play with pet here

                        break;

                    case "4":

                        // insert take pet to the doctor here

                        break;

                    case "5":

                        // insert go to the shelter here

                        break;

                    case "6":

                        // insert making your own pet here

                        break;

                    case "7":
                        // insert checking status of ALL pets

                        break;

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

    }
}
