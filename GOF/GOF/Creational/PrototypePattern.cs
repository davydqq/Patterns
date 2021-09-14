using System;

namespace GOF.Creational
{
    public class PrototypePattern : IUsage
    {
        interface IFigure
        {
            IFigure Clone();
            void GetInfo();
        }

        class Rectangle : IFigure
        {
            int width;
            int height;

            public Rectangle(int w, int h)
            {
                width = w;
                height = h;
            }

            public IFigure Clone()
            {
                return new Rectangle(this.width, this.height);
            }

            public void GetInfo()
            {
                Console.WriteLine("Height {0}, Width {1}", height, width);
            }
        }

        class Circle : IFigure
        {
            int radius;

            public Circle(int r)
            {
                radius = r;
            }

            public IFigure Clone()
            {
                return new Circle(this.radius);
            }

            public void GetInfo()
            {
                Console.WriteLine("Radius {0}", radius);
            }
        }

        public void Usage()
        {
            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }
}
