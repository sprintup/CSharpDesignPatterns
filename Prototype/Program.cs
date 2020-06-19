using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nPrototype: Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.");
            Prototype_Structural.Run();
            Console.WriteLine("-----");
            Prototype_RealWorld.Run();

            Console.ReadKey();
        }
    }
}
