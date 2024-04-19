using System;
using System.Collections.Generic;
using Interpreter1Demo.AbstractExpression;
using Interpreter1Demo.TerminalExpressions;

namespace Interpreter1Demo
{
    internal class Program
    {
        private static void Main()
        {


            var objExpressions = new List<IAbstractExpression>();
            var context = new Context.Context(DateTime.Now);
            Console.WriteLine("Please select the Expression  :" +
                              " MM DD YYYY or YYYY MM DD or DD MM YYYY ");
            context.Expression = Console.ReadLine();

            if (context.Expression != null)
            {
                var strArray = context.Expression.Split(' ');
                foreach (var item in strArray)
                {
                    switch (item)
                    {
                        case "DD":
                            objExpressions.Add(new DayExpression());
                            break;
                        case "MM":
                            objExpressions.Add(new MonthExpression());
                            break;
                        case "YYYY":
                            objExpressions.Add(new YearExpression());
                            break;
                    }
                }
            }

            objExpressions.Add(new SeparatorExpression());
            foreach (var obj in objExpressions)
            {
                obj.Evaluate(context);
            }
            Console.WriteLine(context.Expression);
            Console.Read();
        }
    }
}
