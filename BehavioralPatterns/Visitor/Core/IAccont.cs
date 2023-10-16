using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Core
{
    public interface IAccont
    {
        //void ToHtml();

        void Accept(IVisitor visitor);
    }
}
