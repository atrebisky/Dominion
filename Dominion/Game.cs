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

            //Next step is to end turn, moving cards to discard and drawing 5 new cards
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

        //See the hand
        private void SeeHand_Click(object sender, EventArgs e)
        {
            string testingHandMessage = "";
            for (int i = 0; i < GameDataStorage.playerOne.HandOfCards.Count(); i++)
            {
                testingHandMessage += GameDataStorage.playerOne.HandOfCards[i].Name + " ";
            }
            MessageBox.Show("The players hand of cards are: " + testingHandMessage);
        }

        //see the deck
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
