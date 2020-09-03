using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy_Structural_Practice
    {
        public static void Run()
        {
            Console.WriteLine("Proxy Structural Practice");
            Proxy proxy1 = new Proxy();
            proxy1.Request();
        }

        abstract class Subject
        {
            public abstract void Request();
        }

        class RealSubject : Subject
        {
            public override void Request()
            {
                Console.WriteLine("Called RealSubject.Request()");
            }
        }

        class Proxy : Subject
        {
            private RealSubject _realSubject;

            public override void Request()
            {
                if (_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }
                _realSubject.Request();
            }
        }
    }
}
