using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Command_Structural
    {
        public static void Run()
        {
            Console.WriteLine("This structural code demonstrates the Command pattern which stores requests as objects allowing clients to execute or playback the requests.");
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            /*
             Called Receiver.Action()
             */
        }
        abstract class Command
        {
            protected Receiver receiver;

            public Command(Receiver receiver)
            {
                this.receiver = receiver;
            }

            public abstract void Execute();
        }
        class ConcreteCommand : Command
        {
            public ConcreteCommand(Receiver receiver) : base(receiver)
            {
            }

            public override void Execute()
            {
                receiver.Action();
            }
        }
        class Receiver
        {
            public void Action()
            {
                Console.WriteLine("Called Receiver.Action()");
            }
        }
        class Invoker
        {
            private Command _command;

            public void SetCommand(Command command)
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
