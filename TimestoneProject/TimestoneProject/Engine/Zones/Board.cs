using TimestoneProject.Engine.Entities.Cards;

namespace TimestoneProject.Engine.Zones
{
    public class Board : Zone<Minion>
    {
        public const int DEFAULT_CAPACITY = 7;

        internal Board() : base(DEFAULT_CAPACITY) { }
    }
}
