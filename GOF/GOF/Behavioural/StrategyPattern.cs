using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioural
{
    public class StrategyPattern : IUsage
    {
        public interface IStrategy
        {
            void Algorithm();
        }

        public class ConcreteStrategy1 : IStrategy
        {
            public void Algorithm()
            {
                Console.WriteLine(typeof(ConcreteStrategy1));
            }
        }

        public class ConcreteStrategy2 : IStrategy
        {
            public void Algorithm()
            {
                Console.WriteLine(typeof(ConcreteStrategy2));
            }
        }

        public class Context
        {
            public IStrategy ContextStrategy { get; set; }

            public Context(IStrategy _strategy)
            {
                ContextStrategy = _strategy;
            }

            public void ExecuteAlgorithm()
            {
                ContextStrategy.Algorithm();
            }
        }

        public void Usage()
        {
            var context = new Context(new ConcreteStrategy1());
            context.ExecuteAlgorithm();
            context.ContextStrategy = new ConcreteStrategy2();
            context.ExecuteAlgorithm();
        }
    }
}
