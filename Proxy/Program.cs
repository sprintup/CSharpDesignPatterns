using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nProxy: Provide a surrogate or placeholder for another object to control access to it.");
            Proxy_Structural.Run();
            Console.WriteLine("-----");
            Proxy_RealWorld.Run();
            Console.ReadKey();
        }
    }
}
