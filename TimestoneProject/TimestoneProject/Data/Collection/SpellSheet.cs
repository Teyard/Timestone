namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Class holding all the base information about a spell.
    /// </summary>
    public class SpellSheet : SpellSheetBase
    {
        /// <summary>
        /// Create a new empty spell sheet.
        /// </summary>
        internal SpellSheet()
            : base(Enums.SpellType.Default) { }
    }
}
