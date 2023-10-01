using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Core
{
    // абстрактный класс строительной компании
    //Creater
    public abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }

        // фабричный метод
        abstract public House Creater();
    }
}
