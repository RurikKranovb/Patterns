using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Core
{
    public abstract class Colleague
    {
        protected Mediators mediator;

        public Colleague(Mediators mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }

        public abstract void Notify (string message);
    }
}
