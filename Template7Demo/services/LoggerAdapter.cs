namespace Template7Demo.services
{
    public class LoggerAdapter
    {
        private readonly List<string> _messages = [];
        public void Log(string message)
        {
            _messages.Add(message);
        }

        public string Dump()
        {
            return string.Join(Environment.NewLine, _messages);
        }
    }
}
