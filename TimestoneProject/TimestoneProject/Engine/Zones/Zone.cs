using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimestoneProject.Engine.Entities.Cards;

namespace TimestoneProject.Engine.Zones
{
    /// <summary>
    /// The base class for all game zones.
    /// </summary>
    /// <typeparam name="T">The type of items in the zone.</typeparam>
    public abstract class Zone<T> where T : Card
    {
        private List<T> items;
        private bool isUnlimited;

        /// <summary>
        /// Get the maximum number of items in the zone.
        /// </summary>
        public int Capacity
        {
            get
            {
                return isUnlimited ? Int32.MaxValue : items.Capacity;
            }
        }

        /// <summary>
        /// Get the number of items currently in the zone.
        /// </summary>
        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        /// <summary>
        /// Get a readonly list of all the items in the zone.
        /// </summary>
        public ReadOnlyCollection<T> Items { get; private set; }

        #region Constructors

        /// <summary>
        /// Create a new zone with a maximum number of items.
        /// </summary>
        /// <param name="maxCount">The maximum number of items in the zone.</param>
        internal Zone(int maxCount)
        {
            items = new List<T>(maxCount);
            Items = new ReadOnlyCollection<T>(items);
            isUnlimited = false;
        }

        /// <summary>
        /// Create a new zone with no restriction on the number of items in it.
        /// </summary>
        internal Zone()
        {
            items = new List<T>();
            Items = new ReadOnlyCollection<T>(items);
            isUnlimited = true;
        }

        #endregion

        /// <summary>
        /// Append an item to the end of the zone's item list.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Returns true if the item was appended, false if not.</returns>
        internal bool Append(T item)
        {
            if (isUnlimited || items.Count < items.Capacity)
            {
                items.Add(item);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes all items from the zone.
        /// </summary>
        protected void Clear()
        {
            items.Clear();
        }

        /// <summary>
        /// Increase the maximum number of items in the zone.
        /// </summary>
        /// <param name="increase">The value to increase it by.</param>
        internal void IncreaseMaxCount(int increase)
        {
            items.Capacity += increase;
        }

        /// <summary>
        /// Insert an item into the zone's item list at a specified index.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="index">The index.</param>
        /// <returns>Returns true if the item was inserted, false if not.</returns>
        internal bool Insert(int index, T item)
        {
            if (index >= items.Count)
            {
                return Append(item);
            }
            if (isUnlimited || items.Count < items.Capacity)
            {
                index = Math.Max(0, index);
                items.Insert(index, item);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Insert an item into the zone's item list at a random index.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Returns true if the item was inserted, false if not.</returns>
        internal bool InsertRandom(T item)
        {
            int index = RNGesus.Get.Next() % (items.Count + 1);
            return Insert(index, item);
        }

        /// <summary>
        /// Get the item at the specified index in the zone's item list. The item remains in the zone.
        /// </summary>
        /// <returns>An item if there is one, null if not.</returns>
        internal T Peek(int index)
        {
            if(items.Count > index)
            {
                return items[index];
            }
            return default(T); // null since T : class
        }

        /// <summary>
        /// Get an item at a random index in the zone's item list. The item remains in the zone.
        /// </summary>
        /// <returns>An item if there is one, null if not.</returns>
        internal T PeekRandom()
        {
            return items[RNGesus.Get.Next() % items.Count];
        }

        /// <summary>
        /// Get the item at the specified index in the zone's item list. The item is removed from the zone.
        /// </summary>
        /// <returns>An item if there is one, null if not.</returns>
        internal T Pull(int index)
        {
            T peek = Peek(index);
            if (peek != null)
            {
                items.RemoveAt(index);
            }
            return peek;
        }

        /// <summary>
        /// Get an item at a random index in the zone's item list. The item is removed from the zone.
        /// </summary>
        /// <returns>An item if there is one, null if not.</returns>
        internal T PullRandom()
        {
            return Pull(RNGesus.Get.Next() % items.Count);
        }

        /// <summary>
        /// Randomly shuffle the items in the zone.
        /// </summary>
        internal void Shuffle()
        {
            items.Shuffle();
        }
    }
}
