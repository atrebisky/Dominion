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

        //Draw Method to take the last card(top card) from deck and add it to the hand
        public static void Draw(Player playerWhoIsDrawingCards, int numberOfCardsToDraw)
        {
            for(int i = 0; i< numberOfCardsToDraw; i++)
            {
                Card drawnCard = playerWhoIsDrawingCards.DeckOfCards.Last(); //variable for the card drawn
                playerWhoIsDrawingCards.HandOfCards.Add(drawnCard); //add card to hand
                playerWhoIsDrawingCards.DeckOfCards.RemoveAt(playerWhoIsDrawingCards.DeckOfCards.Count-1); //remove card from deck
            }
            
        }
    }
}
