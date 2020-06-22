using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nComposite: Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.");

            Composite_Structural.Run();
            Console.WriteLine("-----");
            Composite_RealWorld.Run();

            Console.ReadKey();
        }
    }
}
