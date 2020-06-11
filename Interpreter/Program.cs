using System;
using System.Collections;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nInterpreter: Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.");
            Interpreter_Structural.Run();
            Console.WriteLine("-----");
            Interpreter_Real_World.Run();
            Console.ReadKey();
        }
    }
}
