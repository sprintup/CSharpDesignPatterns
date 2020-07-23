using System;
using AbstractFactory;

namespace RunAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Lets run all the design patterns from most used to least, Structural and Real World, in the order Creational -> Structural -> Behavioral");

            NewPattern(5);
            AbstractFactory.Program.Description();
            AbstractFactory.AbstractFactoryStructural.Run();
            AbstractFactory.AbstractFactoryRealWorld.Run();

        }

        static void NewPattern(int frequencyOfUse)
        {
            Console.WriteLine("\n*****  {0} of 5", frequencyOfUse.ToString());
        }
    }
}
