using Interpreter1Demo.AbstractExpression;

namespace Interpreter1Demo.TerminalExpressions
{
    public class MonthExpression:IAbstractExpression
    {
        public void Evaluate(Context.Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}
