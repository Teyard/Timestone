using System.Collections.Generic;
using System.Collections.ObjectModel;
using TimestoneProject.Data.Collection;
using TimestoneProject.Data.Enums;

namespace TimestoneProject.Data
{
    /// <summary>
    /// A static class containing card information and collections.
    /// </summary>
    public static class Cards
    {
        private static Dictionary<  string,     SimpleCard  >   cards;
        private static Dictionary<  HeroClass,  List<string>>   cardsByHeroClass;
        private static Dictionary<  CardRarity, List<string>>   cardsByRarity;
        private static Dictionary<  CardSet,    List<string>>   cardsBySet;
        private static Dictionary<  CardType,   List<string>>   cardsByType;

        private static SimpleFactory factory;

        #region Static constructor / loading

        static Cards()
        {
            cards = new Dictionary<string, SimpleCard>();
            cardsByHeroClass = new Dictionary<HeroClass, List<string>>();
            cardsByRarity = new Dictionary<CardRarity, List<string>>();
            cardsBySet = new Dictionary<CardSet, List<string>>();
            cardsByType = new Dictionary<CardType, List<string>>();

            factory = new SimpleFactory(cards);
            factory.ListByHeroClassOut = cardsByHeroClass;
            factory.ListByRarityOut = cardsByRarity;
            factory.ListBySetOut = cardsBySet;
            factory.ListByTypeOut = cardsByType;
        }

        #endregion

        #region Public access

        /// <summary>
        /// Get a dictionary containing all card id's paired with their respective simple card.
        /// </summary>
        public static readonly ReadOnlyDictionary<string, SimpleCard>
            CardById = new ReadOnlyDictionary<string, SimpleCard>(cards);

        #endregion
    }
}
