namespace TimestoneProject.Engine.Entities.Cards
{
    public class Weapon : Card
    {
        public Weapon(Player owner) : base(owner)
        {
        }

        override internal void Destroy()
        {
            base.Destroy();
        }
    }
}
