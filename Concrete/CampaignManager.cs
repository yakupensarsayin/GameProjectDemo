using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign named \"{0}\" has been added to system.",campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign named \"{0}\" has been deleted from system.", campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign named \"{0}\" has been updated.", campaign.Name);
        }
    }
}
