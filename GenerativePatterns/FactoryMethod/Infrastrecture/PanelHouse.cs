using FactoryMethod.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Infrastrecture
{
    internal class PanelHouse : House
    {
        public PanelHouse() 
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
}
