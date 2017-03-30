namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Base class for all card sheets. Card sheets contain information unique to each card or to a specific card type.
    /// </summary>
    public abstract class CardSheetBase
    {
        /// <summary>
        /// Get or set the card id.
        /// </summary>
        public string CardId { get; internal set; }

        /// <summary>
        /// Get or set the card name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Get or set the card text.
        /// </summary>
        public string Text { get; internal set; }

        /// <summary>
        /// Get or set the mana cost.
        /// </summary>
        public int ManaCost { get; internal set; }

        /// <summary>
        /// Get the card type.
        /// </summary>
        public Enums.CardType CardType { get; private set; }

        /// <summary>
        /// Create a new empty card base sheet with a specified card type.
        /// </summary>
        /// <param name="cardType">The card type.</param>
        internal CardSheetBase(Enums.CardType cardType)
        {
            CardType = cardType;
        }
    }
}
