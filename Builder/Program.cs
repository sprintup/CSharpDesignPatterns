using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! builder");
            //BuilderRealWorld.Run();
            BuilderStructural.Run();

            //wait for user
            Console.ReadKey();
        }
    }
}
