using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilityPrinciple
{
    public class Good
    {
        interface IPrinter
        {
            void Print(string text);
        }

        class ConsolePrinter : IPrinter
        {
            public void Print(string text)
            {
                Console.WriteLine(text);
            }
        }

        class Report
        {
            public string Text { get; set; }

            public void GoToFirstPage()
            {
            }

            public void GoToLastPage()
            {
            }

            public void GoToPage(int pageNumber)
            {
                Console.WriteLine(pageNumber);
            }
            public void Print(IPrinter printer)
            {
                printer.Print(this.Text);
            }
        }
    }
}
