using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Adapter pattern which maps the interface of one class onto another so that they can work together. These incompatible classes may come from different libraries or frameworks.");
            Target target = new Adapter();
            target.Request();
            /*
            Called SpecificRequest()             
             */
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
                Console.WriteLine("Called SpecificRequst()");
            }
        }
    }
}
