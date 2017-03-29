namespace TimestoneProject.Engine.Entities
{
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

        public Entity(Player owner, Data.Enums.EntityType type)
        {
            Owner = owner;
            Type = type;
        }
    }
}
