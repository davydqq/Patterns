using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural
{
    public class BridgePattern : IUsage
    {
        abstract class Abstraction
        {
            protected Implementor implementor;
            public Implementor Implementor
            {
                set { implementor = value; }
            }
            public Abstraction(Implementor imp)
            {
                implementor = imp;
            }
            public virtual void Operation()
            {
                implementor.OperationImp();
            }
        }

        class RefinedAbstraction : Abstraction
        {
            public RefinedAbstraction(Implementor imp)
                : base(imp)
            { }
            public override void Operation()
            {
            }
        }

        abstract class Implementor
        {
            public abstract void OperationImp();
        }

        class ConcreteImplementorA : Implementor
        {
            public override void OperationImp()
            {
            }
        }

        class ConcreteImplementorB : Implementor
        {
            public override void OperationImp()
            {
            }
        }


        // EXAMPLE 

        interface ILanguage
        {
            void Build();
            void Execute();
        }

        class CPPLanguage : ILanguage
        {
            public void Build()
            {
                Console.WriteLine("Using the C ++ compiler, we compile the program into binary code ");
            }

            public void Execute()
            {
                Console.WriteLine("Run the executable file of the program ");
            }
        }

        class CSharpLanguage : ILanguage
        {
            public void Build()
            {
                Console.WriteLine("Using the Roslyn compiler, we compile the source code into an exe file");
            }

            public void Execute()
            {
                Console.WriteLine("JIT compiles a binary program ");
                Console.WriteLine("CLR executes compiled binary ");
            }
        }

        abstract class Programmer
        {
            protected ILanguage language;
            public ILanguage Language
            {
                set { language = value; }
            }
            public Programmer(ILanguage lang)
            {
                language = lang;
            }
            public virtual void DoWork()
            {
                language.Build();
                language.Execute();
            }
            public abstract void EarnMoney();
        }

        class FreelanceProgrammer : Programmer
        {
            public FreelanceProgrammer(ILanguage lang) : base(lang)
            {
            }
            public override void EarnMoney()
            {
                Console.WriteLine("We receive payment for the completed order ");
            }
        }

        class CorporateProgrammer : Programmer
        {
            public CorporateProgrammer(ILanguage lang)
                : base(lang)
            {
            }
            public override void EarnMoney()
            {
                Console.WriteLine("We receive a salary at the end of the month ");
            }
        }

        public void Usage()
        {
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
     
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.Read();
        }
    }
}
