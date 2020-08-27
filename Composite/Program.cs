using System;
using System.Collections.Generic;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();

            Composite_Structural.Run();
            Composite_Structural_Practice.Run();
            Console.WriteLine("-----");
            Composite_RealWorld.Run();
            Composite_RealWorld_Practice.Run();

            Console.ReadKey();
        }
        public static void Description()
        {
            Console.WriteLine("\nComposite: Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.");
        }
    }
}
