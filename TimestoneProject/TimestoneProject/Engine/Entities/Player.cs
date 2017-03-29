using TimestoneProject.Engine.Entities.Cards;
using TimestoneProject.Engine.Zones;

namespace TimestoneProject.Engine.Entities
{
    /// <summary>
    /// Player class.
    /// </summary>
    public class Player
    {
        private static int idNext = 0;

        #region Properties

        /// <summary>
        /// Get the player id.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Get the game instance that owns the player.
        /// </summary>
        public GameInstance GameInstance { get; private set; }

        /// <summary>
        /// Get the player's opponent.
        /// </summary>
        public Player Opponent { get; private set; }

        /// <summary>
        /// Get the player's deck zone.
        /// </summary>
        public Deck Deck { get; private set; }

        /// <summary>
        /// Get the player's discard pile zone.
        /// </summary>
        public DiscardPile DiscardPile { get; private set; }

        /// <summary>
        /// Get the player's equipped zone.
        /// </summary>
        public Equipped Equipped { get; private set; }

        /// <summary>
        /// Get the player's face up zone.
        /// </summary>
        public FaceUp FaceUp { get; private set; }

        /// <summary>
        /// Get the player's graveyard zone.
        /// </summary>
        public Graveyard Graveyard { get; private set; }

        /// <summary>
        /// Get the player's hand zone.
        /// </summary>
        public Hand Hand { get; private set; }

        #endregion

        /// <summary>
        /// Create a new player object.
        /// </summary>
        /// <param name="game">The game instance.</param>
        internal Player(GameInstance game)
        {
            Id = idNext++;
            GameInstance = game;
        }

        /// <summary>
        /// Set the player's opponent.
        /// </summary>
        /// <param name="opponent">The opponent.</param>
        internal void SetOpponent(Player opponent)
        {
            Opponent = opponent;
        }

        /// <summary>
        /// The player draws a card.
        /// </summary>
        internal void Draw()
        {
            // attempt to get the top-most card from the deck
            Card draw = Deck.Pull(0);

            // card was found
            if (draw != null)
            {
                FaceUp.Force(draw);

                // if there is space in hand
                if (Hand.Count < Hand.Capacity)
                {
                    // perform onDraw events

                    // and add the card to the hand if it is still there
                    Card faceUp = FaceUp.Pull(0);
                    if (faceUp != null)
                    {
                        Deck.Append(draw);
                    }
                }

                // overdraw, the card is thus forgotten
                else
                {
                    // perform onMill events

                    FaceUp.Pull(0);
                }
            }

            // no card in deck, fatigue
            else
            {
                Fatigue();
            }
        }

        internal void Fatigue()
        {

        }
    }
}
