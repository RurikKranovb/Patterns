using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Core
{
    public abstract class Mediators
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
