using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nTemplate Method: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.\n");
            Template_Method_Structural.Run();
            Console.WriteLine("-----");
            Template_Method_Real_World.Run();
            Console.ReadKey();
        }
    }
}
