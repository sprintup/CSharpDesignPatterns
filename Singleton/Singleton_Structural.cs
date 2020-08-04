using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Singleton pattern which assures only a single instance (the singleton) of the class can be created.");
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            /*
            Objects are the same instance             
             */
        }

        class Singleton
        {
            private static Singleton _instance;
            protected Singleton() { }
            public static Singleton Instance()
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
