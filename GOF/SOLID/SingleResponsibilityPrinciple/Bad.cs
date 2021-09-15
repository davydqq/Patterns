using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilityPrinciple
{
    public class Bad
    {
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

            public void Print()
            {
                Console.WriteLine(Text);
            }
        }
    }
}
