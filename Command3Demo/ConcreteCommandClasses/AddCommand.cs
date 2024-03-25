using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command3Demo.Receiver;

namespace Command3Demo.ConcreteCommandClasses
{
    public class AddCommand:Command.Command
    {
        private readonly SimpleCalculator _calculator;
        public AddCommand(SimpleCalculator receiver) : base(receiver)
        {
            _calculator = receiver;
        }

        public override int Execute()
        {
            return _calculator.Add();
        }
    }
}
