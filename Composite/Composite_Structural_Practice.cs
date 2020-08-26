using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Composite_Structural_Practice
    {
        public static void Run()
        {
            Console.WriteLine("\n Composite structural practice");
            Composite root1 = new Composite("root");
            root1.Add(new Leaf("Leaaf A"));
            root1.Add(new Leaf("Leaf B"));

            Composite comp1 = new Composite("Composite X");
            comp1.Add(new Leaf("Leaf XA"));
            comp1.Add(new Leaf("Leaf XB"));

            root1.Add(comp1);
            root1.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root1.Add(leaf);
            root1.Remove(leaf);

            root1.Display(1);
        }

        abstract class Component
        {
            protected string name;

            public Component(string name)
            {
                this.name = name;
            }

            public abstract void Add(Component c);
            public abstract void Remove(Component c);
            public abstract void Display(int depth);
        }

        class Composite : Component
        {
            private List<Component> _children = new List<Component>();
            public Composite(string name) : base(name) { }
            public override void Add(Component component)
            {
                _children.Add(component);
            }
            public override void Remove(Component c)
            {
                _children.Remove(c);
            }
            public override void Display(int depth)
            {
                Console.WriteLine(new String('-', depth) + name);

                foreach (Component component in _children)
                {
                    component.Display(depth + 2);
                }
            }
        }

        class Leaf : Component
        {
            public Leaf(string name) : base(name) { }
            public override void Add(Component c)
            {
                Console.WriteLine("Cannot add to a leaf");
            }
            public override void Remove(Component c)
            {
                Console.WriteLine("Cannot remove from a leaf");
            }
            public override void Display(int depth)
            {
                Console.WriteLine(new String('-', depth) + name);
            }
        }
    }
}
