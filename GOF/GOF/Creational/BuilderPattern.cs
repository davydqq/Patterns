using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Creational
{
    public class BuilderPattern : IUsage
    {
        class Director
        {
            Builder builder;

            public Director(Builder builder)
            {
                this.builder = builder;
            }

            public void Construct()
            {
                builder.BuildPartA();
                builder.BuildPartB();
                builder.BuildPartC();
            }
        }

        abstract class Builder
        {
            public abstract void BuildPartA();
            public abstract void BuildPartB();
            public abstract void BuildPartC();
            public abstract Product GetResult();
        }

        class ConcreteBuilder : Builder
        {
            Product product = new Product();

            public override void BuildPartA()
            {
                product.Add("Part A");
            }

            public override void BuildPartB()
            {
                product.Add("Part B");
            }

            public override void BuildPartC()
            {
                product.Add("Part C");
            }

            public override Product GetResult()
            {
                return product;
            }
        }

        class Product
        {
            List<object> parts = new List<object>();
            public void Add(string part)
            {
                parts.Add(part);
            }
        }

        public void Usage()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
        }
    }
}
