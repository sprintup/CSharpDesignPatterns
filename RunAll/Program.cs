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

            NewPattern(5,1);
            AbstractFactory.Program.Description();
            Seperate();
            AbstractFactoryStructural.Run();
            Seperate();
            AbstractFactoryRealWorld.Run();

            NewPattern(5, 1);
            Factory_Method.Program.Description();
            Seperate();
            Factory_Method_Structural.Run();
            Seperate();
            Factory_Method_RealWorld.Run();
        }
        /// <summary>Start a new pattern to run through</summary>
        /// <param name="frequencyOfUse">Scale out of 5 with 5 being most frequent</param>
        /// <param name="type">1 = Creational, 2 = Structural, 3 = Behavioral</param>
        static void NewPattern(int frequencyOfUse, int type)
        {
            string designPatternType = "";
            switch (type)
            {
                case 1:
                    designPatternType = "Creational";
                    break;
                case 2:
                    designPatternType = "Structural";
                    break;
                case 3:
                    designPatternType = "Behavioral";
                    break;
                default:
                    break;
            }
            Console.WriteLine("\n*****  {0} of 5 | {1}", frequencyOfUse.ToString(),designPatternType);
        }

        static void Seperate()
        {
            Console.WriteLine("-----");
        }
    }
}
