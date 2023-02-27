using System;
using GameHomework.Entities;
using GameHomework.Services;

namespace GameHomework.Managers
{
    public class GameManager : IGameServices
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " is added!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " is updated!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " is deleted!");
        }

        public void Sell(Game game, Gamer gamer,Campaign campaign)
        {
            game.Price -= (game.Price * campaign.percent)/100;
            Console.WriteLine(game.Name + " is bought by " + gamer.Name + " " + gamer.LastName+". Price= "+game.Price);
        }
    }
}