using System.Collections.Generic;
using System.Collections.ObjectModel;
using TimestoneProject.Data.Collection;
using TimestoneProject.Data.Enums;

namespace TimestoneView.Collection
{
    public class DeckList
    {
        private const string IS_LEGAL_DESC = "The deck is legal.";
        private const string IS_ILLEGAL_TO_SMALL_DESC = "The deck has too few cards. The default minimum is 30.";
        private const string IS_ILLEGAL_TO_BIG_DESC = "The deck has too many cards. The default maximum is 30.";
        private const string IS_ILLEGAL_TOO_MANY_COPIES_DESC = "The deck has too many copies of a non-legendary card. The default maximum is 2.";
        private const string IS_ILLEGAL_TOO_MANY_LEGENDARY_DESC = "The deck has too many copies of a legendary card. The default maximum is 1.";

        private Dictionary<SimpleCard, int> cards;

        #region Properties

        /// <summary>
        /// Get the total number of cards in the deck.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Get the number of unique cards in the deck.
        /// </summary>
        public int CountUnique { get { return cards.Keys.Count; } }

        /// <summary>
        /// Get a readonly dictionary containing all cards in the deck list such as { {SimpleCard card: int count}, ... }.
        /// </summary>
        public ReadOnlyDictionary<SimpleCard, int> Cards { get; private set; }

        /// <summary>
        /// Get whether the deck is legally built or not.
        /// </summary>
        public bool IsLegal
        {
            get
            {
                if(Count < 30)
                {
                    IsLegalDescription = IS_ILLEGAL_TO_SMALL_DESC;
                    return false;
                }
                if(Count > 30)
                {
                    IsLegalDescription = IS_ILLEGAL_TO_SMALL_DESC;
                    return false;
                }
                foreach(KeyValuePair<SimpleCard, int> card in cards)
                {
                    if(!card.Key.Rarity.Equals(CardRarity.Legendary) && card.Value > 2)
                    {
                        IsLegalDescription = IS_ILLEGAL_TOO_MANY_COPIES_DESC;
                        return false;
                    }
                    if(card.Key.Rarity.Equals(CardRarity.Legendary) && card.Value > 1)
                    {
                        IsLegalDescription = IS_ILLEGAL_TOO_MANY_LEGENDARY_DESC;
                    }
                }
                return true;
            }
        }
        
        /// <summary>
        /// Get the reasoning for why the deck is illegal.
        /// </summary>
        public string IsLegalDescription { get; private set; }

        #endregion

        /// <summary>
        /// Create a new empty deck list.
        /// </summary>
        /// <param name="heroClass"></param>
        internal DeckList(HeroClass heroClass)
        {
            cards = new Dictionary<SimpleCard, int>();
            Cards = new ReadOnlyDictionary<SimpleCard, int>(cards);
            IsLegalDescription = IS_LEGAL_DESC;
        }

        /// <summary>
        /// Add a card to the deck list.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        internal void Add(SimpleCard card)
        {
            if (cards.ContainsKey(card))
            {
                cards[card] += 1;
            }
            else
            {
                cards.Add(card, 1);
            }
            Count++;
        }

        /// <summary>
        /// Remove a card from the deck list.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        internal void Remove(SimpleCard card)
        {
            if (cards.ContainsKey(card))
            {
                if(cards[card] > 0)
                {
                    Count--;
                }
                cards[card] -= 1;
            }
            if(cards[card] <= 0)
            {
                cards.Remove(card);
            }
        }

        /// <summary>
        /// Get a list of all the cards in the deck, duplicates included.
        /// </summary>
        /// <returns>Returns a new list with all the cards.</returns>
        public List<SimpleCard> ToList()
        {
            List<SimpleCard> list = new List<SimpleCard>();
            foreach(KeyValuePair<SimpleCard, int> card in cards)
            {
                for(int i = 0; i <card.Value; i++)
                {
                    list.Add(card.Key);
                }
            }
            return list;
        }
    }
}
