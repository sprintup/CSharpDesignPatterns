using System;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();
            Adapter_Structural.Run();
            Adapter_Structural_Practice.Run();
            Console.WriteLine("-----");
            Adapter_RealWorld.Run();

            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("\nAdapter: Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.");
        }
    }
}
