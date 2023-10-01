using FactoryMethod.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Infrastrecture
{
    // строит панельные дома
    internal class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        {
        }

        public override House Creater()
        {
            return new PanelHouse();
        }
    }
}
