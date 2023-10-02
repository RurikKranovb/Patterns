using Prototype.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Infrastructure
{
    internal class Rectangle : IFigure
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
            return new Rectangle(width, height);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Прямоугольник длиной {height} и шириной {width}");
        }
    }
}
