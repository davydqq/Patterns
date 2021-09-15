using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural
{
    public class ProxyPattern : IUsage
    {
        abstract class Subject
        {
            public abstract void Request();
        }

        class RealSubject : Subject
        {
            public override void Request()
            { }
        }

        class Proxy : Subject
        {
            RealSubject realSubject;
            public override void Request()
            {
                if (realSubject == null)
                    realSubject = new RealSubject();
                realSubject.Request();
            }
        }

        public void Usage()
        {
            Subject subject = new Proxy();
            subject.Request();
        }
    }
}
