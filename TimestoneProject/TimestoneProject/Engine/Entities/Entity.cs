namespace TimestoneProject.Engine.Entities
{
    /// <summary>
    /// Base class for all game entities.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Get the player owning this entity.
        /// </summary>
        public Player Owner { get; private set; }

        /// <summary>
        /// Get the entity type. (obselete?)
        /// </summary>
        public Data.Enums.EntityType Type { get; private set; }

        /// <summary>
        /// Create a new game entity.
        /// </summary>
        /// <param name="owner">The player owning the entity.</param>
        /// <param name="type">The type of the entity.</param>
        public Entity(Player owner, Data.Enums.EntityType type)
        {
            Owner = owner;
            Type = type;
        }

        /// <summary>
        /// Assign a new owner to the game entity.
        /// </summary>
        /// <param name="newOwner">A new owner, the owner must be part of the same game instance.</param>
        /// <returns>Returns true when owner is succesfully changed, false if not.</returns>
        internal bool ChangeOwner(Player newOwner)
        {
            if (newOwner.GameInstance.PlayerList.Contains(newOwner))
            {
                Owner = newOwner;
                return true;
            }
            return false;
        }

    }
}
