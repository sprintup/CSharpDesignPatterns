using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    class Template_Method_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Template method which provides a skeleton calling sequence of methods. One or more steps can be deferred to subclasses which implement these steps without changing the overall calling sequence.\n");
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            /*
            ConcreteClassA.PrimitiveOperation1()
            ConcreteClassA.PrimitiveOperation2()             
             */
        }
        abstract class AbstractClass
        {
            public abstract void PrimitiveOperation1();
            public abstract void PrimitiveOperation2();

            public void TemplateMethod()
            {
                PrimitiveOperation1();
                PrimitiveOperation2();
                Console.WriteLine("");
            }
        }
        class ConcreteClassA : AbstractClass
        {
            public override void PrimitiveOperation1()
            {
                Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
            }
            public override void PrimitiveOperation2()
            {
                Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
            }
        }
        class ConcreteClassB : AbstractClass
        {
            public override void PrimitiveOperation1()
            {
                Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
            }
            public override void PrimitiveOperation2()
            {
                Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
            }
        }
    }
}
