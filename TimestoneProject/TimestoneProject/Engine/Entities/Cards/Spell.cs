using TimestoneProject.Data.Collection;

namespace TimestoneProject.Engine.Entities.Cards
{
    public class Spell : Card
    {
        public Spell(Player owner, SimpleCard spell) : base(owner, spell)
        {
        }
    }
}
