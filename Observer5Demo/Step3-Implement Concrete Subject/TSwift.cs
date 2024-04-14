using Observer5Demo.Step1_Define_Observer_Interface;
using Observer5Demo.Step2_Define_Subject_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer5Demo.Step3_Implement_Concrete_Subject;

public class Swift(string tweet) : ICelebrity
{
    private delegate void TweetUpdate(ICelebrity celebrity);
    private event TweetUpdate? OnTweetUpdate;

    public string FullName => "Taylor Swift";

    public string Tweet
    {
        get => tweet;

        set => Notify(value);
    }

    public void Notify(string tweet1)
    {
        tweet = tweet1;
        if (OnTweetUpdate != null)
        {
            OnTweetUpdate(this);
        }
    }

    public void AddFollower(IFan fan)
    {
        OnTweetUpdate += fan.Update;
    }

    public void RemoveFollower(IFan fan)
    {
        OnTweetUpdate -= fan.Update;
    }
}