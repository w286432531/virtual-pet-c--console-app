using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet testPet = new Pet();
            testPet.Health = 30;
            testPet.Boredom = 50;
            testPet.Hunger = 50;

            testPet.GetHealth();
            testPet.GetBoredom();
            testPet.GetHunger();
            

            
        }
    }
}
