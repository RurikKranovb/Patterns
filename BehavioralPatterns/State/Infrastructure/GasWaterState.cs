using State.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Infrastructure
{
    internal class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру водяного пара");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем водяной пар в жидкость");
            water.WaterState = new LiquidWaterState();
        }
    }
}
