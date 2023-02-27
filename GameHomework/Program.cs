using GameHomework.Entities;
using GameHomework.Managers;

namespace GameHomework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game testGame = new Game()
                { Id = 1, Name = "testGame", Description = "This is a test game!", Price = 150, SalesQuantity = 954 };
            Gamer gamer1 = new Gamer()
                { Id = 1, Name = "Sahin", LastName = "YAKICI", BirthDate = "15.08.2001", NationalId = "222222222" };
            Campaign summerCampaign = new Campaign()
                { Id = 1, Name = "Summer Campaign", percent = 50, Description = "2023 Summer Campaign!" };
            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager();
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(summerCampaign);
            gameManager.Sell(testGame, gamer1, summerCampaign);
            campaignManager.Update(summerCampaign,60);
            gameManager.Sell(testGame, gamer1, summerCampaign);
            gameManager.Add(testGame);
            gamerManager.Add(gamer1);
            gameManager.Update(testGame);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            gameManager.Delete(testGame);
            campaignManager.Delete(summerCampaign);
        }
    }
}