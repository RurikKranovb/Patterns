using State.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Core
{
    public interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
