using GameHomework.Entities;

namespace GameHomework.Services
{
    public class EGovermentChecker
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.Name != null && gamer.LastName != null && gamer.NationalId != null && gamer.BirthDate != null)
                return true;
            return false;
        }
    }
}