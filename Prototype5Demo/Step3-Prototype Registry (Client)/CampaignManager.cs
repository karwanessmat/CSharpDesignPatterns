using Prototype5Demo.Step1_Prototype_interface;

namespace Prototype5Demo.Step3_Prototype_Registry__Client_
{
    public class CampaignManager
    {
        public ICampaign Duplicate(ICampaign campaign)
        {
           var newCampaign = campaign.Clone();
           return newCampaign;
        }
    }
}


// Old version 
// the ICampaign interface does not have Clone() method 
// we do it to clone an object 
// be we do it 
//public class CampaignManager
//{
//    public ICampaign Duplicate(ICampaign campaign)
//    {
//        ICampaign target = null;
//        if (campaign is TextCampaign)
//        {
//            var source = (TextCampaign)campaign;
//            target = new TextCampaign();
//            target.TotalBudget = source.TotalBudget;
//            target.CampaignName = source.CampaignName;
//        }
//        else if (campaign is VideoCampaign)
//        {
//            var source = (VideoCampaign)campaign;
//            target = new VideoCampaign();
//            target.TotalBudget = source.TotalBudget;
//            target.CampaignName = source.CampaignName;
//        }
//        return target;
//    }
//}