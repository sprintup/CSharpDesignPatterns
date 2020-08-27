using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Composite_RealWorld_Practice
    {
        public static void Run()
        {
            Console.WriteLine("\n Composite Real World Practice");
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            root.Display(1);
        }

        abstract class DrawingElement
        {
            protected string _name;

            public DrawingElement(string name)
            {
                this._name = name;
            }
            public abstract void Add(DrawingElement d);
            public abstract void Remove(DrawingElement d);
            public abstract void Display(int indent);
        }

        class PrimitiveElement : DrawingElement
        {
            public PrimitiveElement(string name) : base(name) { }
            public override void Add(DrawingElement d)
            {
                Console.WriteLine("Cannot add to a PrimitiveElement");
            }
            public override void Remove(DrawingElement d)
            {
                Console.WriteLine("Cannot remove from a PrimitiveElement");
            }
            public override void Display(int indent)
            {
                Console.WriteLine(new String('-', indent) + _name);
            }
        }

        class CompositeElement : DrawingElement
        {
            private List<DrawingElement> elements = new List<DrawingElement>();

            public CompositeElement(string name) : base(name) { }
            public override void Add(DrawingElement d)
            {
                elements.Add(d);
            }
            public override void Remove(DrawingElement d)
            {
                elements.Remove(d);
            }
            public override void Display(int indent)
            {
                Console.WriteLine(new String('-', indent) + "+ " + _name);
                foreach (DrawingElement d in elements)
                {
                    d.Display(indent + 2);
                }
            }
        }
    }
}
