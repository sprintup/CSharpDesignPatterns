using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Interpreter_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Interpreter patterns, which using a defined grammer, provides the interpreter that processes parsed statements.");
            Context context1 = new Context();
            ArrayList list = new ArrayList();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context1);
            }
            /*
            Called Terminal.Interpret()
            Called Nonterminal.Interpret()
            Called Terminal.Interpret()
            Called Terminal.Interpret()             
             */
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
}
