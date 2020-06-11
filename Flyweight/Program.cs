using System;
using System.Collections;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nFlyweight: Use sharing to support large numbers of fine-grained objects efficiently.");
            Flyweight_Structural.Run();
            Console.WriteLine("-----");
            Flyweight_RealWorld.Run();
            Console.ReadKey();
        }
    }
}
