using System;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Command");
            // Real World C#

            User user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);
            user.Redo(3);

            //Structural C#
            Receiver receiver = new Receiver();
            Command1 command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }

        //The 'Command' abstract class
        abstract class Command
        {
            public abstract void Execute();
            public abstract void UnExecute();
        }

        abstract class Command1
        {
            protected Receiver receiver;

            public Command1(Receiver receiver)
            {
                this.receiver = receiver;
            }

            public abstract void Execute();
        }

        // The 'ConcreteCommand' class
        class CalculatorCommand : Command
        {
            private char _operator;
            private int _operand;
            private Calculator _calculator;

            //Constructor
            public CalculatorCommand(Calculator calculator, char @operator, int operand)
            {
                this._calculator = calculator;
                this._operator = @operator;
                this._operand = operand;
            }

            // Gets operator
            public char Operator
            {
                set { _operator = value; }
            }

            // Get operand
            public int Operand
            {
                set { _operand = value; }
            }

            // Execute new command
            public override void Execute()
            {
                _calculator.Operation(_operator, _operand);
            }

            //Unexecute last command
            public override void UnExecute()
            {
                _calculator.Operation(Undo(_operator), _operand);
            }

            // Returns opposite operator for given operator
            private char Undo(char @operator)
            {
                switch (@operator)
                {
                    case '+': return '-';
                    case '-': return '+';
                    case '*': return '/';
                    case '/': return '*';
                    default: throw new ArgumentException("@operator");
                }
            }
        }

        class ConcreteCommand : Command1
        {
            public ConcreteCommand(Receiver receiver) : base (receiver)
            {
            }

            public override void Execute()
            {
                receiver.Action();
            }
        }

        // The 'Receiver' class
        class Calculator
        {
            private int _curr = 0;
            public void Operation(char @operator, int operand)
            {
                switch (@operator)
                {
                    case '+': _curr += operand; break;
                    case '-': _curr -= operand; break;
                    case '*': _curr *= operand; break;
                    case '/': _curr /= operand; break;
                }
                Console.WriteLine("Current value = {0,3} (following {1} {2})", _curr, @operator, operand);
            }
        }
        class Receiver
        {
            public void Action()
            {
                Console.WriteLine("Called Receiver.Action()");
            }
        }

        // The 'Invoker' class
        class User
        {
            //Initializers
            private Calculator _calculator = new Calculator();
            private List<Command> _commands = new List<Command>();
            private int _current = 0;

            public void Redo(int levels)
            {
                Console.WriteLine("\n---- Redo {0} levels ", levels);
                // Perform redo operations
                for (int i = 0; i < levels; i++)
                {
                    if (_current < _commands.Count - 1)
                    {
                        Command command = _commands[_current++];
                        command.Execute();
                    }
                }
            }

            public void Undo(int levels)
            {
                Console.WriteLine("\n---- Undo {0} levels ", levels);
                // Perform undo operations
                for (int i = 0; i < levels; i++)
                {
                    if (_current > 0)
                    {
                        Command command = _commands[--_current] as Command;
                        command.UnExecute();
                    }
                }
            }

            public void Compute(char @operator, int operand)
            {
                // Create command operation and execute it
                Command command = new CalculatorCommand(
                    _calculator, @operator, operand);
                command.Execute();

                // Add command to undo list
                _commands.Add(command);
                _current++;
            }
        }

        class Invoker
        {
            private Command1 _command;

            public void SetCommand(Command1 command)
            {
                this._command = command;
            }

            public void ExecuteCommand()
            {
                _command.Execute();
            }
        }
    }
}
