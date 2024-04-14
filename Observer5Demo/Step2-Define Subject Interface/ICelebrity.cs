using Observer5Demo.Step1_Define_Observer_Interface;

namespace Observer5Demo.Step2_Define_Subject_Interface;

public interface ICelebrity
{
    string FullName { get; }
    string Tweet { get; set; }
    void Notify(string tweet);
    void AddFollower(IFan fan);
    void RemoveFollower(IFan fan);
}