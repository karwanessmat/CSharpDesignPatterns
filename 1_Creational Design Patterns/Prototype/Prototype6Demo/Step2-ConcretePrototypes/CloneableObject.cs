using Prototype6Demo.Step1_Prototype_interface;

namespace Prototype6Demo.Step2_ConcretePrototypes;

public class CloneableObject: ICustomCloneable
{
    public CloneableObject(string title)
    {
        var random = new Random();
        Data = random.Next();
        InternalTitle = title;
    }
    public int Data { get; }

    public string InternalTitle { get; }


    public ICustomCloneable Clone()
    {
        return (CloneableObject)MemberwiseClone();

    }
}