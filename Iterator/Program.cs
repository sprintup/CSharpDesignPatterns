using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nIterator: Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.");
            Iterator_Structural.Run();
            Console.WriteLine("-----");
            Iterator_Real_World.Run();
            Console.ReadKey();
        }
    }
}
