using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nBuilder: Separate the construction of a complex object from its representation so that the same construction process can create different representations.");

            BuilderStructural.Run();
            Console.WriteLine("-----");
            BuilderRealWorld.Run();

            //wait for user
            Console.ReadKey();
        }
    }
}
