using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Memento pattern which temporary saves and restores another object's internal state.\n");
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";

            o.SetMemento(c.Memento);
            /*
            State = On
            State = Off
            Restoring state:
            State = On
             */
        }
        class Originator
        {
            private string _state;

            public string State
            {
                get { return _state; }
                set
                {
                    _state = value;
                    Console.WriteLine("State = " + _state);
                }
            }

            public Memento CreateMemento()
            {
                return (new Memento(_state));
            }

            public void SetMemento(Memento memento)
            {
                Console.WriteLine("Restoring state...");
                State = memento.State;
            }
        }
        class Memento
        {
            private string _state;

            public Memento(string state)
            {
                this._state = state;
            }

            public string State
            {
                get { return _state; }
            }
        }
        class Caretaker
        {
            private Memento _memento;

            public Memento Memento
            {
                set { _memento = value; }
                get { return _memento; }
            }
        }
    }

}
