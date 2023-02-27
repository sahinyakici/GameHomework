using System;
using GameHomework.Entities;
using GameHomework.Services;

namespace GameHomework.Managers
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is added. Campaign percent is " + campaign.percent);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is deleted.");
        }

        public void Update(Campaign campaign,int newPercent)
        {
            campaign.percent = newPercent;
            Console.WriteLine(campaign.Name + " is added. New campaign percent is " + campaign.percent);
        }
    }
}