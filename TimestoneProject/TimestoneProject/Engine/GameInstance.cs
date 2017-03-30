using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TimestoneProject.Data.Collection;
using TimestoneProject.Data.Enums;
using TimestoneProject.Engine.Entities;
using TimestoneProject.Engine.Entities.Cards;

namespace TimestoneProject.Engine
{
    public class GameInstance
    {
        private enum GameState
        {
            Null,
            Loading,
            Mulligan
        }
        private GameState state = GameState.Null;

        private List<Player> players;
        private Dictionary<Player, List<SimpleCard>> decklists;
        private Dictionary<Player, Dictionary<Card, bool>> mulligans;
        private Dictionary<Player, bool> mulliganComplete;
        
        /// <summary>
        /// Get player one.
        /// </summary>
        public Player PlayerOne
        {
            get
            {
                return players[0];
            }
        }

        /// <summary>
        /// Get player two.
        /// </summary>
        public Player PlayerTwo
        {
            get
            {
                return players[1];
            }
        }

        /// <summary>
        /// Get the player that went first.
        /// </summary>
        public Player PlayerGoingFirst { get; private set; }

        /// <summary>
        /// Get the player whose turn it currently is.
        /// </summary>
        public Player CurrentPlayer { get; private set; }

        /// <summary>
        /// Get a list of the players in the game.
        /// </summary>
        public ReadOnlyCollection<Player> PlayerList { get; private set; }

        /// <summary>
        /// Create a new empty game instance.
        /// </summary>
        public GameInstance()
        {
            // create players
            players = new List<Player>();
            players.Add(new Player(this));
            players.Add(new Player(this));
            PlayerList = new ReadOnlyCollection<Player>(players);

            // assign opponents
            PlayerOne.SetOpponent(PlayerTwo);
            PlayerTwo.SetOpponent(PlayerOne);

            // prepare saving original decklists
            decklists = new Dictionary<Player, List<SimpleCard>>();

            // prepare mulligan phase
            mulligans = new Dictionary<Player, Dictionary<Card, bool>>();
            mulliganComplete = new Dictionary<Player, bool>();

            // finalize preparations
            foreach(Player player in players)
            {
                decklists.Add(player, new List<SimpleCard>());
                mulligans.Add(player, new Dictionary<Card, bool>());
                mulliganComplete.Add(player, false);
            }

            // update game state
            state = GameState.Loading;
        }

        /// <summary>
        /// Load a player's deck list.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="deckList">A list of cards.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public void LoadDeckList(Player player, List<SimpleCard> deckList)
        {
            // make sure we are in the loading stage of the game
            if (!state.Equals(GameState.Loading))
            {
                throw (new InvalidOperationException("Attempting to load a deck list outside of the loading phase. Current game state is " + Enum.GetName(typeof(GameState), state)));
            }

            // make sure the player is part of this game instance
            if(!players.Contains(player))
            {
                throw (new ArgumentException("Attempting to load a deck list for a player not currently owned by the game instance."));
            }

            // save original deck lists
            decklists[player] = deckList;
            
            // fill and shuffle the deck
            foreach(SimpleCard sCard in deckList)
            {
                player.Deck.Append(new Card(player, sCard));
            }
            player.Deck.Shuffle();
        }

        /// <summary>
        /// Validates loading and gets the ball rolling.
        /// </summary>
        public void InitializeGame()
        {
            // entering mulligan phase
            state = GameState.Mulligan;

            // pick a random player to go first
            CurrentPlayer = RNGesus.Get.Next() % 2 == 0 ? PlayerOne : PlayerTwo;
            PlayerGoingFirst = CurrentPlayer;

            // pull three random cards for each player and add them to the mulligans
            foreach (Player player in players)
            {
                for (int i = 0; i < 3; i++)
                {
                    Card pull = player.Deck.PullRandom();
                    if (pull != null)
                    {
                        player.Hand.Append(pull);
                        mulligans[player].Add(pull, true);
                    }
                }
            }

            // give a coin and an additional card to the player going second
            Player second = PlayerGoingFirst.Equals(PlayerOne) ? PlayerTwo : PlayerOne;
            Card pullExtra = second.Deck.PullRandom();
            if(pullExtra != null)
            {
                second.Hand.Append(pullExtra);
                mulligans[second].Add(pullExtra, true);
                // add coin
            }

        }

        /// <summary>
        /// Get a list of the cards in the mulligan for the specified player.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <returns>A list of cards.</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public List<Card> GetMulliganOptions(Player player)
        {
            // make sure we have mulligans
            if((int)state < (int)GameState.Mulligan)
            {
                throw new InvalidOperationException("Attempting to retrieve mulligan options before mulligan phase has taken place.");
            }

            // make sure the player is part of this game instance
            if (!players.Contains(player))
            {
                throw (new ArgumentException("Attempting to retrieve mulligan options for a player not currently owned by the game instance."));
            }

            return new List<Card>(mulligans[player].Keys);
        }

        /// <summary>
        /// Set the option for a card in the mulligan for the specified player.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="card">The card.</param>
        /// <param name="keepIt">Whether or not to keep it. Initial state is true.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public void SetMulligan(Player player, Card card, bool keepIt)
        {
            // make sure we have mulligans
            if ((int)state < (int)GameState.Mulligan)
            {
                throw new InvalidOperationException("Attempting to set a mulligan choice before mulligan phase has taken place.");
            }

            // make sure the player is part of this game instance
            if (!players.Contains(player))
            {
                throw (new ArgumentException("Attempting to set a mulligan choice for a player not currently owned by the game instance."));
            }

            mulligans[player][card] = keepIt;
        }

        /// <summary>
        /// Confirm the specified player's mulligan choices.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public void ConfirmMulligan(Player player)
        {
            // make sure we have mulligans
            if ((int)state < (int)GameState.Mulligan)
            {
                throw new InvalidOperationException("Attempting to confirm mulligan before mulligan phase has taken place.");
            }

            // make sure the player is part of this game instance
            if (!players.Contains(player))
            {
                throw (new ArgumentException("Attempting to confirm mulligan for a player not currently owned by the game instance."));
            }

            // throw away cards that weren't kept
            foreach(KeyValuePair<Card, bool> option in mulligans[player])
            {
                Card card = option.Key;
                bool kept = option.Value;
                if(kept == false)
                {
                    Card replacement = player.Deck.PullRandom();
                    if(replacement != null)
                    {
                        player.Hand.Remove(card);
                        player.Hand.Append(replacement);
                        player.Deck.InsertRandom(card);
                    }
                }
            }

            // set player mulligan as completed, and check if all mulligans are done
            mulliganComplete[player] = true;
            bool allMulligansComplete = true;
            foreach(bool confirmed in mulliganComplete.Values)
            {
                allMulligansComplete = confirmed && allMulligansComplete;
            }

            // all mulligans are done, start the game
            if (allMulligansComplete)
            {

            }
        }
        
    }
}
