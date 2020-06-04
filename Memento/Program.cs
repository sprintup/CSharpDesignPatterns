using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Memento");
            // Real-world C#
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            s.RestoreMemento(m.Memento);
            Console.WriteLine("----");
            // Structural C#
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";

            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }
    //  The 'Originator' class
    class SalesProspect
    {
        private string _name;
        private string _phone;
        private double _budget;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Console.WriteLine("Name: " + _name);
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                Console.WriteLine("Phone: " + _phone);
            }
        }
        public double Budget
        {
            get { return _budget; }
            set
            {
                _budget = value;
                Console.WriteLine("Budget: " + _budget);
            }
        }
        public Memento2 SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento2(_name, _phone, _budget);
        }

        public void RestoreMemento(Memento2 memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }

    class Memento2
    {
        private string _name;
        private string _phone;
        private double _budget;

        public Memento2(string name, string phone, double budget)
        {
            this._name = name;
            this._phone = phone;
            this._budget = budget;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public double Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }
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

        public Memento1 CreateMemento()
        {
            return (new Memento1(_state));
        }

        public void SetMemento(Memento1 memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }

    class Memento1
    {
        private string _state;

        public Memento1(string state)
        {
            this._state = state;
        }

        public string State
        {
            get { return _state; }
        }
    }
    // The 'Caretaker' class
    class ProspectMemory
    {
        private Memento2 _memento;

        public Memento2 Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
    class Caretaker
    {
        private Memento1 _memento;

        public Memento1 Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
