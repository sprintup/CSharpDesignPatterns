using System;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nCommand: Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.");
            Command_Structural.Run();
            Console.WriteLine("-----");
            Command_Real_World.Run();
            Console.ReadKey();
        }
    }
}
