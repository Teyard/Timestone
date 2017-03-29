using TimestoneProject.Data.Collection;

namespace TimestoneProject.Engine.Entities.Cards
{
    public class Minion : Card
    {
        public Minion(Player owner, SimpleCard minion) : base(owner, minion)
        {
        }
    }
}
