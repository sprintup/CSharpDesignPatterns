using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! prototype");
            Prototype_Structural.Run();
            Prototype_RealWorld.Run();

            Console.ReadKey();
        }
    }
}
