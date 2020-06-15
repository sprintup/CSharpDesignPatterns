using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nState: Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.");
            State_Structural.Run();
            Console.WriteLine("-----");
            State_Real_World.Run();
            Console.ReadKey();
        }
    }
}
