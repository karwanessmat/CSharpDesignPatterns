using System;

namespace Interpreter1Demo.Context
{
    public class Context(DateTime date)
    {
        public string Expression { get; set; }
        public DateTime Date { get; set; } = date;
    }
}
