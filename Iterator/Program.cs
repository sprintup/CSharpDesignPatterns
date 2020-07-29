using System;
using System.Collections;

namespace Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();
            Iterator_Structural.Run();
            Iterator_Structural_Practice.Run();
            Console.WriteLine("-----");
            Iterator_Real_World.Run();
            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("Hello World! \nIterator: Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.");
        }
    }
}
