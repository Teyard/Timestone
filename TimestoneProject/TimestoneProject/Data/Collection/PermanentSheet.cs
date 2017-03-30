namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Class holding all the base information about a permanent.
    /// </summary>
    public class PermanentSheet : MinionSheetBase
    {
        /// <summary>
        /// Create a new empty permanent sheet.
        /// </summary>
        internal PermanentSheet()
            : base(Enums.MinionType.Permanent) { }
    }
}
