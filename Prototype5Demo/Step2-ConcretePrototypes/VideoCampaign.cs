using Prototype5Demo.Step1_Prototype_interface;

namespace Prototype5Demo.Step2_ConcretePrototypes;

public class VideoCampaign : ICampaign
{
    public decimal TotalBudget { get; set; }
    public string CampaignName { get; set; }

    public void StartCampaign()
    {
        Console.WriteLine("Starting Video Campaign");
    }

    public void PrintData()
    {
        Console.WriteLine($"Campaign Name: {CampaignName}, Total Budget: {TotalBudget}");
    }

    public ICampaign Clone()
    {
        var target = new VideoCampaign
        {
            TotalBudget = TotalBudget,
            CampaignName = CampaignName
        };
        return target;
    }
}