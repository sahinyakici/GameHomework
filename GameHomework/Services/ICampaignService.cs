using GameHomework.Entities;

namespace GameHomework.Services
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign,int newPercent);
    }
}