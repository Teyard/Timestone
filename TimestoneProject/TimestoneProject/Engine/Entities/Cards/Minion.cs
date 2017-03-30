using TimestoneProject.Data.Collection;

namespace TimestoneProject.Engine.Entities.Cards
{
    public class Minion : Card
    {
        internal Minion(Player owner, SimpleCard minion) : base(owner, minion)
        {
        }
    }
}
