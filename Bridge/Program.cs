using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nBridge: Decouple an abstraction from its implementation so that the two can vary independently.");
            Bridge_Structural.Run();
            Console.WriteLine("-----");
            Bridge_RealWorld.Run();
            Console.ReadKey();
        }
    }



}
