using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Mediator_Real_World
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the Mediator pattern facilitating loosely coupled communication between different Participants registering with a Chatroom. The Chatroom is the central hub through which all communication takes place. At this point only one-to-one communication is implemented in the Chatroom, but would be trivial to change to one-to-many.\n");
            Chatroom chatroom = new Chatroom();

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            /*
            To a Beatle: Yoko to John: 'Hi John!'
            To a Beatle: Paul to Ringo: 'All you need is love'
            To a Beatle: Ringo to George: 'My sweet Lord'
            To a Beatle: Paul to John: 'Can't buy me love'
            To a non-Beatle: John to Yoko: 'My sweet love'             
             */
        }
        abstract class AbstractChatroom
        {
            public abstract void Register(Participant participant);
            public abstract void Send(string from, string to, string message);
        }

        // The 'ConcreteMediator' class
        class Chatroom : AbstractChatroom
        {
            private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();
            public override void Register(Participant participant)
            {
                if (!_participants.ContainsValue(participant))
                {
                    _participants[participant.Name] = participant;
                }
                participant.Chatroom = this;
            }
            public override void Send(string from, string to, string message)
            {
                Participant particpant = _participants[to];
                if (particpant != null)
                {
                    particpant.Receive(from, message);
                }
            }
        }


        // The 'AbstractColleague'
        class Participant
        {
            private Chatroom _chatroom;
            private string _name;

            public Participant(string name)
            {
                this._name = name;
            }
            public string Name
            {
                get { return _name; }
            }
            public Chatroom Chatroom
            {
                set { _chatroom = value; }
                get { return _chatroom; }
            }
            public void Send(string to, string message)
            {
                _chatroom.Send(_name, to, message);
            }
            public virtual void Receive(string from, string message)
            {
                Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
            }
        }


        // The 'ConcreteColleague' class
        class Beatle : Participant
        {
            public Beatle(string name) : base(name) { }

            public override void Receive(string from, string message)
            {
                Console.Write("To a Beatle: ");
                base.Receive(from, message);
            }
        }
        class NonBeatle : Participant
        {
            public NonBeatle(string name) : base(name) { }
            public override void Receive(string from, string message)
            {
                Console.Write("To a non-Beatle: ");
                base.Receive(from, message);
            }
        }
    }
}
