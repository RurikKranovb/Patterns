using State.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Infrastructure
{
    public class Water
    {

        public IWaterState WaterState { get; set; }

        public Water(IWaterState ws)
        {
            WaterState = ws;
        }
        #region

        //public WaterState WaterState { get; set; }

        //public Water(WaterState ws) 
        //{
        //    WaterState = ws;
        //}
        #endregion

        public void Heat()
        {
            WaterState.Heat(this);

            #region

            //if (WaterState == WaterState.SOLID)
            //{
            //    Console.WriteLine("Превращаем лед в жидкость");
            //    WaterState = WaterState.LIQUID;
            //}
            //else if (WaterState == WaterState.LIQUID)
            //{
            //    Console.WriteLine("Превращаем жидкость в пар");
            //    WaterState = WaterState.GAS;
            //}
            //else if (WaterState == WaterState.GAS)
            //{
            //    Console.WriteLine("Повышаем температуру водяного пара");
            //}
            #endregion
        }

        public void Frost()
        {
            WaterState.Frost(this);
            #region

            //if (WaterState == WaterState.LIQUID)
            //{
            //    Console.WriteLine("Превращаем жидкость в лед");
            //    WaterState = WaterState.SOLID;
            //}
            //else if (WaterState == WaterState.GAS)
            //{
            //    Console.WriteLine("Превращаем водяной пар в жидкость");
            //    WaterState = WaterState.LIQUID;
            //}
            #endregion
        }
    }
}
