namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Base class for all minion type card sheets.
    /// </summary>
    public abstract class MinionSheetBase : CardSheetBase
    {
        /// <summary>
        /// Get the minion type.
        /// </summary>
        public Enums.MinionType MinionType { get; private set; } = Enums.MinionType.Default;

        /// <summary>
        /// Create a new empty minion base sheet that specifies the minion type.
        /// </summary>
        /// <param name="minionType">The type of the minion.</param>
        internal MinionSheetBase(Enums.MinionType minionType)
            : base(Enums.CardType.Minion)
        {
            MinionType = minionType;
        }
    }
}
