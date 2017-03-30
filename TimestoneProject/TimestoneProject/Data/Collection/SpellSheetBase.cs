namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Base class for all spell type card sheets.
    /// </summary>
    public abstract class SpellSheetBase : CardSheetBase
    {
        /// <summary>
        /// Get the spell type.
        /// </summary>
        public Enums.SpellType SpellType { get; private set; }

        /// <summary>
        /// Create a new empty spell base sheet that specifies the spell type.
        /// </summary>
        /// <param name="spellType"></param>
        internal SpellSheetBase(Enums.SpellType spellType)
            : base(Enums.CardType.Spell)
        {
            SpellType = spellType;
        }
    }
}
