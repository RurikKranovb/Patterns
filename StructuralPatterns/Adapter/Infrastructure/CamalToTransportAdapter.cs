using Adapter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Infrastructure
{
    internal class CamalToTransportAdapter : ITransport
    {
        Camel camel;
        public CamalToTransportAdapter(Camel c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}
