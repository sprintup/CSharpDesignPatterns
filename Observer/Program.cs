using System;
using System.Collections.Generic;

namespace Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();
            Observer_Structural.Run();
            Observer_Structural_Practice.Run();
            Console.WriteLine("-----");
            Observer_Real_World.Run();
            Observer_Real_World_Practice.Run();
            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("Observer: Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.\n");
        }
    }
}
