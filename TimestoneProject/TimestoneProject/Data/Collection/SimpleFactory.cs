using System;
using System.Collections.Generic;
using TimestoneProject.Data.Enums;

namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Class used for turning card sheets into simple cards.
    /// </summary>
    internal class SimpleFactory
    {
        private Dictionary<string, SimpleCard> CardsOut;

        /// <summary>
        /// This can be assumed to be either null or properly initialized.
        /// </summary>
        private Dictionary<HeroClass, List<string>> listByHeroClassOut;

        /// <summary>
        /// This can be assumed to be either null or properly initialized.
        /// </summary>
        private Dictionary<CardRarity, List<string>> listByRarityOut;

        /// <summary>
        /// This can be assumed to be either null or properly initialized.
        /// </summary>
        private Dictionary<CardSet, List<string>> listBySetOut;

        /// <summary>
        /// This can be assumed to be either null or properly initialized.
        /// </summary>
        private Dictionary<CardType, List<string>> listByTypeOut;

        /// <summary>
        /// Get or set the card set that is currently being pushed.
        /// </summary>
        internal CardSet CardSet { get; set; }

        /// <summary>
        /// Get or set the card rarity that is currently being pushed.
        /// </summary>
        internal CardRarity CardRarity { get; set; }

        /// <summary>
        /// Get or set the hero class that the cards currently being pushed belong to.
        /// </summary>
        internal HeroClass HeroClass { get; set; }

        /// <summary>
        /// Set the dictionary that the factory will push card-id's by hero class to. Setting to null will disable this.
        /// </summary>
        internal Dictionary<HeroClass, List<string>> ListByHeroClassOut
        {
            set
            {
                if (value != null)
                {
                    foreach (int type in Enum.GetValues(typeof(HeroClass)))
                    {
                        if (!value.ContainsKey((HeroClass)type))
                        {
                            value.Add((HeroClass)type, new List<string>());
                        }
                        else if (value[(HeroClass)type] == null)
                        {
                            value[(HeroClass)type] = new List<string>();
                        }
                    }
                }
                listByHeroClassOut = value;
            }
        }

        /// <summary>
        /// Set the dictionary that the factory will push card-id's by rarity to. Setting to null will disable this.
        /// </summary>
        internal Dictionary<CardRarity, List<string>> ListByRarityOut
        {
            set
            {
                if (value != null)
                {
                    foreach (int type in Enum.GetValues(typeof(CardRarity)))
                    {
                        if (!value.ContainsKey((CardRarity)type))
                        {
                            value.Add((CardRarity)type, new List<string>());
                        }
                        else if (value[(CardRarity)type] == null)
                        {
                            value[(CardRarity)type] = new List<string>();
                        }
                    }
                }
                listByRarityOut = value;
            }
        }

        /// <summary>
        /// Set the dictionary that the factory will push card-id's by card set to. Setting to null will disable this.
        /// </summary>
        internal Dictionary<CardSet, List<string>> ListBySetOut
        {
            set
            {
                if (value != null)
                {
                    foreach (int type in Enum.GetValues(typeof(CardSet)))
                    {
                        if (!value.ContainsKey((CardSet)type))
                        {
                            value.Add((CardSet)type, new List<string>());
                        }
                        else if (value[(CardSet)type] == null)
                        {
                            value[(CardSet)type] = new List<string>();
                        }
                    }
                }
                listBySetOut = value;
            }
        }

        /// <summary>
        /// Set the dictionary that the factory will push card-id's by card type to. Setting to null will disable this.
        /// </summary>
        internal Dictionary<CardType, List<string>> ListByTypeOut
        {
            set
            {
                if(value != null)
                {
                    foreach(int type in Enum.GetValues(typeof(CardType)))
                    {
                        if (!value.ContainsKey((CardType)type))
                        {
                            value.Add((CardType)type, new List<string>());
                        }
                        else if(value[(CardType)type] == null)
                        {
                            value[(CardType)type] = new List<string>();
                        }
                    }
                }
                listByTypeOut = value;
            }
        }

        /// <summary>
        /// Create a new factory for making simple cards from card sheets.
        /// </summary>
        /// <param name="outputDictionary">The dictionary the created simple cards are pushed to.</param>
        /// <exception cref="ArgumentNullException"></exception>
        internal SimpleFactory(Dictionary<string, SimpleCard> outputDictionary)
        {
            if (outputDictionary == null)
            {
                throw new ArgumentNullException("Attempting to create a new SimpleFactory with a null-reference output dictionary.");
            }
            CardsOut = outputDictionary;
        }

        /// <summary>
        /// Create a new simple card from a specified card sheet. The simple card is then pushed to the output dictionary.
        /// </summary>
        /// <param name="cardSheet">The card sheet.</param>
        /// <exception cref="ArgumentException"></exception>
        internal void Push(CardSheetBase cardSheet)
        {
            SimpleCard make = null;
            try
            {
                switch (cardSheet.CardType)
                {
                    // sheet type is minion
                    case CardType.Minion:
                        MinionSheetBase minionBase = (MinionSheetBase)cardSheet;
                        switch (minionBase.MinionType)
                        {
                            // create a simple card from the minion sheet
                            case MinionType.Default:
                                MinionSheet m = (MinionSheet)minionBase;
                                make = SimpleCard.MakeMinionCard(
                                    m.CardId,
                                    m.Name,
                                    m.Text,
                                    m.ManaCost,
                                    CardSet,
                                    HeroClass,
                                    CardRarity,
                                    m.Attack,
                                    m.Health,
                                    m.MinionTribe);
                                break;

                            // create a simple card from the permanent sheet
                            case MinionType.Permanent:
                                PermanentSheet p = (PermanentSheet)minionBase;
                                make = SimpleCard.MakePermanentCard(
                                    p.CardId,
                                    p.Name,
                                    p.Text,
                                    p.ManaCost,
                                    CardSet,
                                    HeroClass,
                                    CardRarity);
                                break;
                        }
                        break;

                    // sheet type is spell
                    case CardType.Spell:
                        SpellSheetBase spellBase = (SpellSheetBase)cardSheet;
                        switch (spellBase.SpellType)
                        {
                            // create a simple card from the spell sheet
                            case SpellType.Default:
                                SpellSheet s = (SpellSheet)spellBase;
                                make = SimpleCard.MakeSpellCard(
                                    s.CardId,
                                    s.Name,
                                    s.Text,
                                    s.ManaCost,
                                    CardSet,
                                    HeroClass,
                                    CardRarity);
                                break;

                            // create a simple card from the quest sheet
                            case SpellType.Quest:
                                QuestSheet q = (QuestSheet)spellBase;
                                make = SimpleCard.MakeQuestCard(
                                    q.CardId,
                                    q.Name,
                                    q.Text,
                                    q.ManaCost,
                                    CardSet,
                                    HeroClass,
                                    CardRarity);
                                break;

                            // create a simple card from the secret sheet
                            case SpellType.Secret:
                                SecretSheet sc = (SecretSheet)spellBase;
                                make = SimpleCard.MakeSecretCard(
                                    sc.CardId,
                                    sc.Name,
                                    sc.Text,
                                    sc.ManaCost,
                                    CardSet,
                                    HeroClass,
                                    CardRarity);
                                break;
                        }
                        break;

                    // sheet type is weapon, create a simple card from the weapon sheet
                    case CardType.Weapon:
                        WeaponSheet w = (WeaponSheet)cardSheet;
                        make = SimpleCard.MakeWeaponCard(
                            w.CardId,
                            w.Name,
                            w.Text,
                            w.ManaCost,
                            CardSet,
                            HeroClass,
                            CardRarity,
                            w.Attack,
                            w.Durability);
                        break;
                }
            }
            catch(Exception e)
            {
                throw new ArgumentException("Factory was unable to create a simple card from the provided card sheet.", e);
            }

            if(make == null)
            {
                throw new ArgumentException("Factory was unable to create a simple card from the provided card sheet.");
            }

            // add to id-by-class if active
            if(listByHeroClassOut != null)
            {
                listByHeroClassOut[HeroClass].Add(make.CardId);
            }

            // add to id-by-rarity if active
            if(listByRarityOut != null)
            {
                listByRarityOut[CardRarity].Add(make.CardId);
            }

            // add to id-by-set if active
            if(listBySetOut != null)
            {
                listBySetOut[CardSet].Add(make.CardId);
            }

            // add to id-by-type if active
            if (listByTypeOut != null)
            {
                listByTypeOut[make.CardType].Add(make.CardId);
            }

            // and finally, add to output dictionary
            CardsOut.Add(make.CardId, make);
        }
    }
}
