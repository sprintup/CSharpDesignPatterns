using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Command_Real_World
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the Command pattern used in a simple calculator with unlimited number of undo's and redo's. Note that in C#  the word 'operator' is a keyword. Prefixing it with '@' allows using it as an identifier.");
            User user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);
            user.Redo(3);
            /*
            Current value = 100 (following + 100)
            Current value =  50 (following - 50)
            Current value = 500 (following * 10)
            Current value = 250 (following / 2)

            ---- Undo 4 levels
            Current value = 500 (following * 2)
            Current value =  50 (following / 10)
            Current value = 100 (following + 50)
            Current value =   0 (following - 100)

            ---- Redo 3 levels
            Current value = 100 (following + 100)
            Current value =  50 (following - 50)
            Current value = 500 (following * 10)
             */
        }
        //The 'Command' abstract class
        abstract class Command
        {
            public abstract void Execute();
            public abstract void UnExecute();
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
    }
}
