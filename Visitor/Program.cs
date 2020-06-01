using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Visitor");

            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.ReadKey();
        }
    }

    abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }

    class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }
        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationB() { }
    }

    class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB() { }
    }

    class ObjectStructure
    {
        private List<Element> _elements = new List<Element>();

        public void Attach(Element element)
        {
            _elements.Add(element);
        }

        public void Detach (Element element)
        {
            _elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
