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

        /*
         * may need to revisit shuffling
         * This method takes a deck of cards and shuffles them and then returns the shuffled deck
         */
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

        //Draw Method to take the last card("top card") from deck and add it to the hand
        public static void Draw(Player playerWhoIsDrawingCards)
        {
            //no card to draw from deck or discard
            if(playerWhoIsDrawingCards.DeckOfCards.Count == 0 && playerWhoIsDrawingCards.DiscardPile.Count == 0)
            {
                playerWhoIsDrawingCards.PlayedAllCardsAlert = true; //do i want to do anything with this?
                return;
            }
            //No card in deck deck, shuffle discard into deck
            else if(playerWhoIsDrawingCards.DeckOfCards.Count == 0)
            {
                playerWhoIsDrawingCards.DeckOfCards.AddRange(playerWhoIsDrawingCards.DiscardPile);
                playerWhoIsDrawingCards.DiscardPile.Clear();
                Shuffle(playerWhoIsDrawingCards.DeckOfCards);
            }
            Card drawnCard = playerWhoIsDrawingCards.DeckOfCards.Last(); //variable for the card drawn
            playerWhoIsDrawingCards.HandOfCards.Add(drawnCard); //add card to hand
            playerWhoIsDrawingCards.DeckOfCards.RemoveAt(playerWhoIsDrawingCards.DeckOfCards.Count - 1); //remove card from deck           
        }
    }
}
