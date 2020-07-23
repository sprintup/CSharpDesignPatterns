using AbstractFactory;
using AbstractFactoryPractice;
using System;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();
            AbstractFactoryStructural.Run();
            Console.WriteLine("-----");
            AbstractFactoryRealWorld.Run();
            //Console.WriteLine("-----");
            //AbstractFactoryStructuralPractice.Run();
            //Console.WriteLine("-----");
            //AbstractFactoryRealWorldPractice.Run();
            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("Abstract factory: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.");
        }
    }
}
