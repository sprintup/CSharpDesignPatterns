using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Decorator_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Decorator pattern which dynamically adds extra functionality to an existing object.");

            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            /*
            ConcreteComponent.Operation()
            ConcreteDecoratorA.Operation()
            ConcreteDecoratorB.Operation()
             */
        }

        abstract class Component
        {
            public abstract void Operation();
        }

        class ConcreteComponent : Component
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteComponent.Operation()");
            }
        }

        abstract class Decorator : Component
        {
            protected Component component;

            public void SetComponent(Component component)
            {
                this.component = component;
            }

            public override void Operation()
            {
                if (component != null)
                {
                    component.Operation();
                }
            }
        }

        class ConcreteDecoratorA : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                Console.WriteLine("ConcreteDecoratorA.Operation()");
            }
        }

        class ConcreteDecoratorB : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                AddedBehavior();
                Console.WriteLine("ConcreteDecoratorB.Operation()");
            }
            void AddedBehavior() { }
        }
    }
}
