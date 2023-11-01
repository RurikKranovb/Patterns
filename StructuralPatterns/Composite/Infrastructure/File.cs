using Composite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Infrastructure
{
    internal class File : Component
    {
        public File(string name)
                : base(name)
        { }
    }
}
