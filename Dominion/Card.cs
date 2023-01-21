using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion
{
    // <summary>
    // Card object.
    // Stores all the data of a card
    // <summary>
    internal class Card
    {
        public string Name { get; set; }
        public string Set { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public string Text { get; set; }
        public int ActionOrVillagers { get; set; }
        public int CardsToDraw { get; set; }
        public int Buys { get; set; }
        public int CoinsOrCoffers { get; set; }
        public int Trash { get; set; }
        public int Exile { get; set; }
        public int Junk { get; set; }
        public int Gain { get; set; }
        public int VictoryPoints { get; set; }
    }
}
