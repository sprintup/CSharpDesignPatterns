using AbstractFactory;
using AbstractFactoryPractice;
using System;

namespace CSharpDesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             */
            Console.WriteLine("Hello World! \nAbstract factory: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.");
            AbstractFactoryStructural.Run();
            Console.WriteLine("-----");
            AbstractFactoryRealWorld.Run();
            Console.WriteLine("-----");
            AbstractFactoryStructuralPractice.Run();
            Console.WriteLine("-----");
            AbstractFactoryRealWorldPractice.Run();
            Console.ReadKey();
        }
    }
}
