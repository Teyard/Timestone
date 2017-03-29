using System;
using System.Collections.Generic;

namespace TimestoneProject.Engine
{
    /// <summary>
    /// Utility class dealing all the cards and lobbing all the boom bots.
    /// </summary>
    public static class RNGesus
    {
        [ThreadStatic]
        private static Random Local;

        /// <summary>
        /// Get the thread safe Random object.
        /// </summary>
        public static Random Get
        {
            get
            {
                return Local ?? (Local = new Random(unchecked((int)(DateTime.Now.Ticks + Environment.TickCount))));
            }
        }

        /// <summary>
        /// Shuffle a generic list.
        /// </summary>
        /// <typeparam name="T">The type of items in the list.</typeparam>
        /// <param name="list">The list.</param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Get.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
