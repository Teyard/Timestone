using TimestoneProject.Engine.Entities.Cards;

namespace TimestoneProject.Engine.Zones
{
    public class FaceUp : Zone<Card>
    {
        internal FaceUp() : base(1) { }

        /// <summary>
        /// Force a card into the face up zone, removing any card currently in it.
        /// </summary>
        /// <param name="card">The card.</param>
        internal void Force(Card card)
        {
            Clear();
            Append(card);
        }
    }
}
