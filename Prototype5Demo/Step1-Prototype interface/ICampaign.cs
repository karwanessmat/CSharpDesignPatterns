namespace Prototype5Demo.Step1_Prototype_interface
{
    public interface ICampaign
    {
        decimal TotalBudget { get; set; }
        string CampaignName { get; set; }

        void StartCampaign();
        void PrintData();

        ICampaign Clone();
    }
}
