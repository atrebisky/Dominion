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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void BuyPhase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buy Phase clicked");
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("End Turn clicked");
        }
    }
}
