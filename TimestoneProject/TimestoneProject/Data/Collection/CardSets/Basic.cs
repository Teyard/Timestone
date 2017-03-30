using System.Collections.Generic;
using System.Collections.ObjectModel;
using TimestoneProject.Data.Enums;

namespace TimestoneProject.Data.Collection.CardSets
{
    public static class Basic
    {
        private static Dictionary<HeroClass, List<CardSheetBase>> cards;
        
        static Basic()
        {
            cards = new Dictionary<HeroClass, List<CardSheetBase>>();

            #region Neutral

            cards[HeroClass.Neutral] = new List<CardSheetBase>()
            {
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Acidic Swamp Ooze",
                    Text = "Battlecry: Destroy your opponent's weapon.",
                    ManaCost = 2,
                    Attack = 3,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Archmage",
                    Text = "Spell Damage +1",
                    ManaCost = 6,
                    Attack = 4,
                    Health = 7,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Bloodfen Raptor",
                    Text = "",
                    ManaCost = 2,
                    Attack = 3,
                    Health = 2,
                    MinionTribe = MinionTribe.Beast
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Bluegill Warrior",
                    Text = "Charge",
                    ManaCost = 2,
                    Attack = 2,
                    Health = 1,
                    MinionTribe = MinionTribe.Murloc
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Booty Bay Bodyguard",
                    Text = "Taunt",
                    ManaCost = 5,
                    Attack = 5,
                    Health = 4,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Boulderfist Ogre",
                    Text = "",
                    ManaCost = 6,
                    Attack = 6,
                    Health = 7,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Chillwind Yeti",
                    Text = "",
                    ManaCost = 4,
                    Attack = 4,
                    Health = 5,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Core Hound",
                    Text = "",
                    ManaCost = 7,
                    Attack = 9,
                    Health = 5,
                    MinionTribe = MinionTribe.Beast
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Dalaran Mage",
                    Text = "Spell Damage +1",
                    ManaCost = 3,
                    Attack = 1,
                    Health = 4,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Darkscale Healer",
                    Text = "Battlecry: Restore 2 Health to all friendly characters.",
                    ManaCost = 5,
                    Attack = 4,
                    Health = 5,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Dragonling Mechanic",
                    Text = "Battlecry: Summon a 2/1 Mechanical Dragonling.",
                    ManaCost = 4,
                    Attack = 2,
                    Health = 4,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Elven Archer",
                    Text = "Battlecry: Deal 1 damage.",
                    ManaCost = 1,
                    Attack = 1,
                    Health = 1,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Frostwolf Grunt",
                    Text = "Taunt",
                    ManaCost = 2,
                    Attack = 2,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Frostwolf Warlord",
                    Text = "Battlecry: Gain +1/+1 for each friendly minion on the battlefield.",
                    ManaCost = 5,
                    Attack = 4,
                    Health = 4,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Gnomish Inventor",
                    Text = "Battlecry: Draw a card.",
                    ManaCost = 4,
                    Attack = 2,
                    Health = 4,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Goldshire Footman",
                    Text = "Taunt",
                    ManaCost = 1,
                    Attack = 1,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Grimscale Oracle",
                    Text = "Your other murlocs have +1 Attack.",
                    ManaCost = 1,
                    Attack = 1,
                    Health = 1,
                    MinionTribe = MinionTribe.Murloc
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Gurubashi Berserker",
                    Text = "Whenever this minion takes damage, gain +3 Attack.",
                    ManaCost = 5,
                    Attack = 2,
                    Health = 7,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Ironforge Rifleman",
                    Text = "Battlecry: Deal 1 damage.",
                    ManaCost = 3,
                    Attack = 2,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Ironfur Grizzly",
                    Text = "Taunt",
                    ManaCost = 3,
                    Attack = 3,
                    Health = 3,
                    MinionTribe = MinionTribe.Beast
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Kobold Geomancer",
                    Text = "Spell Damage +1",
                    ManaCost = 2,
                    Attack = 2,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Lord of the Arena",
                    Text = "Taunt",
                    ManaCost = 6,
                    Attack = 6,
                    Health = 5,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Magma Rager",
                    Text = "",
                    ManaCost = 3,
                    Attack = 5,
                    Health = 1,
                    MinionTribe = MinionTribe.Elemental
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Murloc Raider",
                    Text = "",
                    ManaCost = 1,
                    Attack = 2,
                    Health = 1,
                    MinionTribe = MinionTribe.Murloc
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Murloc Tidehunter",
                    Text = "Battlecry: Summon a 1/1 Murloc Scout.",
                    ManaCost = 2,
                    Attack = 2,
                    Health = 1,
                    MinionTribe = MinionTribe.Murloc
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Nightblade",
                    Text = "Battlecry: Deal 3 damage to the enemy hero.",
                    ManaCost = 5,
                    Attack = 4,
                    Health = 4,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Novice Engineer",
                    Text = "Battlecry: Draw a card.",
                    ManaCost = 2,
                    Attack = 1,
                    Health = 1,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Oasis Snapjaw",
                    Text = "",
                    ManaCost = 4,
                    Attack = 2,
                    Health = 7,
                    MinionTribe = MinionTribe.Beast
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Ogre Magi",
                    Text = "Spell Damage +1",
                    ManaCost = 4,
                    Attack = 4,
                    Health = 4,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Raid Leader",
                    Text = "Your other minions have +1 Attack.",
                    ManaCost = 3,
                    Attack = 2,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Razorfen Hunter",
                    Text = "Battlecry: Summon a 1/1 Boar.",
                    ManaCost = 3,
                    Attack = 2,
                    Health = 3,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Reckless Rocketeer",
                    Text = "Charge",
                    ManaCost = 6,
                    Attack = 5,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "River Crocolisk",
                    Text = "",
                    ManaCost = 2,
                    Attack = 2,
                    Health = 3,
                    MinionTribe = MinionTribe.Beast
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Sen'jin Shieldmasta",
                    Text = "Taunt",
                    ManaCost = 4,
                    Attack = 3,
                    Health = 5,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Shattered Sun Cleric",
                    Text = "Battlecry: Give a friendly minion +1/+1.",
                    ManaCost = 3,
                    Attack = 3,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Silverback Patriarch",
                    Text = "Taunt",
                    ManaCost = 3,
                    Attack = 1,
                    Health = 4,
                    MinionTribe = MinionTribe.Beast
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Stonetusk Board",
                    Text = "Charge",
                    ManaCost = 1,
                    Attack = 1,
                    Health = 1,
                    MinionTribe = MinionTribe.Beast
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Stormpike Commande",
                    Text = "Battlecry: Deal 2 damage.",
                    ManaCost = 5,
                    Attack = 4,
                    Health = 2,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Stormwind Champion",
                    Text = "Your other minions have +1/+1.",
                    ManaCost = 7,
                    Attack = 6,
                    Health = 6,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Stormwind Knight",
                    Text = "Charge",
                    ManaCost = 4,
                    Attack = 2,
                    Health = 5,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Voodoo Doctor",
                    Text = "Battlecry: Restore 2 Health.",
                    ManaCost = 1,
                    Attack = 2,
                    Health = 1,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "War Golem",
                    Text = "",
                    ManaCost = 7,
                    Attack = 7,
                    Health = 7,
                    MinionTribe = MinionTribe.None
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Wolfrider",
                    Text = "Charge",
                    ManaCost = 3,
                    Attack = 3,
                    Health = 1,
                    MinionTribe = MinionTribe.None
                }
            };

            #endregion

            #region Druid

            cards[HeroClass.Druid] = new List<CardSheetBase>()
            {
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Claw",
                    Text = "Give your hero +2 Attack this turn and 2 Armor.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Healing Touch",
                    Text = "Restore 8 Health.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Innervate",
                    Text = "Gain 2 Mana Crystals this turn only.",
                    ManaCost = 0
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Ironbark Protector",
                    Text = "Taunt",
                    ManaCost = 8,
                    Attack = 8,
                    Health = 8,
                    MinionTribe = MinionTribe.None
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Mark of the Wild",
                    Text = "Give a minion Taunt and +2/+2.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Moonfire",
                    Text = "Deal 1 damage.",
                    ManaCost = 0
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Savage Roar",
                    Text = "Give your characters +2 Attack this turn.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Starfire",
                    Text = "Deal 5 damage. Draw a card.",
                    ManaCost = 6
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Swipe",
                    Text = "Deal 4 damage to an enemy and 1 damage to all other enemies.",
                    ManaCost = 4
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Wild Growth",
                    Text = "Gain an empty Mana Crystal.",
                    ManaCost = 2
                }
            };

            #endregion

            #region Hunter

            cards[HeroClass.Hunter] = new List<CardSheetBase>()
            {
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Animal Companion",
                    Text = "Summon a random Beast Companion.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Arcane Shot",
                    Text = "Deal 2 damage.",
                    ManaCost = 1
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Houndmaster",
                    Text = "Battlecry: Give a friendly Beast +2/+2 and Taunt.",
                    ManaCost = 4,
                    Attack = 4,
                    Health = 3,
                    MinionTribe = MinionTribe.None
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Hunter's Mark",
                    Text = "Change a minion's Health to 1.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Kill Command",
                    Text = "Deal 3 damage. If you have a Beast, deal 5 damage instead.",
                    ManaCost = 0
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Multi-Shot",
                    Text = "Deal 3 damage to two random enemy minions.",
                    ManaCost = 4
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Starving Buzzard",
                    Text = "Whenever you summon a Beast, draw a card.",
                    ManaCost = 5,
                    Attack = 3,
                    Health = 2,
                    MinionTribe = MinionTribe.Beast
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Timber Wolf",
                    Text = "Your other Beasts have +1 Attack.",
                    ManaCost = 1,
                    Attack = 1,
                    Health = 1,
                    MinionTribe = MinionTribe.Beast
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Tracking",
                    Text = "Look at the top three cards of your deck. Draw one and discard the others.",
                    ManaCost = 1
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Tundra Rhino",
                    Text = "Your Beasts have Charge.",
                    ManaCost = 5,
                    Attack = 2,
                    Health = 5,
                    MinionTribe = MinionTribe.Beast
                }
            };

            #endregion

            #region Mage

            cards[HeroClass.Mage] = new List<CardSheetBase>()
            {
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Arcane Explosion",
                    Text = "Deal 1 damage to all enemy minions.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Arcane Intellect",
                    Text = "Draw 2 cards.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Arcane Missiles",
                    Text = "Deal 3 damage randomly split among all enemies.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Fireball",
                    Text = "Deal 6 damage.",
                    ManaCost = 4
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Flamestrike",
                    Text = "Deal 4 damage to all enemy minions.",
                    ManaCost = 7
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Frost Nova",
                    Text = "Freeze all enemy minions.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Frostbolt",
                    Text = "Deal 3 damage to a character and Freeze it.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Mirror Image",
                    Text = "Summon two 0/2 minions with Taunt.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Polymorph",
                    Text = "Transform a minion into a 1/1 Sheep.",
                    ManaCost = 1
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Water Elemental",
                    Text = "Freeze any character damaged by this minion.",
                    ManaCost = 4,
                    Attack = 3,
                    Health = 6,
                    MinionTribe = MinionTribe.Elemental
                }
            };

            #endregion

            #region Paladin

            cards[HeroClass.Paladin] = new List<CardSheetBase>()
            {
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Blessing of Kings",
                    Text = "Give a minion +4/+4.",
                    ManaCost = 4
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Blessing of Might",
                    Text = "Give a minion +3 Attack.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Consecration",
                    Text = "Deal 2 damage to all enemies.",
                    ManaCost = 4
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Guardian of Kings",
                    Text = "Battlecry: Restore 6 Health to your hero.",
                    ManaCost = 7,
                    Attack = 5,
                    Health = 6,
                    MinionTribe = MinionTribe.None
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Hammer of Wrath",
                    Text = "Deal 3 damage. Draw a card.",
                    ManaCost = 4
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Hand of Protection",
                    Text = "Give a minion Divine Shield.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Holy Light",
                    Text = "Restore 6 Health.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Humility",
                    Text = "Change a minion's Attack to 1.",
                    ManaCost = 1
                },
                new WeaponSheet()
                {
                    CardId = "",
                    Name = "Light's Justice",
                    Text = "",
                    ManaCost = 1,
                    Attack = 1,
                    Durability = 4
                },
                new WeaponSheet()
                {
                    CardId = "",
                    Name = "Truesilver Champion",
                    Text = "Whenever your hero attacks, restore 2 Health to it.",
                    ManaCost = 4,
                    Attack = 4,
                    Durability = 2
                }
            };

            #endregion

            #region Priest

            cards[HeroClass.Priest] = new List<CardSheetBase>()
            {
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Divine Spirit",
                    Text = "Double a minion's Health.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Holy Nova",
                    Text = "Deal 2 damage to all enemies. Restore 2 Health to all friendly characters.",
                    ManaCost = 5
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Holy Smite",
                    Text = "Deal 2 damage.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Mind Blast",
                    Text = "Deal 5 damage to the enemy hero.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Mind Control",
                    Text = "Take control of an enemy minion.",
                    ManaCost = 10
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Mind Vision",
                    Text = "Put a copy of a random card in your opponent's hand into your hand.",
                    ManaCost = 1
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Northshire Cleric",
                    Text = "Whenever a minion is healed, draw a card.",
                    ManaCost = 1,
                    Attack = 1,
                    Health = 3,
                    MinionTribe = MinionTribe.None
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Power Word: Shield",
                    Text = "Give a minion +2 Health. Draw a card.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Shadow Word: Death",
                    Text = "Destroy a minion with 5 or more Attack.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Shadow Word: Pain",
                    Text = "Destroy a minion with 3 or less Attack.",
                    ManaCost = 2
                }
            };

            #endregion

            #region Rogue

            cards[HeroClass.Rogue] = new List<CardSheetBase>()
            {
                new WeaponSheet()
                {
                    CardId = "",
                    Name = "Assassin's Blade",
                    Text = "",
                    ManaCost = 5,
                    Attack = 3,
                    Durability = 4
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Assassinate",
                    Text = "Destroy an enemy minion.",
                    ManaCost = 5
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Backstab",
                    Text = "Deal 2 damage to an undamaged minion.",
                    ManaCost = 0
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Deadly Poison",
                    Text = "Give your weapon +2 Attack.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Fan of Knives",
                    Text = "Deal 1 damage to all enemy minions. Draw a card.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Sap",
                    Text = "Return an enemy minion to you opponent's hand.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Shiv",
                    Text = "Deal 1 damage. Draw a card.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Sinister Strike",
                    Text = "Deal 3 damage to the enemy hero.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Sprint",
                    Text = "Draw 4 cards.",
                    ManaCost = 7
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Vanish",
                    Text = "Return all minions to their owner's hand.",
                    ManaCost = 6
                }
            };

            #endregion

            #region Shaman

            cards[HeroClass.Shaman] = new List<CardSheetBase>()
            {
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Ancestral Healing",
                    Text = "Restore a minion to full Health and give it Taunt.",
                    ManaCost = 0
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Bloodlust",
                    Text = "Give your minions +3 Attack this turn.",
                    ManaCost = 5
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Fire Elemental",
                    Text = "Battlecry: Deal 3 damage.",
                    ManaCost = 6,
                    Attack = 6,
                    Health = 5,
                    MinionTribe = MinionTribe.Elemental
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Flametongue Totem",
                    Text = "Adjacent minions have +2 Attack.",
                    ManaCost = 2,
                    Attack = 0,
                    Health = 3,
                    MinionTribe = MinionTribe.Totem
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Frost Shock",
                    Text = "Deal 1 damage to an enemy character and Freeze it.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Hex",
                    Text = "Transform a minion into a 0/1 Frog with taunt.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Rockbiter Weapon",
                    Text = "Give a friendly character +3 Attack this turn.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Totemic Might",
                    Text = "Give your Totems +2 Health.",
                    ManaCost = 0
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Windfury",
                    Text = "Give a minion Windfury",
                    ManaCost = 2
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Windspeaker",
                    Text = "Battlecry: Give a friendly minion Windfury.",
                    ManaCost = 4,
                    Attack = 3,
                    Health = 3,
                    MinionTribe = MinionTribe.None
                }
            };

            #endregion

            #region Warlock

            cards[HeroClass.Warlock] = new List<CardSheetBase>()
            {
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Corruption",
                    Text = "Choose an enemy minion. At the start of your turn, destroy it.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Drain Life",
                    Text = "Deal 2 damage. Restore 2 Health to your hero.",
                    ManaCost = 3
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Dread Infernal",
                    Text = "Battlecry: Deal 1 damage to ALL other characters.",
                    ManaCost = 6,
                    Attack = 6,
                    Health = 6,
                    MinionTribe = MinionTribe.Demon
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Hellfire",
                    Text = "Deal 3 damage to ALL characters.",
                    ManaCost = 4
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Mortal Coil",
                    Text = "Deal 1 damage to a minion. If that kills it, draw a card.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Sacrificial Pact",
                    Text = "Destroy a Demon. Restore 5 Health to your hero.",
                    ManaCost = 0
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Shadow Bolt",
                    Text = "Deal 4 damage to a minion.",
                    ManaCost = 3
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Soulfire",
                    Text = "Deal 4 damage. Discard a random card.",
                    ManaCost = 1
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Succubus",
                    Text = "Battlecry: Discard a random card.",
                    ManaCost = 2,
                    Attack = 4,
                    Health = 3,
                    MinionTribe = MinionTribe.Demon
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Voidwalker",
                    Text = "Taunt",
                    ManaCost = 1,
                    Attack = 1,
                    Health = 3,
                    MinionTribe = MinionTribe.Demon
                }
            };

            #endregion

            #region Warrior

            cards[HeroClass.Warrior] = new List<CardSheetBase>()
            {
                new WeaponSheet()
                {
                    CardId = "",
                    Name = "Arcanite Reaper",
                    Text = "",
                    ManaCost = 5,
                    Attack = 5,
                    Durability = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Charge",
                    Text = "Give a friendly minion Charge. It can't attack heroes this turn.",
                    ManaCost = 1
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Cleave",
                    Text = "Deal 2 damage to two random enemy minions.",
                    ManaCost = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Execute",
                    Text = "Destroy a damaged enemy minion.",
                    ManaCost = 2
                },
                new WeaponSheet()
                {
                    CardId = "",
                    Name = "Fiery War Axe",
                    Text = "",
                    ManaCost = 2,
                    Attack = 3,
                    Durability = 2
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Heroic Strike",
                    Text = "Give your hero +4 Attack this turn.",
                    ManaCost = 2
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Kor'Kron Elite",
                    Text = "Charge",
                    ManaCost = 4,
                    Attack = 4,
                    Health = 3,
                    MinionTribe = MinionTribe.None
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Shield Block",
                    Text = "Gain 5 Armor. Draw a card.",
                    ManaCost = 3
                },
                new MinionSheet()
                {
                    CardId = "",
                    Name = "Warsong Commander",
                    Text = "Your Charge minions have +1 Attack.",
                    ManaCost = 3,
                    Attack = 2,
                    Health = 3,
                    MinionTribe = MinionTribe.None
                },
                new SpellSheet()
                {
                    CardId = "",
                    Name = "Whirlwind",
                    Text = "Deal 1 damage to ALL minions.",
                    ManaCost = 1
                }
            };

            #endregion
        }
    }
}
