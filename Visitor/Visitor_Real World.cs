using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Visitor_Real_World
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the Visitor pattern in which two objects traverse a list of Employees and performs the same operation on each Employee. The two visitor objects define different operations -- one adjusts vacation days and the other income.\n");
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
            /*
            Clerk Hank's new income: $27,500.00
            Director Elly's new income: $38,500.00
            President Dick's new income: $49,500.00

            Clerk Hank's new vacation days: 17
            Director Elly's new vacation days: 19
            President Dick's new vacation days: 24             
             */
        }
        // The 'Visitor' interface
        interface IVisitor
        {
            void Visit(Element element);
        }
        // A 'ConcreteVisitor' class
        class IncomeVisitor : IVisitor
        {
            public void Visit(Element element)
            {
                Employee employee = element as Employee;

                employee.Income *= 1.10;
                Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name, employee.Income);
            }
        }
        // A 'ConcreteVisitor' class
        class VacationVisitor : IVisitor
        {
            public void Visit(Element element)
            {
                Employee employee = element as Employee;

                employee.VacationDays += 3;
                Console.WriteLine("{0} {1}'s new vacation days: {2}",
                    employee.GetType().Name, employee.Name,
                    employee.VacationDays);
            }
        }
        // The 'Element' abstract class
        abstract class Element
        {
            public abstract void Accept(IVisitor visitor);
        }
        // The 'ConcreteElement' class
        class Employee : Element
        {
            private string _name;
            private double _income;
            private int _vacationDays;

            public Employee(string name, double income, int vacationDays)
            {
                this._name = name;
                this._income = income;
                this._vacationDays = vacationDays;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public double Income
            {
                get { return _income; }
                set { _income = value; }
            }

            public int VacationDays
            {
                get { return _vacationDays; }
                set { _vacationDays = value; }
            }

            public override void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }
        // The 'ObjectStructure' class
        class Employees
        {
            private List<Employee> _employees = new List<Employee>();

            public void Attach(Employee employee)
            {
                _employees.Add(employee);
            }

            public void Detach(Employee employee)
            {
                _employees.Remove(employee);
            }

            public void Accept(IVisitor visitor)
            {
                foreach (Employee e in _employees)
                {
                    e.Accept(visitor);
                }
                Console.WriteLine();
            }
        }
        // Three employee types
        class Clerk : Employee
        {
            public Clerk() : base("Hank", 25000.0, 14)
            {
            }
        }

        class Director : Employee
        {
            public Director() : base("Elly", 35000.0, 16)
            {
            }
        }

        class President : Employee
        {
            public President() : base("Dick", 45000.0, 21)
            {

            }
        }
    }
}
