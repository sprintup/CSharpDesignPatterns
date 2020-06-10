using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nFacade: Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.\n");

            Facade_Structural.Run();
            Facade_RealWorld.Run();

            Console.ReadKey();
        }
    }




}
