using System;
using System.Collections.Generic;
using TimestoneProject.Data.Collection;
using TimestoneProject.Data.Enums;
using TimestoneProject.Engine.Entities;

namespace TimestoneProject.Engine
{
    public class GameInstance
    {
        public Player PlayerOne { get; private set; }
        public Player PlayerTwo { get; private set; }

        /// <summary>
        /// Create a new empty game instance.
        /// </summary>
        public GameInstance()
        {
            PlayerOne = new Player(this);
            PlayerTwo = new Player(this);

            PlayerOne.SetOpponent(PlayerTwo);
            PlayerTwo.SetOpponent(PlayerOne);
        }

        /// <summary>
        /// Load a player's deck list.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="deckList">A list of cards.</param>
        /// <exception cref="ArgumentException"></exception>
        public void LoadDeckList(Player player, List<SimpleCard> deckList)
        {
            if(!(player.Equals(PlayerOne) || player.Equals(PlayerTwo)))
            {
                throw (new ArgumentException("Attempting to load a deck list for a player not currently owned by the game instance."));
            }


        }

    }
}
