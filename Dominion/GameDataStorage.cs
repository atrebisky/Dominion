using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion
{
    // <summary>
    // This class is used to store game data that will be accessable. 
    // Main goal is to get setup data without having to pass it to next form
    // <summary>
    internal static class GameDataStorage
    {
        public static int NumberofPlayers;
        public static List<Card> CurrentGameAllCardList = new List<Card>();
    }
}
