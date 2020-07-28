﻿using System;
using AbstractFactory;
using Factory_Method;
using Facade;
using Iterator;
using Observer;

namespace RunAll
{
    class RunAll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Lets run all the design patterns from most used to least, Structural and Real World, in the order Creational -> Structural -> Behavioral");
            Level5Patterns();
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