using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nStrategy: Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.\n");
            Strategy_Structural.Run();
            Console.WriteLine("-----");
            Strategy_Real_World.Run();
            Console.ReadKey();
        }
    }
}
