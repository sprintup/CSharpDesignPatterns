using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Strategy_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Strategy pattern which encapsulates functionality in the form of an object. This allows clients to dynamically change algorithmic strategies.\n");
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
            /*
            Called ConcreteStrategyA.AlgorithmInterface()
            Called ConcreteStrategyB.AlgorithmInterface()
            Called ConcreteStrategyC.AlgorithmInterface()
             */
        }
        abstract class Strategy
        {
            public abstract void AlgorithmInterface();
        }
        class ConcreteStrategyA : Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
            }
        }
        class ConcreteStrategyB : Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
            }
        }
        class ConcreteStrategyC : Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyC. AlgorithmInterface()");
            }
        }
        class Context
        {
            private Strategy _strategy;

            public Context(Strategy strategy)
            {
                this._strategy = strategy;
            }

            public void ContextInterface()
            {
                _strategy.AlgorithmInterface();
            }
        }
    }
}
