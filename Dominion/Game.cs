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


            //create starting hand of 7 copper and 3 estates - brute force creation
            //will eventually move this to its own class and set up some methods to just initate players starting hands all shuffled and 5 cards drawn
            List<Card> playerOneDeck = new List<Card>
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

            //shuffle cards
            playerOneDeck = DeckManipulation.Shuffle(playerOneDeck);

            //testing the shuffle
            string testingShuffleMessage = "";
            for(int i = 0; i < playerOneDeck.Count(); i++)
            {
                testingShuffleMessage += playerOneDeck[i].Name + " "; 
            }

            MessageBox.Show("The shuffled cards are: " + testingShuffleMessage);
            
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
    }
}
