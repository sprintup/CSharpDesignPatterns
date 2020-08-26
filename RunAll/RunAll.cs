using System;
using AbstractFactory;
using Factory_Method;
using Facade;
using Iterator;
using Observer;
using Singleton;
using Adapter;
using Composite;
using Proxy;
using Command;
using Strategy;

namespace RunAll
{
    class RunAll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Lets run all the design patterns from most used to least, Structural and Real World, in the order Creational -> Structural -> Behavioral");
            Level5Patterns();
            Level4Patterns();
        }

        private static void Level5Patterns()
        {
            NewPattern(5, 1);
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

            NewPattern(5, 2);
            Facade.Program.Description();
            Seperate();
            Facade_Structural.Run();
            Seperate();
            Facade_RealWorld.Run();

            NewPattern(5, 3);
            Iterator.Program.Description();
            Seperate();
            Iterator_Structural.Run();
            Seperate();
            Iterator_Real_World.Run();

            NewPattern(5, 3);
            Observer.Program.Description();
            Seperate();
            Observer_Structural.Run();
            Seperate();
            Observer_Real_World.Run();
        }

        private static void Level4Patterns() 
        {
            NewPattern(4, 1);
            Singleton.Program.Description();
            Seperate();
            Singleton_Structural.Run();
            Seperate();
            Singleton_RealWorld.Run();

            NewPattern(4, 2);
            Adapter.Program.Description();
            Seperate();
            Adapter_Structural.Run();
            Seperate();
            Adapter_RealWorld.Run();

            NewPattern(4, 2);
            Composite.Program.Description();
            Seperate();
            Composite_Structural.Run();
            Seperate();
            Composite_RealWorld.Run();

            NewPattern(4, 2);
            Proxy.Program.Description();
            Seperate();
            Proxy_Structural.Run();
            Seperate();
            Proxy_RealWorld.Run();

            NewPattern(4, 3);
            Command.Program.Description();
            Seperate();
            Command_Structural.Run();
            Seperate();
            Command_Real_World.Run();

            NewPattern(4, 3);
            Strategy.Program.Description();
            Seperate();
            Strategy_Structural.Run();
            Seperate();
            Strategy_Real_World.Run();
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
