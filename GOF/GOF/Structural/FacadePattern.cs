using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural
{
    public class FacadePattern : IUsage
    {
        public class SubsystemA
        {
            public void A1()
            { }
        }
        public class SubsystemB
        {
            public void B1()
            { }
        }
        public class SubsystemC
        {
            public void C1()
            { }
        }

        public class Facade
        {
            SubsystemA subsystemA;
            SubsystemB subsystemB;
            SubsystemC subsystemC;

            public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
            {
                subsystemA = sa;
                subsystemB = sb;
                subsystemC = sc;
            }
            public void Operation1()
            {
                subsystemA.A1();
                subsystemB.B1();
                subsystemC.C1();
            }
            public void Operation2()
            {
                subsystemB.B1();
                subsystemC.C1();
            }
        }

        public void Usage()
        {
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            facade.Operation1();
            facade.Operation2();
        }
    }
}
