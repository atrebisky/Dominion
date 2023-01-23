using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Dominion
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            //create a player where it should set up everything for the player

            //shuffle cards
            GameDataStorage.playerOne.DeckOfCards = DeckManipulation.Shuffle(GameDataStorage.playerOne.DeckOfCards);

            //testing the shuffle
            string testingShuffleMessage = "";
            for(int i = 0; i < GameDataStorage.playerOne.DeckOfCards.Count(); i++)
            {
                testingShuffleMessage += GameDataStorage.playerOne.DeckOfCards[i].Name + " "; 
            }

            MessageBox.Show("The shuffled cards are: " + testingShuffleMessage);
            

            //draw 5 cards
            DeckManipulation.Draw(GameDataStorage.playerOne, 5);

            //right now I am working on just one players having cards shuffled, drawn, and discarded
            //new List<Card> playerTwoDeck = new List<Card>;
            //new List<Card> playerThreeDeck = new List<Card>;
            //new List<Card> playerFourDeck = new List<Card>;
            //new List<Card> playerFiveDeck = new List<Card>;
            //new List<Card> playerSixDeck = new List<Card>;
        }

        private void BuyPhase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buy Phase clicked");
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("End Turn clicked");
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            //Go back to setup
            GameSetup backToSetup = new GameSetup();
            this.Hide();
            backToSetup.ShowDialog();
            this.Close();
        }

        private void SeeHand_Click(object sender, EventArgs e)
        {
            //test the draw
            //hand should be the first 5 cards
            string testingHandMessage = "";
            for (int i = 0; i < GameDataStorage.playerOne.HandOfCards.Count(); i++)
            {
                testingHandMessage += GameDataStorage.playerOne.HandOfCards[i].Name + " ";
            }
            MessageBox.Show("The players hand of cards are: " + testingHandMessage);
        }

        private void SeeDeck_Click(object sender, EventArgs e)
        {

            //deck should only have 5 left after draw
            string testingDeckAfterDraw = "";
            for (int i = GameDataStorage.playerOne.DeckOfCards.Count() - 1; i >= 0; i--)
            {
                testingDeckAfterDraw += GameDataStorage.playerOne.DeckOfCards[i].Name + " ";
            }

            MessageBox.Show("Players Deck after Draw: " + testingDeckAfterDraw);
        }
    }
}
