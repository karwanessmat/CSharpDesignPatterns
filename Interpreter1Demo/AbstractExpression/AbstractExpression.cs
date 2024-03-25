using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter1Demo.AbstractExpression
{
    public interface IAbstractExpression
    {
        void Evaluate(Context.Context context);
    }
}
