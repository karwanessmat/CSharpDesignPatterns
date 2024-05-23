using Command3Demo._1.Command_Interface;

namespace Command3Demo._4.Invoker;
// The following code snippet illustrates the Invoker class.
// It contains two methods, SetCommand and Execute.While SetCommand is used
// to assign the command object to the private Command reference in the Invoker class,
// Execute is used to execute the command.

public class Invoker
{
    /// <summary>
    /// we defined this private filed because we have many concrete commands,
    /// so, that we did not inject in concentrator. 
    /// </summary>
    private Command _command;

    /// <summary>
    ///  we defined this method because we have many concrete commands,
    /// we just pass the needed concrete command to create instance of command
    /// </summary>
    /// <param name="command"></param>
    public void SetCommand(Command command)
    {
        _command = command;
    }
    public int Execute()
    {
        return _command.Execute();
    }
}