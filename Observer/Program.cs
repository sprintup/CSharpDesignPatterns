using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nObserver: Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.\n");
            Observer_Structural.Run();
            Console.WriteLine("-----");
            Observer_Real_World.Run();
            Console.ReadKey();
        }
    }
}
