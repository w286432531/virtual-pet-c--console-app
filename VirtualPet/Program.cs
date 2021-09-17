using System;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        public static Pet testPet = new Pet();
        static void Main(string[] args)
        {
            
            Timer _timer = new Timer(Tick, null, 0, 15000);
            Console.WriteLine("Hello! Welcome to Virtual Pets");

        }
        public static void Tick(object o) 
        {
            testPet.Tick();
        }

    }
}
