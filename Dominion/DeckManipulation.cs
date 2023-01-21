using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominion
{
    internal static class DeckManipulation
    {
        private static Random rand = new Random();
        //may need to revisit shuffling
        public static List<Card> Shuffle<T>(this IList<T> deckThatNeedsShuffling)
        {
            for (int i = deckThatNeedsShuffling.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                T value = deckThatNeedsShuffling[k];
                deckThatNeedsShuffling[k] = deckThatNeedsShuffling[i];
                deckThatNeedsShuffling[i] = value;
            }
            return deckThatNeedsShuffling as List<Card>;
        }
    }
}
