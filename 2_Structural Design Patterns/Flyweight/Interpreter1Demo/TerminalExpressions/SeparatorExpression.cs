using Interpreter1Demo.AbstractExpression;

namespace Interpreter1Demo.TerminalExpressions
{
    public class SeparatorExpression:IAbstractExpression    
    {
        public void Evaluate(Context.Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}
