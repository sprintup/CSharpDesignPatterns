using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Command_Real_World_Practice
    {
        public static void Run()
        {
            Console.WriteLine("\nCommand Real World Practice");
            User user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);
            user.Redo(3);
        }
        abstract class Command
        {
            public abstract void Execute();
            public abstract void UnExecute();
        }
        class CalculatorCommand : Command
        {
            private char _operator;
            private int _operand;
            private Calculator _calculator;

            public CalculatorCommand(Calculator calculator, char @operator, int operand)
            {
                this._calculator = calculator;
                this._operator = @operator;
                this._operand = operand;
            }
            public char Operator
            {
                set { _operator = value; }
            }
            public int Operand
            {
                set { _operand = value; }
            }
            public override void Execute()
            {
                _calculator.Operation(_operator, _operand);
            }
            public override void UnExecute()
            {
                _calculator.Operation(Undo(_operator), _operand);
            }
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
        class User
        {
            private Calculator _calculator = new Calculator();
            private List<Command> _commands = new List<Command>();
            private int _current = 0;

            public void Redo(int levels)
            {
                Console.WriteLine("\n---- Redo {0} levels ", levels);
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
                Command command = new CalculatorCommand(
                    _calculator, @operator, operand);
                command.Execute();

                _commands.Add(command);
                _current++;
            }
        }
    }
}
