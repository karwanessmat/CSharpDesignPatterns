using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
