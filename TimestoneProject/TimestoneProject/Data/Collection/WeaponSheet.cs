namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Class holding all the base information about a weapon.
    /// </summary>
    public class WeaponSheet : CardSheetBase
    {
        /// <summary>
        /// Get or set the attack value of the weapon.
        /// </summary>
        public int Attack { get; internal set; }

        /// <summary>
        /// Get or set the durability of the weapon.
        /// </summary>
        public int Durability { get; internal set; }

        /// <summary>
        /// Create a new empty weapon sheet.
        /// </summary>
        internal WeaponSheet()
            : base(Enums.CardType.Weapon) { }
    }
}
