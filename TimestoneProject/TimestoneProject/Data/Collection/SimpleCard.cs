namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// A class containing all the basic information about a card.
    /// </summary>
    public class SimpleCard
    {
        // set constant defaults for properties not demanded by constructor
        private const int               DEFAULT_ATTACK          = -1;
        private const int               DEFAULT_HEALTH          = -1;
        private const Enums.MinionTribe DEFAULT_MINION_TRIBE    = Enums.MinionTribe.None;
        private const Enums.MinionType  DEFAULT_MINION_TYPE     = Enums.MinionType.Default;
        private const Enums.SpellType   DEFAULT_SPELL_TYPE      = Enums.SpellType.Default;

        #region Properties

        /// <summary>
        /// Get the card's attack value.
        /// </summary>
        public int Attack { get; private set; } = DEFAULT_ATTACK;

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
        public int HealthDurability { get; private set; } = DEFAULT_HEALTH;

        /// <summary>
        /// Get the hero class that the card belongs to.
        /// </summary>
        public Enums.HeroClass HeroClass { get; private set; }

        /// <summary>
        /// Get the card's mana cost.
        /// </summary>
        public int ManaCost { get; private set; }

        /// <summary>
        /// Get the minion tribe the card belongs to.
        /// </summary>
        public Enums.MinionTribe MinionTribe { get; private set; } = DEFAULT_MINION_TRIBE;

        /// <summary>
        /// Get the minion type of the card.
        /// </summary>
        public Enums.MinionType MinionType { get; private set; } = DEFAULT_MINION_TYPE;

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
        public Enums.SpellType SpellType { get; private set; } = DEFAULT_SPELL_TYPE;

        /// <summary>
        /// Get the card text.
        /// </summary>
        public string Text { get; private set; }

        #endregion

        /// <summary>
        /// Create a new simple card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="cardType">The type of the card.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        protected SimpleCard(
            string cardId, 
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.CardType cardType,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity)
        {
            CardId = cardId;
            Name = name;
            Text = text;
            ManaCost = manaCost;
            CardSet = cardSet;
            CardType = cardType;
            HeroClass = heroClass;
            Rarity = rarity;
        }

        /// <summary>
        /// Create a simple minion card with no specified tribe or type of minion.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <param name="attack">The minion attack.</param>
        /// <param name="health">The minion health.</param>
        /// <returns>A new simple card.</returns>
        internal static SimpleCard MakeMinionCard(
            string cardId,
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            int attack,
            int health)
        {
            SimpleCard make = new SimpleCard(cardId, name, text, manaCost, cardSet, Enums.CardType.Minion, heroClass, rarity);
            make.Attack = attack;
            make.HealthDurability = health;
            return make;
        }

        /// <summary>
        /// Create a simple minion card with a specified minion tribe.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <param name="attack">The minion attack.</param>
        /// <param name="health">The minion health.</param>
        /// <param name="minionTribe">The minion tribe the card belongs to.</param>
        /// <returns>A new simple card.</returns>
        internal static SimpleCard MakeMinionCard(
            string cardId,
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            int attack,
            int health,
            Enums.MinionTribe minionTribe)
        {
            SimpleCard make = MakeMinionCard(cardId, name, text, manaCost, cardSet, heroClass, rarity, attack, health);
            make.MinionTribe = minionTribe;
            return make;
        }

        /// <summary>
        /// Create a simple permanent minion card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <returns>A new simple card.</returns>
        internal static SimpleCard MakePermanentCard(
            string cardId,
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity)
        {
            SimpleCard make = new SimpleCard(cardId, name, text, manaCost, cardSet, Enums.CardType.Minion, heroClass, rarity);
            make.MinionType = Enums.MinionType.Permanent;
            return make;
        }

        /// <summary>
        /// Create a new simple spell card with a specified spell type.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The card rarity.</param>
        /// <param name="spellType">The type of the sepll.</param>
        /// <returns>A new simple card.</returns>
        internal static SimpleCard MakeSpellCard(
            string cardId,
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            Enums.SpellType spellType)
        {
            SimpleCard make = new SimpleCard(cardId, name, text, manaCost, cardSet, Enums.CardType.Spell, heroClass, rarity);
            make.SpellType = spellType;
            return make;
        }

        /// <summary>
        /// Create a simple normal spell card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The rarity of the card.</param>
        /// <returns>A new simple card.</returns>
        internal static SimpleCard MakeSpellCard(
            string cardId,
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity)
        {
            return MakeSpellCard(cardId, name, text, manaCost, cardSet, heroClass, rarity, Enums.SpellType.Default);
        }

        /// <summary>
        /// Create a simple quest spell card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The rarity of the card.</param>
        /// <returns>A new simple card.</returns>
        internal static SimpleCard MakeQuestCard(
            string cardId,
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity)
        {
            return MakeSpellCard(cardId, name, text, manaCost, cardSet, heroClass, rarity, Enums.SpellType.Quest);
        }

        /// <summary>
        /// Create a simple secret spell card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The rarity of the card.</param>
        /// <returns>A new simple card.</returns>
        internal static SimpleCard MakeSecretCard(
            string cardId,
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity)
        {
            return MakeSpellCard(cardId, name, text, manaCost, cardSet, heroClass, rarity, Enums.SpellType.Secret);
        }

        /// <summary>
        /// Create a simple weapon card.
        /// </summary>
        /// <param name="cardId">The card id.</param>
        /// <param name="name">The card name.</param>
        /// <param name="text">The card text.</param>
        /// <param name="manaCost">The mana cost of the card.</param>
        /// <param name="cardSet">The set the card belongs to.</param>
        /// <param name="heroClass">The hero class the card belongs to.</param>
        /// <param name="rarity">The rarity of the card.</param>
        /// <param name="attack">The weapon attack.</param>
        /// <param name="durability">The weapon durability.</param>
        /// <returns>A new simple card.</returns>
        internal static SimpleCard MakeWeaponCard(
            string cardId,
            string name,
            string text,
            int manaCost,
            Enums.CardSet cardSet,
            Enums.HeroClass heroClass,
            Enums.CardRarity rarity,
            int attack,
            int durability)
        {
            SimpleCard make = new SimpleCard(cardId, name, text, manaCost, cardSet, Enums.CardType.Weapon, heroClass, rarity);
            make.Attack = attack;
            make.HealthDurability = durability;
            return make;
        }
    }
}
