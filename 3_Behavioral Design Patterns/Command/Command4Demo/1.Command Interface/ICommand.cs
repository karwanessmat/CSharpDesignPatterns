namespace Command4Demo._1.Command_Interface;

public interface ICommand
{
    void Execute();
    bool CanExecute();
    void Undo();
}