using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosePrinciple
{
    class Bad
    {
        class Cook
        {
            public string Name { get; set; }
            public Cook(string name)
            {
                this.Name = name;
            }

            public void MakeDinner()
            {
                Console.WriteLine("We clean the potatoes");
                Console.WriteLine("We put peeled potatoes on fire");
                Console.WriteLine("Drain the rest of the water, knead the boiled potatoes in mashed potatoes");
                Console.WriteLine("Sprinkle mashed potatoes with spices and herbs");
                Console.WriteLine("Mashed potatoes are ready");
            }
        }
    }
}
