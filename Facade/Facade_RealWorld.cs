using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade_RealWorld
    {
        public static void Run()
        {
            Console.WriteLine("\nThis real-world code demonstrates the Facade pattern as a MortgageApplication object which provides a simplified interface to a large subsystem of classes measuring the creditworthyness of an applicant.");
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            /*
                Ann McKinsey applies for $125,000.00 loan

                Check bank for Ann McKinsey
                Check loans for Ann McKinsey
                Check credit for Ann McKinsey

                Ann McKinsey has been Approved
             */
        }

        class Bank
        {
            public bool HasSufficientSavings(Customer c, int amount)
            {
                Console.WriteLine("Check bank for " + c.Name);
                return true;
            }
        }

        class Credit
        {
            public bool HasGoodCredit(Customer c)
            {
                Console.WriteLine("Check credit for " + c.Name);
                return true;
            }
        }

        class Loan
        {
            public bool HasNoBadLoans(Customer c)
            {
                Console.WriteLine("Check loans for " + c.Name);
                return true;
            }
        }

        class Customer
        {
            private string _name;
            public Customer(string name)
            {
                this._name = name;
            }
            public string Name
            {
                get { return _name; }
            }
        }

        class Mortgage
        {
            private Bank _bank = new Bank();
            private Loan _loan = new Loan();
            private Credit _credit = new Credit();

            public bool IsEligible(Customer cust, int amount)
            {
                Console.WriteLine("{0} applies for {1:C} loan\n", cust.Name, amount);

                bool eligible = true;

                if (!_bank.HasSufficientSavings(cust, amount))
                {
                    eligible = false;
                }
                else if (!_loan.HasNoBadLoans(cust))
                {
                    eligible = false;
                }
                else if (!_credit.HasGoodCredit(cust))
                {
                    eligible = false;
                }
                return eligible;
            }
        }
    }
}
