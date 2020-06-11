using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Flyweight_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Flyweight pattern in which a relatively small number of objects is shared many times by different clients.");

            int extrinsicstate = 22;

            FlyweightFactory factory1 = new FlyweightFactory();

            Flyweight fx = factory1.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory1.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory1.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);
            /*
                ConcreteFlyweight: 21
                ConcreteFlyweight: 20
                ConcreteFlyweight: 19
                UnsharedConcreteFlyweight: 18
             */
        }

        class FlyweightFactory
        {
            private Hashtable flyweights = new Hashtable();

            public FlyweightFactory()
            {
                flyweights.Add("X", new ConcreteFlyweight());
                flyweights.Add("Y", new ConcreteFlyweight());
                flyweights.Add("Z", new ConcreteFlyweight());
            }

            public Flyweight GetFlyweight(string key)
            {
                return ((Flyweight)flyweights[key]);
            }
        }

        abstract class Flyweight
        {
            public abstract void Operation(int extrinsicstate);
        }

        class ConcreteFlyweight : Flyweight
        {
            public override void Operation(int extrinsicstate)
            {
                Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
            }
        }

        class UnsharedConcreteFlyweight : Flyweight
        {
            public override void Operation(int extrinsicstate)
            {
                Console.WriteLine("UnsharedConcreteFlyweight: " + extrinsicstate);
            }
        }
    }
}
