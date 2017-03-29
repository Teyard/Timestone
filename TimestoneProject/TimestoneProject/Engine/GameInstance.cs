using System;
using System.Collections.Generic;
using TimestoneProject.Data.Collection;
using TimestoneProject.Data.Enums;
using TimestoneProject.Engine.Entities;

namespace TimestoneProject.Engine
{
    public class GameInstance
    {
        private List<SimpleCard> p1Deck, p2Deck;

        public Player PlayerOne { get; private set; }
        public Player PlayerTwo { get; private set; }
        public Player CurrentPlayer { get; private set; }

        /// <summary>
        /// Create a new empty game instance.
        /// </summary>
        public GameInstance()
        {
            PlayerOne = new Player(this);
            PlayerTwo = new Player(this);

            PlayerOne.SetOpponent(PlayerTwo);
            PlayerTwo.SetOpponent(PlayerOne);

            p1Deck = new List<SimpleCard>();
            p2Deck = new List<SimpleCard>();
        }

        /// <summary>
        /// Load a player's deck list.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="deckList">A list of cards.</param>
        /// <exception cref="ArgumentException"></exception>
        public void LoadDeckList(Player player, List<SimpleCard> deckList)
        {
            if (player.Equals(PlayerOne))
            {
                p1Deck = deckList;
            }
            else if (player.Equals(PlayerTwo))
            {
                p2Deck = deckList;
            }
            else
            {
                throw (new ArgumentException("Attempting to load a deck list for a player not currently owned by the game instance."));
            }
            

        }

        /// <summary>
        /// Validates loading and gets the ball rolling.
        /// </summary>
        public void StartGame()
        {
            // pick a random player to go first
            CurrentPlayer = RNGesus.Get.Next() % 2 == 0 ? PlayerOne : PlayerTwo;
        }
    }
}
