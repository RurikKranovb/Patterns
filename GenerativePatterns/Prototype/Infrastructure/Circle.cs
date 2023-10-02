using Prototype.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Infrastructure
{
    internal class Circle : IFigure
    {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(radius);
            //return MemberwiseClone() as IFigure;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Круг радиусом {radius}");
        }
    }
}
