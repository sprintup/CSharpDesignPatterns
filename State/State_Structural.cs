using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class State_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the State pattern which allows an object to behave differently depending on its internal state. The difference in behavior is delegated to objects that represent this state.\n");
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
            /*
            State: ConcreteStateA
            State: ConcreteStateB
            State: ConcreteStateA
            State: ConcreteStateB
            State: ConcreteStateA             
             */
        }

        abstract class State
        {
            public abstract void Handle(Context context);
        }

        class ConcreteStateA : State
        {
            public override void Handle(Context context)
            {
                context.State = new ConcreteStateB();
            }
        }
        class ConcreteStateB : State
        {
            public override void Handle(Context context)
            {
                context.State = new ConcreteStateA();
            }
        }
        class Context
        {
            private State _state;
            public Context(State state)
            {
                this.State = state;
            }
            public State State
            {
                get { return _state; }
                set
                {
                    _state = value;
                    Console.WriteLine("State: " + _state.GetType().Name);
                }
            }

            public void Request()
            {
                _state.Handle(this);
            }
        }
    }
}
