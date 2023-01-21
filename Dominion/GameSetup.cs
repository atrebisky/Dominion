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
            //set up game data based on selections
            GameDataStorage.NumberofPlayers = ((int)this.NumberOfPlayersSelected.Value);
            //this line below to verify data saved properly
            //MessageBox.Show("The number of players selected was: " + GameDataStorage.NumberofPlayers); 
            GameDataStorage.CurrentGameAllCardList = CreateCardList();//initate list of cards

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

        //unused at the moment even though its called and created
        //currently just estate and copper but later this will be used to determine what cards are going to be available
        //will probably create a separate class for this eventually
        private List<Card> CreateCardList()
        {
            return new List<Card>()
            {
                new Card { Name = "Copper" },
                new Card { Name = "Estate" }
            };
        }
    }
}
