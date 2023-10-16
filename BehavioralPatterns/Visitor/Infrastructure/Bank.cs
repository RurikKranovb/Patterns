using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Core;

namespace Visitor.Infrastructure
{
    public class Bank
    {
        List<IAccont> accounts = new List<IAccont>();
        public void Add(IAccont acc)
        {
            accounts.Add(acc);
        }
        public void Remove(IAccont acc)
        {
            accounts.Remove(acc);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (IAccont acc in accounts)
                acc.Accept(visitor);
        }
    }
}
