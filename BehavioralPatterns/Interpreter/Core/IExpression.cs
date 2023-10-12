using Interpreter.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Core
{
    public interface IExpression
    {
        int Interpret(Context context);
    }
}
