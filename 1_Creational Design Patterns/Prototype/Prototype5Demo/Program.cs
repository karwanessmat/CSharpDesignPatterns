using Prototype5Demo.Step2_ConcretePrototypes;
using Prototype5Demo.Step3_Prototype_Registry__Client_;

//var manager =  new CampaignManager();
//var newYearCampaign = new TextCampaign()
//{
//    CampaignName = "New Year campaign",
//    TotalBudget = 1000
//} ;

//newYearCampaign.PrintData();

//var halloweenCampaign = manager.Duplicate(newYearCampaign);
//halloweenCampaign.CampaignName = "Halloween Campaign";
//Console.WriteLine();
//newYearCampaign.PrintData();
//halloweenCampaign.PrintData();

//Console.ReadLine();

var manager = new CampaignManager();

var newYearCampaign = new TextCampaign
{
    TotalBudget = 1000,
    CampaignName = "New Year Campaign"
};

newYearCampaign.PrintData();

var halloweenCampaign = manager.Duplicate(newYearCampaign);
halloweenCampaign.CampaignName = "Halloween Campaign";

Console.WriteLine("-------------------");
Console.ForegroundColor = ConsoleColor.DarkRed;

newYearCampaign.PrintData();
halloweenCampaign.PrintData();