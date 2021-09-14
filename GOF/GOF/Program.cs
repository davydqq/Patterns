using GOF.Behavioural;
using System;

namespace GOF
{
    class Program
    {
        static void Main(string[] args)
        {
            IUsage strategy = new InterpreterPattern();
            strategy.Usage();
        }
    }
}
