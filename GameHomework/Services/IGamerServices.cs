using System;
using GameHomework.Entities;

namespace GameHomework.Services
{
    public interface IGamerServices
    {
        void CheckFromEGoverment(Gamer gamer);
        void Add(Gamer gamer);

        void Update(Gamer gamer);

        void Delete(Gamer gamer);
    }
}