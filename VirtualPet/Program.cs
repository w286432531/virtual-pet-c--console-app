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
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            
            //Testing to see if sounds work. You may delete this
            Pet mypet = new Pet("Fido","Dog");
            mypet.Play();
            Console.WriteLine("Paused. Press enter to continue.");
            Console.ReadLine();
            

            // Kevin and Jay 9/20----------
            // testing the shelter list view pets and interact function
            //Shelter myShelter = new Shelter();
            //Pet myPet1 = new Pet("spot", "dog");
            //Pet myPet2 = new Pet("muffy", "dog");
            //Pet myPet3 = new Pet("charlie", "dog");
            //Console.ReadLine();
            //myShelter.PetList.Add(myPet1);
            //myShelter.PetList.Add(myPet2);
            //myShelter.PetList.Add(myPet3);
            //myShelter.Interact();
            //myShelter.GetStatusAll();
            //-----------------------------
        }
        public static void Tick(object o) 
        {
            //testPet.Tick();
        }

    }
}
