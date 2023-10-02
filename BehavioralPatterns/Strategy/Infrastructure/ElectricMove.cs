using Strategy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Infrastructure
{
    internal class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
}
