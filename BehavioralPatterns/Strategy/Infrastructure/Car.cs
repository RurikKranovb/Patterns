using Strategy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Infrastructure
{
    internal class Car
    {
        protected int passengers;
        protected string model;

        public Car(int num, string model, IMovable movable) 
        {
            passengers = num;
            this.model = model;
            Movable = movable;
        }

        public IMovable Movable { private get; set; }

        public void Move()
        {
            Movable.Move();
        }
    }
}
