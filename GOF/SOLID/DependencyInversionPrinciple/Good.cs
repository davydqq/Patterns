using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    class Good
    {
        interface IPrinter
        {
            void Print(string text);
        }

        class Book
        {
            public string Text { get; set; }
            public IPrinter Printer { get; set; }

            public Book(IPrinter printer)
            {
                this.Printer = printer;
            }

            public void Print()
            {
                Printer.Print(Text);
            }
        }

        class ConsolePrinter : IPrinter
        {
            public void Print(string text)
            {
                Console.WriteLine("ConsolePrinter");
            }
        }

        class HtmlPrinter : IPrinter
        {
            public void Print(string text)
            {
                Console.WriteLine("HtmlPrinter");
            }
        }
    }
}
