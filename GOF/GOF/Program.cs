using GOF.Behavioural;
using GOF.Structural;
using System;

namespace GOF
{
    class Program
    {
        static void Main(string[] args)
        {
            IUsage strategy = new DecoratorPattern();
            strategy.Usage();
        }
    }
}
