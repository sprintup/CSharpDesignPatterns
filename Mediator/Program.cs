using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nMediator: Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.");
            Console.WriteLine("\n-----\n");
            Mediator_Structural.Run();
            Console.WriteLine("\n-----\n");
            Mediator_Real_World.Run();
            Console.ReadKey();
        }
    }
}
