using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Structural
{
    public class DecoratorPattern: IUsage
    {
        abstract class Component
        {
            public abstract void Operation();
        }

        class ConcreteComponent : Component
        {
            public override void Operation()
            { }
        }

        abstract class Decorator : Component
        {
            protected Component component;

            public void SetComponent(Component component)
            {
                this.component = component;
            }

            public override void Operation()
            {
                if (component != null)
                    component.Operation();
            }
        }
        class ConcreteDecoratorA : Decorator
        {
            public override void Operation()
            {
                base.Operation();
            }
        }
        class ConcreteDecoratorB : Decorator
        {
            public override void Operation()
            {
                base.Operation();
            }
        }

        // EXAMPLE
        abstract class Pizza
        {
            public Pizza(string n)
            {
                this.Name = n;
            }
            public string Name { get; protected set; }
            public abstract int GetCost();
        }

        class ItalianPizza : Pizza
        {
            public ItalianPizza() : base("ItalianPizza")
            { }
            public override int GetCost()
            {
                return 10;
            }
        }

        class BulgerianPizza : Pizza
        {
            public BulgerianPizza()
                : base("BulgerianPizza")
            { }
            public override int GetCost()
            {
                return 8;
            }
        }

        abstract class PizzaDecorator : Pizza
        {
            protected Pizza pizza;
            public PizzaDecorator(string n, Pizza pizza) : base(n)
            {
                this.pizza = pizza;
            }
        }

        class TomatoPizza : PizzaDecorator
        {
            public TomatoPizza(Pizza p)
                : base(p.Name + ", with tomatos", p)
            { }

            public override int GetCost()
            {
                return pizza.GetCost() + 3;
            }
        }

        class CheesePizza : PizzaDecorator
        {
            public CheesePizza(Pizza p)
                : base(p.Name + ", with cheese", p)
            { }

            public override int GetCost()
            {
                return pizza.GetCost() + 5;
            }
        }

        public void Usage()
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); 
            Console.WriteLine("Name: {0}", pizza1.Name);
            Console.WriteLine("Price: {0}", pizza1.GetCost());

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);
            Console.WriteLine("Name: {0}", pizza2.Name);
            Console.WriteLine("Price: {0}", pizza2.GetCost());

            Pizza pizza3 = new BulgerianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);
            Console.WriteLine("Name: {0}", pizza3.Name);
            Console.WriteLine("Price: {0}", pizza3.GetCost());

            Console.ReadLine();
        }
    }
}
