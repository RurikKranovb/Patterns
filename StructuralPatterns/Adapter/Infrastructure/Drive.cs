using Adapter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Infrastructure
{
    internal class Drive
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
