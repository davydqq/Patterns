using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosePrinciple
{
    class Good
    {
        class Cook
        {
            public string Name { get; set; }

            public Cook(string name)
            {
                this.Name = name;
            }

            public void MakeDinner(MealBase[] menu)
            {
                foreach (MealBase meal in menu)
                    meal.Make();
            }
        }

        abstract class MealBase
        {
            public void Make()
            {
                Prepare();
                Cook();
                FinalSteps();
            }
            protected abstract void Prepare();
            protected abstract void Cook();
            protected abstract void FinalSteps();
        }

        class PotatoMeal : MealBase
        {
            protected override void Cook()
            {
                Console.WriteLine("We put peeled potatoes on fire");
                Console.WriteLine("Cook for about 30 minutes");
                Console.WriteLine("Drain the rest of the water, knead the boiled potatoes in mashed potatoes");
            }

            protected override void FinalSteps()
            {
                Console.WriteLine("Sprinkle mashed potatoes with spices and herbs");
                Console.WriteLine("Mashed potatoes are ready");
            }

            protected override void Prepare()
            {
                Console.WriteLine("We clean and wash potatoes");
            }
        }

        class SaladMeal : MealBase
        {
            protected override void Cook()
            {
                Console.WriteLine("Chop tomatoes and cucumbers");
                Console.WriteLine("Sprinkle with herbs, salt and spices");
            }

            protected override void FinalSteps()
            {
                Console.WriteLine("Sprinkle with sunflower oil");
                Console.WriteLine("The salad is ready");
            }

            protected override void Prepare()
            {
                Console.WriteLine("My tomatoes and cucumbers");
            }
        }
    }
}
