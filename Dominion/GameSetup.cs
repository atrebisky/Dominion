using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominion
{
    public partial class GameSetup : Form
    {
        public GameSetup()
        {
            InitializeComponent();
        }

        
        //Game Start is clicked
        private void StartGame_Click(object sender, EventArgs e)
        {
            int numberOfPlayers = ((int)this.NumberOfPlayersSelected.Value);
            //MessageBox.Show("The number of players selected was: " + numberOfPlayers);
            CreateCardList();//initate list of cards

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
            //new List<Card> playerTwoDeck = new List<Card>;
            //new List<Card> playerThreeDeck = new List<Card>;
            //new List<Card> playerFourDeck = new List<Card>;
            //new List<Card> playerFiveDeck = new List<Card>;
            //new List<Card> playerSixDeck = new List<Card>;

            //create starting hands
            for (int i=1; i<numberOfPlayers; i++)
            {
                
            }

            //new game form created
            Game newGame = new Game();
            this.Hide();
            newGame.ShowDialog();
            this.Close();
        }

        //close program button capture
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //currently just estate and copper
        private List<Card> CreateCardList()
        {
            List<Card> currentCardList = new List<Card>()
            {
                new Card { Name = "Copper" },
                new Card { Name = "Estate" }
            };
            return currentCardList;
        }

    }
}
