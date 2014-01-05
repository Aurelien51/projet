﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChiffresEtLettres
{
    static class GameEngine
    {
        private static List<Player> players = new List<Player>();
        public static Phase CurrentPhase
        {
            get;
            private set;
        }

        public static void newGame(Player player)
        {
            GameEngine.players.Add(player);
            GameEngine.CurrentPhase = new CompteEstBon();
        }

        public static void newGame(Player player1, Player player2)
        {
            GameEngine.players.Add(player1);
            GameEngine.players.Add(player2);
            GameEngine.CurrentPhase = new CompteEstBon();
        }
    }
}
