using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Mediator_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Mediator pattern facilitating loosely coupled communication between different objects and object types. The mediator is a central hub through which all interaction must take place.\n");

            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleage2 c2 = new ConcreteColleage2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");
            /*
            Colleague2 gets message: How are you?
            Colleague1 gets message: Fine, thanks
             */
        }
        abstract class Mediator
        {
            public abstract void Send(string message, Colleague colleague);
        }
        class ConcreteMediator : Mediator
        {
            private ConcreteColleague1 _colleague1;
            private ConcreteColleage2 _colleague2;

            public ConcreteColleague1 Colleague1
            {
                set { _colleague1 = value; }
            }
            public ConcreteColleage2 Colleague2
            {
                set { _colleague2 = value; }
            }
            public override void Send(string message, Colleague colleague)
            {
                if (colleague == _colleague1)
                {
                    _colleague2.Notify(message);
                }
                else
                {
                    _colleague1.Notify(message);
                }
            }
        }
        abstract class Colleague
        {
            protected Mediator mediator;
            public Colleague(Mediator mediator)
            {
                this.mediator = mediator;
            }
        }
        class ConcreteColleague1 : Colleague
        {
            public ConcreteColleague1(Mediator mediator) : base(mediator)
            {
            }

            public void Send(string message)
            {
                mediator.Send(message, this);
            }
            public void Notify(string message)
            {
                Console.WriteLine("Colleague1 gets message: " + message);
            }
        }
        class ConcreteColleage2 : Colleague
        {
            public ConcreteColleage2(Mediator mediator) : base(mediator) { }

            public void Send(string message)
            {
                mediator.Send(message, this);
            }
            public void Notify(string message)
            {
                Console.WriteLine("Colleague2 gets message: " + message);
            }
        }
    }
}
