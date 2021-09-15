using System;

namespace GOF.Structural
{
    public class AdapterPattern : IUsage
    {
        public class Target
        {
            public virtual void Request()
            { }
        }

        public class Adapter : Target
        {
            private Adaptee adaptee = new Adaptee();

            public override void Request()
            {
                adaptee.SpecificRequest();
            }
        }

        public class Adaptee
        {
            public void SpecificRequest()
            { }
        }

        public void Request(Target target)
        {
            target.Request();
        }

        // EXAMPLE

        interface ITransport
        {
            void Drive();
        }

        class Auto : ITransport
        {
            public void Drive()
            {
                Console.WriteLine("Auto");
            }
        }

        class Driver
        {
            public void Travel(ITransport transport)
            {
                transport.Drive();
            }
        }

        interface IAnimal
        {
            void Move();
        }

        class Camel : IAnimal
        {
            public void Move()
            {
                Console.WriteLine("Camel");
            }
        }

        class CamelToTransportAdapter : ITransport
        {
            Camel camel;
            public CamelToTransportAdapter(Camel c)
            {
                camel = c;
            }

            public void Drive()
            {
                camel.Move();
            }
        }


        public void Usage()
        {
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            Camel camel = new Camel();
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            driver.Travel(camelTransport);

            Console.Read();
        }
    }
}
