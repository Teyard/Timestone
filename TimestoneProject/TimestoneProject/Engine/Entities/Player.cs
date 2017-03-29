namespace TimestoneProject.Engine.Entities
{
    /// <summary>
    /// Player class.
    /// </summary>
    public class Player
    {
        private static int idNext = 0;

        public int Id { get; private set; }
        public GameInstance GameInstance { get; private set; }
        public Player Opponent { get; private set; }

        /// <summary>
        /// Create a new player object.
        /// </summary>
        /// <param name="game">The game instance.</param>
        public Player(GameInstance game)
        {
            Id = idNext++;
            GameInstance = game;
        }

        internal void SetOpponent(Player opponent)
        {
            Opponent = opponent;
        }
    }
}
