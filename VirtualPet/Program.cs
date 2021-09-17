using System;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet testPet = new Pet();
            Timer _timer = new Timer(testPet.Tick, null, 0, 15000);
            Console.WriteLine("Hello! Welcome to Virtual Pets");
        }
    }
}
