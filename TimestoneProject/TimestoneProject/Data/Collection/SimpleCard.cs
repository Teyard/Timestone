namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// A class containing the bare minimum information about a card.
    /// </summary>
    public class SimpleCard
    {

        #region Properties

        /// <summary>
        /// Get the card's attack value.
        /// </summary>
        public int Attack { get; private set; }

        /// <summary>
        /// Get the card id.
        /// </summary>
        public string CardId { get; private set; }

        /// <summary>
        /// Get the set that the card belongs to.
        /// </summary>
        public Enums.CardSet CardSet { get; private set; }

        /// <summary>
        /// Get the card type.
        /// </summary>
        public Enums.CardType CardType { get; private set; }

        /// <summary>
        /// Get the card's health/durability value.
        /// </summary>
        public int HealthDurability { get; private set; }

        /// <summary>
        /// Get the hero class that the card belongs to.
        /// </summary>
        public Enums.HeroClass HeroClass { get; private set; }

        /// <summary>
        /// Get the card's mana cost.
        /// </summary>
        public int ManaCost { get; private set; }

        /// <summary>
        /// Get the minion type of the card.
        /// </summary>
        public Enums.MinionType MinionType { get; private set; }

        /// <summary>
        /// Get the card name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Get the card rarity.
        /// </summary>
        public Enums.CardRarity Rarity { get; private set; }

        /// <summary>
        /// Get the spell type of the card.
        /// </summary>
        public Enums.SpellType SpellType { get; private set; }

        /// <summary>
        /// Get the card text.
        /// </summary>
        public string Text { get; private set; }

        #endregion

        private SimpleCard(string cardId, Enums.CardType cardType, Enums.CardSet cardSet, Enums.HeroClass heroClass, Enums.CardRarity rarity, string name, string text, int manaCost, int attack, int healthDurability, Enums.MinionType minionType, Enums.SpellType spellType)
        {
            Attack = attack;
            CardId = cardId;
            CardSet = cardSet;
            CardType = cardType;
            HealthDurability = healthDurability;
            HeroClass = heroClass;
            ManaCost = manaCost;
            Name = name;
            Rarity = rarity;
            Text = text;
        }

        #region Static CardType-specific constructors

        /// <summary>
        /// Create a new minion-type simple card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost.</param>
        /// <param name="attack">The attack value.</param>
        /// <param name="health">The base health.</param>
        /// <returns></returns>
        internal static SimpleCard MakeMinionCard(
            string cardId,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            string name,
            string text,
            int manaCost,
            int attack,
            int health,
            Enums.MinionType minionType)
        {
            return new SimpleCard(cardId, Enums.CardType.Minion, cardSet, heroClass, rarity, name, text, manaCost, attack, health, minionType, Enums.SpellType.Default);
        }

        /// <summary>
        /// Create a new minion-type simple card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost.</param>
        /// <param name="attack">The attack value.</param>
        /// <param name="health">The base health.</param>
        /// <returns></returns>
        internal static SimpleCard MakeMinionCard(
            string cardId,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            string name,
            string text,
            int manaCost,
            int attack,
            int health)
        {
            return new SimpleCard(cardId, Enums.CardType.Minion, cardSet, heroClass, rarity, name, text, manaCost, attack, health, Enums.MinionType.Default, Enums.SpellType.Default);
        }

        /// <summary>
        /// Create a new spell-type simple card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost.</param>
        /// <param name="spellType">The type of the spell.</param>
        /// <returns></returns>
        internal static SimpleCard MakeSpellCard(
            string cardId,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            string name,
            string text,
            int manaCost,
            Enums.SpellType spellType)
        {
            return new SimpleCard(cardId, Enums.CardType.Minion, cardSet, heroClass, rarity, name, text, manaCost, 0, 0, Enums.MinionType.Default, spellType);
        }

        /// <summary>
        /// Create a new spell-type simple card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost.</param>
        /// <param name="spellType">The type of the spell.</param>
        /// <returns></returns>
        internal static SimpleCard MakeSpellCard(
            string cardId,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            string name,
            string text,
            int manaCost)
        {
            return new SimpleCard(cardId, Enums.CardType.Minion, cardSet, heroClass, rarity, name, text, manaCost, 0, 0, Enums.MinionType.Default, Enums.SpellType.Default);
        }

        /// <summary>
        /// Create a new weapon-type simple card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost.</param>
        /// <param name="attack">The attack value.</param>
        /// <param name="durability">The base durability.</param>
        /// <returns></returns>
        internal static SimpleCard MakeWeaponCard(
            string cardId,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            string name,
            string text,
            int manaCost,
            int attack,
            int durability)
        {
            return new SimpleCard(cardId, Enums.CardType.Weapon, cardSet, heroClass, rarity, name, text, manaCost, attack, durability, Enums.MinionType.Default, Enums.SpellType.Default);
        }

        #endregion
    }
}
