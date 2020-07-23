using System;
using AbstractFactory;
using Factory_Method;

namespace RunAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Lets run all the design patterns from most used to least, Structural and Real World, in the order Creational -> Structural -> Behavioral");

            NewPattern(5);
            AbstractFactory.Program.Description();
            AbstractFactoryStructural.Run();
            Seperate();
            AbstractFactoryRealWorld.Run();

            NewPattern(5);
            Factory_Method.Program.Description();
            Factory_Method_Structural.Run();
            Seperate();
            Factory_Method_RealWorld.Run();
        }

        static void NewPattern(int frequencyOfUse)
        {
            Console.WriteLine("\n*****  {0} of 5", frequencyOfUse.ToString());
        }

        static void Seperate()
        {
            Console.WriteLine("-----");
        }
    }
}
