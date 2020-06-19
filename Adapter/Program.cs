using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nAdapter: Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.");

            Adapter_Structural.Run();
            Console.WriteLine("-----");
            Adapter_RealWorld.Run();

            Console.ReadKey();
        }
    }
}
