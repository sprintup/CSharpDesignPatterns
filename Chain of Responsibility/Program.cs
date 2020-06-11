using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nChain of Responsibility: Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.");
            Chain_of_Responsibility_Structural.Run();
            Console.WriteLine("-----");
            Chain_of_Responsibility_Real_World.Run();
            Console.ReadKey();
        }
    }
}
