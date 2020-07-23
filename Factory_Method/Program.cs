using System;
using System.Collections.Generic;
using Factory_Method_Practice;

namespace Factory_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();
            Factory_Method_Structural.Run();
            FactoryMethod_StructuralPractice.Run();
            Console.WriteLine("-----");
            Factory_Method_RealWorld.Run();
            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("Factory Method: Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.");
        }
    }
}
