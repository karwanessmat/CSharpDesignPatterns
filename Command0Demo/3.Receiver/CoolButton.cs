using Command0Demo._1.Command_Interface;

namespace Command0Demo._3.Receiver;

public class CoolButton(ICommand command)
{

    public string Text { get; set; }
    public string Name { get; set; }

    public void Click()
    {
        command.Execute();
    }
}