using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Infrastructure
{
    public class OS
    {
        private static OS? instance;

        public string Name { get; private set; }
        private static object syncRoot = new object();

        protected OS(string name)
        {
            Name = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new OS(name);
                    }
                }
            }

            return instance;
        }
    }
}
