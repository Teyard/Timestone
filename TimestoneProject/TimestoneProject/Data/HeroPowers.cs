using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TimestoneProject.Data
{
    /// <summary>
    /// A static class containing hero power information and collections.
    /// </summary>
    public static class HeroPowers
    {
        /// <summary>
        /// A collection of hero classes paired with their respective basic hero powers.
        /// </summary>
        public static readonly ReadOnlyDictionary<Enums.HeroClass, Enums.HeroPower>
            BasicHeroPowerByHeroClass =
            new ReadOnlyDictionary<Enums.HeroClass, Enums.HeroPower>(
                new Dictionary<Enums.HeroClass, Enums.HeroPower>(){
                    { Enums.HeroClass.Druid, Enums.HeroPower.Shapeshift },
                    { Enums.HeroClass.Hunter, Enums.HeroPower.SteadyShot },
                    { Enums.HeroClass.Mage, Enums.HeroPower.Fireblast },
                    { Enums.HeroClass.Paladin, Enums.HeroPower.Reinforce },
                    { Enums.HeroClass.Priest, Enums.HeroPower.LesserHeal },
                    { Enums.HeroClass.Rogue, Enums.HeroPower.DaggerMastery },
                    { Enums.HeroClass.Shaman, Enums.HeroPower.TotemicCall },
                    { Enums.HeroClass.Warlock, Enums.HeroPower.LifeTap },
                    { Enums.HeroClass.Warrior, Enums.HeroPower.ArmorUp }
                }
            );

        /// <summary>
        /// Get the basic hero power of a specified hero class.
        /// </summary>
        /// <param name="heroClass">The hero class.</param>
        /// <returns>Returns the TimestoneProject.Data.Enums.HeroPower on success, null on failure.</returns>
        public static Enums.HeroPower? GetBasicHeroPower(Enums.HeroClass heroClass)
        {
            Enums.HeroPower _out;
            if (BasicHeroPowerByHeroClass.TryGetValue(heroClass, out _out))
            {
                return _out;
            }
            return null;
        }
    }
}
