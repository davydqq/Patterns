using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioural
{
    public class TemplateMethodPattern : IUsage
    {
        abstract class AbstractClass
        {
            public void TemplateMethod()
            {
                Operation1();
                Operation2();
            }
            public abstract void Operation1();
            public abstract void Operation2();
        }

        class ConcreteClass : AbstractClass
        {
            public override void Operation1()
            {
            }

            public override void Operation2()
            {
            }
        }

        class ConcreteClass2 : AbstractClass
        {
            public override void Operation1()
            {
            }

            public override void Operation2()
            {
            }
        }

        public void Usage()
        {
        }
    }
}
