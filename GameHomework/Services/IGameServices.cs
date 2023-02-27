using GameHomework.Entities;

namespace GameHomework.Services
{
    public interface IGameServices
    {
        void Add(Game game);

        void Update(Game game);

        void Delete(Game game);
        void Sell(Game game, Gamer gamer,Campaign campaign);
    }
}