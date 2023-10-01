using FactoryMethod.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Infrastrecture
{
    internal class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {
        }

        public override House Creater()
        {
            return new WoodHouse();
        }
    }
}
