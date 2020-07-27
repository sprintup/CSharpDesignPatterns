using System;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();
            Facade_Structural.Run();
            Console.WriteLine("-----");
            Facade_Structural_Practice.Run();
            
            Console.WriteLine("-----");
            Facade_RealWorld.Run();
            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("Facade: Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.");
        }
    }
}
