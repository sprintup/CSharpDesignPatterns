using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Singleton_Structural_Practice
    {
        public static void Run()
        {
            Console.WriteLine("\br Singleton Structural Practice");
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
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
