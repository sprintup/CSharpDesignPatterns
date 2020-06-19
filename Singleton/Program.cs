using System;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nSingleton: Ensure a class has only one instance and provide a global point of access to it.");

            Singleton_Structural.Run();
            Console.WriteLine("-----");
            Singleton_RealWorld.Run();

            Console.ReadKey();
        }
    }
}
