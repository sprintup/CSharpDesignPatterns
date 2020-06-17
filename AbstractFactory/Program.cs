using AbstractFactory;
using System;

namespace CSharpDesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nAbstract factory: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.");
            AbstractFactoryRealWorld.Run();
            //AbstractFactoryRealWorld1.Run();
            Console.WriteLine("-----");
            AbstractFactoryStructural.Run();
            Console.ReadKey();
        }
    }
}
