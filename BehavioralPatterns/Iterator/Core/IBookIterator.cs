using Iterator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Core
{
    public interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
