using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nVisitor: Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.");

            Visitor_Structural.Run();
            Console.WriteLine("------");
            Visitor_Real_World.Run();

            Console.ReadKey();
        }
    }
}
