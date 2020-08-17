using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter_Structural_Practice
    {
        public static void Run()
        {
            Console.WriteLine("Adapter Structural Practice");
            Target target = new Adapter();
            target.Request();
        }

        class Target
        {
            public virtual void Request()
            {
                Console.WriteLine("Called Target Request()");
            }
        }
        class Adapter : Target
        {
            private Adaptee _adaptee = new Adaptee();
            public override void Request()
            {
                _adaptee.SpecificRequest();
            }
        }
        class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
    }
}
