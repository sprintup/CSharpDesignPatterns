using System;
using System.Collections.Generic;
using Factory_Method_Practice;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nFactory Method: Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.");
            Factory_Method_Structural.Run();
            FactoryMethod_StructuralPractice.Run();
            Console.WriteLine("-----");
            Factory_Method_RealWorld.Run();
            Console.ReadKey();
        }
    }
}
