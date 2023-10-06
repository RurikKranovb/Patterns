using State.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Infrastructure
{
    internal class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.WaterState = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
        }
    }
}
