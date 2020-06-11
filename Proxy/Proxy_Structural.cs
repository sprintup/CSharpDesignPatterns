using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Proxy pattern which provides a representative object (proxy) that controls access to another similar object.");
            Proxy proxy1 = new Proxy();
            proxy1.Request();
            /*
             Called RealSubject.Request()
             */
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
