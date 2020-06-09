using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Factory_Method_Structural
    {
        public static void Run()
        {
            Console.WriteLine("Factory Method Structural");
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }
        abstract class Product { }
        class ConcreteProductA : Product { }
        class ConcreteProductB : Product { }
        abstract class Creator
        {
            public abstract Product FactoryMethod();
        }
        class ConcreteCreatorA : Creator
        {
            public override Product FactoryMethod()
            {
                return new ConcreteProductA();
            }
        }
        class ConcreteCreatorB : Creator
        {
            public override Product FactoryMethod()
            {
                return new ConcreteProductB();
            }
        }
    }
}
