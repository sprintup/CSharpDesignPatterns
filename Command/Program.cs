using System;
using System.Collections.Generic;

namespace Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            Command_Structural.Run();
            Command_Structural_Practice.Run();
            Console.WriteLine("-----");
            Command_Real_World.Run();
            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("\n Command: Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.");
        }
    }
}
