using System;
using GameHomework.Entities;
using GameHomework.Services;

namespace GameHomework.Managers
{
    public class GamerManager : IGamerServices
    {
        public void CheckFromEGoverment(Gamer gamer)
        {
            CheckFromEGoverment(gamer);
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " is added!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " is updated");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " is deleted!");
        }
    }
}