using AbstractFactory;
using System;

namespace CSharpDesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World! \nAbstract factory: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.");
            AbstractFactoryStructural.Run();
            Console.WriteLine("-----");
            AbstractFactoryRealWorld.Run();
             */
            AbstractFactoryPractice.Run();
            Console.ReadKey();
        }
    }
}
