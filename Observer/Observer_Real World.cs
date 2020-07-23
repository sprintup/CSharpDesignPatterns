using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Observer_Real_World
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the Observer pattern in which registered investors are notified every time a stock changes value.\n");
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            /*
            Notified Sorros of IBM's change to $120.10
            Notified Berkshire of IBM's change to $120.10

            Notified Sorros of IBM's change to $121.00
            Notified Berkshire of IBM's change to $121.00

            Notified Sorros of IBM's change to $120.50
            Notified Berkshire of IBM's change to $120.50

            Notified Sorros of IBM's change to $120.75
            Notified Berkshire of IBM's change to $120.75             
             */
        }
        abstract class Stock
        {
            private string _symbol;
            private double _price;
            private List<IInvestor> _investors = new List<IInvestor>();

            public Stock(string symbol, double price)
            {
                this._symbol = symbol;
                this._price = price;
            }

            public void Attach(IInvestor investor)
            {
                _investors.Add(investor);
            }
            public void Detach(IInvestor investor)
            {
                _investors.Add(investor);
            }
            public void Notify()
            {
                foreach (IInvestor investor in _investors)
                {
                    investor.Update(this);
                }
                Console.WriteLine(" ");
            }
            public double Price
            {
                get { return _price; }
                set
                {
                    if (_price != value)
                    {
                        _price = value;
                        Notify();
                    }
                }
            }
            public string Symbol
            {
                get { return _symbol; }
            }
        }

        // The 'ConcreteObserver' class
        class Investor : IInvestor
        {
            private string _name;
            private Stock _stock;

            public Investor(string name)
            {
                this._name = name;
            }
            public void Update(string name)
            {
                this._name = name;
            }
            public void Update(Stock stock)
            {
                Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Symbol, stock.Price);
            }
            public Stock Stock
            {
                get { return _stock; }
                set { _stock = value; }
            }
        }
        // The 'ConcreteSubject' class
        class IBM : Stock
        {
            public IBM(string symbol, double price) : base(symbol, price) { }
        }

        //The 'Observer' Interface
        interface IInvestor
        {
            void Update(Stock stock);
        }
    }
}
