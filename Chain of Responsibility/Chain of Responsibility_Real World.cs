using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    class Chain_of_Responsibility_Real_World
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the Chain of Responsibility pattern in which several linked managers and executives can respond to a purchase request or hand it off to a superior. Each position has can have its own set of rules which orders they can approve.");
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
            /*
            Director Larry approved request# 2034
            President Tammy approved request# 2035
            Request# 2036 requires an executive meeting!
             */
        }
        //'Handler' abstract class
        abstract class Approver
        {
            protected Approver successor;
            public void SetSuccessor(Approver successor)
            {
                this.successor = successor;
            }

            public abstract void ProcessRequest(Purchase purchase);
        }

        // The 'ConcreteHandler class
        class Director : Approver
        {
            public override void ProcessRequest(Purchase purchase)
            {
                if (purchase.Amount < 10000.0)
                {
                    Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
                }
                else if (successor != null)
                {
                    successor.ProcessRequest(purchase);
                }
            }
        }
        class VicePresident : Approver
        {
            public override void ProcessRequest(Purchase purchase)
            {
                if (purchase.Amount < 25000.0)
                {
                    Console.WriteLine("{0} approved request#{1}", this.GetType().Name, purchase.Number);
                }
                else if (successor != null)
                {
                    successor.ProcessRequest(purchase);
                }
            }
        }

        class President : Approver
        {
            public override void ProcessRequest(Purchase purchase)
            {
                if (purchase.Amount < 100000.0)
                {
                    Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
                }
                else
                {
                    Console.WriteLine("Request# {0} requires an executive meeting!", purchase.Number);
                }
            }
        }

        // class holding request details

        class Purchase
        {
            private int _number;
            private double _amount;
            private string _purpose;

            public Purchase(int number, double amount, string purpose)
            {
                this._number = number;
                this._amount = amount;
                this._purpose = purpose;
            }

            public int Number
            {
                get { return _number; }
                set { _number = value; }
            }

            public double Amount
            {
                get { return _amount; }
                set { _amount = value; }
            }

            public string Purpose
            {
                get { return _purpose; }
                set { _purpose = value; }
            }
        }
    }
}
