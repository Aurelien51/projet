using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown
{
    static class GameEngine
    {
        private static List<Player> players = new List<Player>();
        public static Player[] Players
        {
            get { return players.ToArray(); }
        }
        private static int currentPlayer;

        public static Phase CurrentPhase
        {
            get;
            private set;
        }

        public static void newGame(Player player)
        {
            GameEngine.players.Add(player);

            //LongestWord word = new LongestWord();

            GameEngine.CurrentPhase = new CompteEstBon();

            currentPlayer = 0;
        }

        public static void newGame(Player player1, Player player2)
        {
            GameEngine.players.Add(player1);
            GameEngine.players.Add(player2);
            GameEngine.CurrentPhase = new CompteEstBon();

            currentPlayer = 0;
        }

        internal static bool StoreScore(int score)
        {
            players[currentPlayer].Score = score;
            if (currentPlayer+1 >= players.Count)
                return false;
            currentPlayer++;
            return true;
        }
    }
}