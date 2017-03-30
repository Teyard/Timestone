namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Class holding all the base information about a minion.
    /// </summary>
    public class MinionSheet : MinionSheetBase
    {
        /// <summary>
        /// Get or set the attack value of the minion.
        /// </summary>
        public int Attack { get; internal set; }

        /// <summary>
        /// Get or set the health of the minion.
        /// </summary>
        public int Health { get; internal set; }

        /// <summary>
        /// Get or set the tribe the minion belongs to.
        /// </summary>
        public Enums.MinionTribe MinionTribe { get; internal set; } = Enums.MinionTribe.None;

        /// <summary>
        /// Create a new empty minion sheet.
        /// </summary>
        internal MinionSheet()
            : base(Enums.MinionType.Default) { }
    }
}
