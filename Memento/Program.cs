using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nMemento: Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.\n");
            Memento_Structural.Run();
            Console.WriteLine("-----");
            Memento_Real_World.Run();
            Console.ReadKey();
        }
    }
    //  The 'Originator' class
}
