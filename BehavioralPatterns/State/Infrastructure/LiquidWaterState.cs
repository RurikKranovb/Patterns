using State.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Infrastructure
{
    internal class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидкость в пар");
            water.WaterState = new GasWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидкость в лед");
            water.WaterState = new SolidWaterState();
        }
    }
}
