using System;
using System.Collections;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Interpreter");
            // Structural C# code
            Context context = new Context();
            ArrayList list = new ArrayList();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.ReadKey();
        }
    }

    class Context { }

    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
