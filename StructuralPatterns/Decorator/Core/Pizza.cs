using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Core
{
    public abstract class Pizza
    {
        public Pizza(string n)
        {
            Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}
