using System;
using System.Collections.Generic;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nDecorator: Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.");
            Decorator_Structural.Run();
            Console.WriteLine("-----");
            Decorator_RealWorld.Run();
            Console.ReadLine();
        }
    }
}
