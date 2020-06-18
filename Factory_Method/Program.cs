using System;
using System.Collections.Generic;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nFactory Method: Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.");
            Factory_Method_Structural.Run();
            Factory_Method_RealWorld.Run();
            Console.ReadKey();
        }
    }
}
