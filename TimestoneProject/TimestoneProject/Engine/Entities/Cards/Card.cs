using System;
using TimestoneProject.Data.Collection;
using TimestoneProject.Data.Enums;

namespace TimestoneProject.Engine.Entities.Cards
{
    public class Card : Entity
    {

        internal Card(Player owner, SimpleCard card) : base(owner, EntityType.Card)
        {

        }

        virtual internal void Destroy()
        {
            throw new NotImplementedException();
        }

        internal void Discard()
        {
            throw new NotImplementedException();
        }

    }
}
