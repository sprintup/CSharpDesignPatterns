using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Practice
{
    class FactoryMethod_StructuralPractice
    {
        public static void Run()
        {
            Console.WriteLine("\nFactory Method Structural Practice");
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }

        abstract class Creator 
        {
            public abstract Product FactoryMethod();
        }

        abstract class Product { }

        class ConcreteCreatorA : Creator
        {
            public override Product FactoryMethod()
            {
                return new ConcreteProductA();
            }
        }

        class ConcreteProductA : Product { }

        class ConcreteCreatorB : Creator
        {
            public override Product FactoryMethod()
            {
                return new ConcreteProductB();
            }
        }

        class ConcreteProductB : Product { }
    }
}
