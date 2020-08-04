using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Description();
            Strategy_Structural.Run();
            Console.WriteLine("-----");
            Strategy_Real_World.Run();
            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("\nStrategy: Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.\n");
        }
    }
}
