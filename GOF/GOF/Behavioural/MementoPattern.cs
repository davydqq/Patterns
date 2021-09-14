using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioural
{
    public class MementoPattern : IUsage
    {
        class Memento
        {
            public string State { get; private set; }
            public Memento(string state)
            {
                State = state;
            }
        }

        class Caretaker
        {
            public Memento Memento { get; set; }
        }

        class Originator
        {
            public string State { get; set; }

            public void SetMemento(Memento memento)
            {
                State = memento.State;
            }

            public Memento CreateMemento()
            {
                return new Memento(State);
            }
        }

        public void Usage()
        {

        }
    }
}
