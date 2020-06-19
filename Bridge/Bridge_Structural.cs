using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Bridge_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Bridge pattern which separates (decouples) the interface from its implementation. The implementation can evolve without changing clients which use the abstraction of the object.");
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            /*
            ConcreteImplementorA Operation
            ConcreteImplementorB Operation             
             */
        }
        class Abstraction
        {
            protected Implementor implementor;

            public Implementor Implementor
            {
                set { implementor = value; }
            }

            public virtual void Operation()
            {
                implementor.Operation();
            }
        }

        abstract class Implementor
        {
            public abstract void Operation();
        }

        class RefinedAbstraction : Abstraction
        {
            public override void Operation()
            {
                implementor.Operation();
            }
        }

        class ConcreteImplementorA : Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementorA Operation");
            }
        }

        class ConcreteImplementorB : Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementorB Operation");
            }
        }
    }
}
