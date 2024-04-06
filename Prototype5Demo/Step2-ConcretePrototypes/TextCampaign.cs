using Prototype5Demo.Step1_Prototype_interface;

namespace Prototype5Demo.Step2_ConcretePrototypes;
public class TextCampaign : ICampaign
{
    public decimal TotalBudget { get; set; }
    public string CampaignName { get; set; }

    public void StartCampaign()
    {
        Console.WriteLine("Starting Text Campaign");
    }

    public void PrintData()
    {
        Console.WriteLine($"Campaign Name: {CampaignName}, Total Budget: {TotalBudget}");
    }

    public ICampaign Clone()
    {
        var target = new TextCampaign
        {
            TotalBudget = TotalBudget,
            CampaignName = CampaignName
        };
        return target;
    }
}