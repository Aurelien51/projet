using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChiffresEtLettres
{
    static class GameEngine
    {
        enum Phase { CompteEstBon, MotPlusLong };

        private static List<Player> players = new List<Player>();
        private static Phase currentPhase;

        public static void newGame(Player player)
        {
            GameEngine.players.Add(player);
            GameEngine.currentPhase = Phase.CompteEstBon;
        }

        public static void newGame(Player player1, Player player2)
        {
            GameEngine.players.Add(player1);
            GameEngine.players.Add(player2);
            GameEngine.currentPhase = Phase.CompteEstBon;
        }
    }
}
