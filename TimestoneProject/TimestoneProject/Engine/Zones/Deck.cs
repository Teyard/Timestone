using TimestoneProject.Engine.Entities.Cards;

namespace TimestoneProject.Engine.Zones
{
    public class Deck : Zone<Card>
    {
        public const int DEFAULT_MAX_SIZE = 10;

        internal Deck() : base(10) { }
    }
}
