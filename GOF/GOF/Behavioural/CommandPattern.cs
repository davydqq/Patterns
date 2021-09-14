using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioural
{
    public class CommandPattern : IUsage
    {
        abstract class Command
        {
            public abstract void Execute();
            public abstract void Undo();
        }

        class ConcreteCommand : Command
        {
            Receiver receiver;
            public ConcreteCommand(Receiver r)
            {
                receiver = r;
            }
            public override void Execute()
            {
                receiver.Operation();
            }

            public override void Undo()
            { }
        }

        class Receiver
        {
            public void Operation()
            { }
        }

        class Invoker
        {
            Command command;
            public void SetCommand(Command c)
            {
                command = c;
            }
            public void Run()
            {
                command.Execute();
            }
            public void Cancel()
            {
                command.Undo();
            }
        }

        public void Usage()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            invoker.SetCommand(command);
            invoker.Run();
        }
    }
}
