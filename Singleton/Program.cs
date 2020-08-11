using System;
using System.Collections.Generic;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();

            Singleton_Structural.Run();
            Singleton_Structural_Practice.Run();
            Console.WriteLine("-----");
            Singleton_RealWorld.Run();

            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("\nSingleton: Ensure a class has only one instance and provide a global point of access to it.");
        }
    }
}
