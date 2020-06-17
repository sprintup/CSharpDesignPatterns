using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Visitor_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Visitor pattern in which an object traverses an object structure and performs the same operation on each node in this structure. Different visitor objects define different operations.\n");
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);
            /*
            ConcreteElementA visited by ConcreteVisitor1
            ConcreteElementB visited by ConcreteVisitor1
            ConcreteElementA visited by ConcreteVisitor2
            ConcreteElementB visited by ConcreteVisitor2             
             */
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
        abstract class Element1
        {
            public abstract void Accept(Visitor visitor);
        }
        class ConcreteElementA : Element1
        {
            public override void Accept(Visitor visitor)
            {
                visitor.VisitConcreteElementA(this);
            }

            public void OperationB() { }
        }
        class ConcreteElementB : Element1
        {
            public override void Accept(Visitor visitor)
            {
                visitor.VisitConcreteElementB(this);
            }

            public void OperationB() { }
        }
        class ObjectStructure
        {
            private List<Element1> _elements = new List<Element1>();

            public void Attach(Element1 element)
            {
                _elements.Add(element);
            }

            public void Detach(Element1 element)
            {
                _elements.Remove(element);
            }

            public void Accept(Visitor visitor)
            {
                foreach (Element1 element in _elements)
                {
                    element.Accept(visitor);
                }
            }
        }
    }
}
