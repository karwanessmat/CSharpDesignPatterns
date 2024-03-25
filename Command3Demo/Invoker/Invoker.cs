namespace Command3Demo.Invoker
{
   // The following code snippet illustrates the Invoker class.
   // It contains two methods, SetCommand and Execute.While SetCommand is used
   // to assign the command object to the private Command reference in the Invoker class,
   // Execute is used to execute the command.

    public class Invoker
    {
        private Command.Command _command;
        public void SetCommand(Command.Command command)
        {
            _command = command;
        }
        public int Execute()
        {
            return _command.Execute();
        }
    }
}
