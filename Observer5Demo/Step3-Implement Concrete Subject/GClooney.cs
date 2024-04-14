using Observer5Demo.Step1_Define_Observer_Interface;
using Observer5Demo.Step2_Define_Subject_Interface;

namespace Observer5Demo.Step3_Implement_Concrete_Subject;

public class GClooney(string tweet) : ICelebrity
{
    private readonly List<IFan> _fans = [];

    public string FullName => "George Clooney";

    public string Tweet
    {
        get => tweet;

        set => Notify(value);
    }

    public void AddFollower(IFan fan)
    {
        _fans.Add(fan);
    }

    public void RemoveFollower(IFan fan)
    {
        _fans.Remove(fan);
    }

    public void Notify(string tweet1)
    {
        tweet = tweet1;
        foreach (var fan in _fans)
        {
            fan.Update(this);
        }
    }
}