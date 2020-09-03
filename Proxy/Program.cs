using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Description();
            Proxy_Structural.Run();
            Proxy_Structural_Practice.Run();
            Console.WriteLine("-----");
            Proxy_RealWorld.Run();
            Console.ReadKey();
        }

        public static void Description()
        {
            Console.WriteLine("\n Proxy: Provide a surrogate or placeholder for another object to control access to it.");
        }
    }
}
