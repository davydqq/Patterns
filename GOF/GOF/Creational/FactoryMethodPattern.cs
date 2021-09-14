using System;

namespace GOF.Creational
{
    public class FactoryMethodPattern : IUsage
    {
        abstract class Developer
        {
            public string Name { get; set; }

            public Developer(string n)
            {
                Name = n;
            }
            abstract public Product Create();
        }

        class JiraDeveloper : Developer
        {
            public JiraDeveloper(string n) : base(n)
            { }

            public override Product Create()
            {
                return new Jira();
            }
        }

        class TrelloDeveloper : Developer
        {
            public TrelloDeveloper(string n) : base(n)
            { }

            public override Product Create()
            {
                return new Trello();
            }
        }

        abstract class Product
        {

        }

        class Jira : Product
        {
            public Jira()
            {

            }
        }

        class Trello : Product
        {
            public Trello()
            {
 
            }
        }

        public void Usage()
        {
            Developer dev = new JiraDeveloper("JIRA");
            Product jira = dev.Create();

            dev = new TrelloDeveloper("Trello");
            Product trello = dev.Create();

            Console.ReadLine();
        }
    }

    /*
     When to apply a pattern

        When it is not known in advance what types of objects need to be created

        When the system must be independent of the process of creating new objects and extensible: 
        new classes can be easily introduced into it, the objects of which the system must create.

        When the creation of new objects needs to be delegated from the base class to the inherited classes     
    */

}
