namespace TimestoneProject.Data.Collection
{
    /// <summary>
    /// Class holding all the base information about a secret.
    /// </summary>
    public class SecretSheet : SpellSheetBase
    {
        /// <summary>
        /// Create a new empty secret sheet.
        /// </summary>
        internal SecretSheet()
            : base(Enums.SpellType.Secret) { }
    }
}
