using System.Collections.Generic;
using TimestoneProject.Engine.Entities.Cards;

namespace TimestoneProject.Engine.Zones
{
    public class Hand : Zone<Card>
    {
        public const int DEFAULT_CAPACITY = 10;
        
        internal Hand() : base(DEFAULT_CAPACITY) { }
    }
}
