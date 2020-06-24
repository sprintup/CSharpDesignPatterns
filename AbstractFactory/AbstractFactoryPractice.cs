using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class AbstractFactoryPractice
    {
        public static void Run()
        {
            Console.WriteLine("Abstract Factory Practice");
            ContinentFactory africa = new AfricaFactory();
        }
    }
}
