namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Class holding all the base information about a quest.
    /// </summary>
    public class QuestSheet : SpellSheetBase
    {
        /// <summary>
        /// Create a new empty quest sheet.
        /// </summary>
        internal QuestSheet()
            : base(Enums.SpellType.Quest) { }
    }
}
