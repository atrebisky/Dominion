using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion
{
    //player will be created during setup
    //saved in GameDataStorage
    internal class Player
    {
        public string Name { get; set; }
        public int VictoryPoints { get; set; }
        public List<Card> AllPlayerCards = new List<Card>();
        public Boolean PlayedAllCardsAlert = false;

        //Currently everyone will start with the same 7 copper and 3 estates
        public List<Card> DeckOfCards = new List<Card>
            {
                new Card { Name = "Copper" },
                new Card { Name = "Copper" },
                new Card { Name = "Copper" },
                new Card { Name = "Copper" },
                new Card { Name = "Copper" },
                new Card { Name = "Copper" },
                new Card { Name = "Copper" },
                new Card { Name = "Estate" },
                new Card { Name = "Estate" },
                new Card { Name = "Estate" }
            };


        public List<Card> HandOfCards = new List<Card>();
        public List<Card> CardsInPlay = new List<Card>();
        public List<Card> DiscardPile = new List<Card>();

    }
}
