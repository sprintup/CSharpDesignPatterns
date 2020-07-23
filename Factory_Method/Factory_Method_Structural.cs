using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class Factory_Method_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Factory method offering great flexibility in creating different objects. The Abstract class may provide a default object, but each subclass can instantiate an extended version of the object.");
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
            /*
            Created ConcreteProductA
            Created ConcreteProductB          
             */
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
