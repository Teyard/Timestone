using TimestoneProject.Engine.Entities.Cards;

namespace TimestoneProject.Engine.Zones
{
    public class Equipped : Zone<Weapon>
    {
        /// <summary>
        /// Create a new zone for equipped items.
        /// </summary>
        internal Equipped() : base(1) { }

    }
}
